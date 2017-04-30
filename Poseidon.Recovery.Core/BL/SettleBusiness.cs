using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Recovery.Core.BL
{
    using Poseidon.Base.Framework;
    using Poseidon.Base.System;
    using Poseidon.Recovery.Core.DL;
    using Poseidon.Recovery.Core.IDAL;

    /// <summary>
    /// 费用结算业务类
    /// </summary>
    public class SettleBusiness : AbstractBusiness<Settle>
    {
        #region Constructor
        /// <summary>
        /// 费用结算业务类
        /// </summary>
        public SettleBusiness()
        {
            this.baseDal = RepositoryFactory<ISettleRepository>.Instance;
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 获取账户费用结算
        /// </summary>
        /// <param name="accountId">回收账户ID</param>
        /// <returns></returns>
        public IEnumerable<Settle> FindByAccount(string accountId)
        {
            return this.baseDal.FindListByField("accountId", accountId).OrderByDescending(r => r.CurrentDate);
        }

        /// <summary>
        /// 获取账户费用结算
        /// </summary>
        /// <param name="accountId">回收账户ID</param>
        /// <param name="isFree">是否免费</param>
        /// <param name="isWriteOff">是否核销</param>
        /// <returns></returns>
        public IEnumerable<Settle> FindByAccount(string accountId, bool isFree, bool isWriteOff)
        {
            var dal = this.baseDal as ISettleRepository;
            return dal.FindByAccount(accountId, isFree, isWriteOff);
        }

        /// <summary>
        /// 结算核销
        /// </summary>
        /// <param name="id">结算ID</param>
        /// <param name="isWriteOff">是否核销</param>
        public void WriteOff(string id, bool isWriteOff)
        {
            var entity = this.baseDal.FindById(id);
            entity.IsWriteOff = isWriteOff;

            base.Update(entity);
        }

        /// <summary>
        /// 添加费用结算
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="user">操作用户</param>
        public void Create(Settle entity, LoginUser user)
        {
            entity.CreateBy = new UpdateStamp
            {
                UserId = user.Id,
                Name = user.Name,
                Time = DateTime.Now
            };
            entity.UpdateBy = new UpdateStamp
            {
                UserId = user.Id,
                Name = user.Name,
                Time = DateTime.Now
            };
            entity.IsWriteOff = false;
            entity.Status = 0;
            base.Create(entity);
        }

        /// <summary>
        /// 编辑费用结算
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="user">操作用户</param>
        /// <returns></returns>
        public bool Update(Settle entity, LoginUser user)
        {
            entity.UpdateBy = new UpdateStamp
            {
                UserId = user.Id,
                Name = user.Name,
                Time = DateTime.Now
            };
            return base.Update(entity);
        }
        #endregion //Method
    }
}
