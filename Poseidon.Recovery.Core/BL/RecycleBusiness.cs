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
    /// 费用回收业务类
    /// </summary>
    public class RecycleBusiness : AbstractBusiness<Recycle>
    {
        #region Constructor
        /// <summary>
        /// 费用回收业务类
        /// </summary>
        public RecycleBusiness()
        {
            this.baseDal = RepositoryFactory<IRecycleRepository>.Instance;
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 获取账户费用回收
        /// </summary>
        /// <param name="accountId">回收账户ID</param>
        /// <returns></returns>
        public IEnumerable<Recycle> FindByAccount(string accountId)
        {
            return this.baseDal.FindListByField("accountId", accountId).OrderByDescending(r => r.RecycleDate);
        }

        /// <summary>
        /// 获取账户费用回收
        /// </summary>
        /// <param name="accountId">回收账户ID</param>
        /// <param name="isPost">是否入账</param>
        /// <returns></returns>
        public IEnumerable<Recycle> FindByAccount(string accountId, bool isPost)
        {
            var dal = this.baseDal as IRecycleRepository;
            return dal.FindByAccount(accountId, isPost);
        }

        /// <summary>
        /// 获取账户费用回收
        /// </summary>
        /// <param name="accountId">回收账户ID</param>
        /// <param name="year">年度</param>
        /// <returns></returns>
        public IEnumerable<Recycle> FindByAccount(string accountId, int year)
        {
            var dal = this.baseDal as IRecycleRepository;
            return dal.FindByAccount(accountId, year);
        }

        /// <summary>
        /// 回收入账
        /// </summary>
        /// <param name="id">回收ID</param>
        /// <param name="isPost">是否入账</param>
        public void Post(string id, bool isPost)
        {
            var entity = this.baseDal.FindById(id);
            entity.IsPost = isPost;

            base.Update(entity);
        }

        /// <summary>
        /// 添加费用回收
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="user">操作用户</param>
        public void Create(Recycle entity, LoginUser user)
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
            entity.IsPost = false;
            entity.Status = 0;
            base.Create(entity);
        }

        /// <summary>
        /// 编辑费用回收
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="user">操作用户</param>
        /// <returns></returns>
        public bool Update(Recycle entity, LoginUser user)
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
