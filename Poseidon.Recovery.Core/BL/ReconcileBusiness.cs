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
    /// 财务对账业务类
    /// </summary>
    public class ReconcileBusiness : AbstractBusiness<Reconcile>
    {
        #region Constructor
        /// <summary>
        /// 财务对账业务类
        /// </summary>
        public ReconcileBusiness()
        {
            this.baseDal = RepositoryFactory<IReconcileRepository>.Instance;
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 查找借方信息
        /// </summary>
        /// <param name="settleId">结算ID</param>
        /// <returns></returns>
        public List<ReconcileDebit> GetDebits(string settleId)
        {
            var dal = this.baseDal as IReconcileRepository;
            var reconciles = dal.FindBySettle(settleId);

            List<ReconcileDebit> data = new List<ReconcileDebit>();
            foreach (var item in reconciles)
            {
                var debits = item.Debits.Where(r => r.SettleId == settleId);

                data.AddRange(debits);
            }

            return data;
        }

        /// <summary>
        /// 检查结算是否付清
        /// </summary>
        /// <param name="settleId">结算ID</param>
        /// <returns></returns>
        public bool CheckSettle(string settleId)
        {
            SettleBusiness settleBusiness = new SettleBusiness();
            var settle = settleBusiness.FindById(settleId);

            var debits = GetDebits(settleId);
            if (debits.Sum(r => r.Amount) >= settle.TotalAmount)
                return true;
            else
                return false;
        }

        /// <summary>
        /// 添加财务对账
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="user">操作用户</param>
        public void Create(Reconcile entity, LoginUser user)
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
            entity.Status = 0;
            base.Create(entity);

            // recycle post
            RecycleBusiness recycleBusiness = new RecycleBusiness();
            var credit = entity.Credits.First();
            recycleBusiness.Post(credit.RecycleId, true);

            // settle write-off
            SettleBusiness settleBusiness = new SettleBusiness();
            foreach (var item in entity.Debits)
            {
                if (string.IsNullOrEmpty(item.SettleId))
                    continue;

                bool isOff = CheckSettle(item.SettleId);
                settleBusiness.WriteOff(item.SettleId, isOff);
            }
        }

        /// <summary>
        /// 编辑财务对账
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="user">操作用户</param>
        /// <returns></returns>
        public bool Update(Reconcile entity, LoginUser user)
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
