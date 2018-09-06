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
            return dal.FindByAccount(accountId, isFree, isWriteOff).OrderBy(r => r.SettleDate);
        }

        /// <summary>
        /// 获取账户费用结算
        /// </summary>
        /// <param name="accountId">回收账户ID</param>
        /// <param name="year">年度</param>
        /// <returns></returns>
        public IEnumerable<Settle> FindByAccount(string accountId, int year)
        {
            var dal = this.baseDal as ISettleRepository;
            return dal.FindByAccount(accountId, year).OrderBy(r => r.SettleDate);
        }

        /// <summary>
        /// 结算核销
        /// </summary>
        /// <param name="id">结算ID</param>
        /// <param name="offAmount">核销金额</param>
        public void WriteOff(string id, decimal offAmount)
        {
            var entity = this.baseDal.FindById(id);

            if (entity.IsFree)
                entity.IsWriteOff = true;
            else
            {
                if (entity.TotalAmount - entity.OffAmount - offAmount > 0)
                    entity.IsWriteOff = false;
                else
                    entity.IsWriteOff = true;

                entity.OffAmount += offAmount;
            }

            base.Update(entity);
        }

        /// <summary>
        /// 检查更新核销金额
        /// </summary>
        /// <param name="id">结算ID</param>
        public void UpdateOffAmount(string id)
        {
            var entity = this.baseDal.FindById(id);

            ReconcileBusiness reconcileBusiness = new ReconcileBusiness();
            var debits = reconcileBusiness.GetDebits(id);

            var offAmount = debits.Sum(r => r.Amount);

            if (entity.IsFree)
            {
                entity.IsWriteOff = true;
            }
            else
            {
                entity.OffAmount = offAmount;
                if (entity.TotalAmount - entity.OffAmount > 0)
                    entity.IsWriteOff = false;
                else
                    entity.IsWriteOff = true;
            }

            base.Update(entity);
        }

        /// <summary>
        /// 检查费用结算能否删除
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        public bool CheckDelete(Settle entity)
        {
            if (entity.OffAmount > 0 || entity.IsWriteOff)
                return false;

            if (entity.AttachmentIds != null && entity.AttachmentIds.Count > 0)
                return false;

            ReconcileBusiness reconcileBusiness = new ReconcileBusiness();
            var reconcile = reconcileBusiness.FindBySettle(entity.Id).ToList();
            if (reconcile.Count > 0)
                return false;

            return true;
        }

        /// <summary>
        /// 添加费用结算
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="user">操作用户</param>
        public void Create(Settle entity, ILoginUser user)
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

            if (entity.IsFree == true)
                entity.IsWriteOff = true;
            else
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
        public bool Update(Settle entity, ILoginUser user)
        {
            entity.UpdateBy = new UpdateStamp
            {
                UserId = user.Id,
                Name = user.Name,
                Time = DateTime.Now
            };
            if (entity.IsFree == true)
                entity.IsWriteOff = true;
            else
                entity.IsWriteOff = false;
            return base.Update(entity);
        }
        #endregion //Method
    }
}
