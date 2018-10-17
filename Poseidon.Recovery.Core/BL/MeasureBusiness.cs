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
    /// 抄表计量业务类
    /// </summary>
    public class MeasureBusiness : AbstractBusiness<Measure>
    {
        #region Constructor
        /// <summary>
        /// 抄表计量业务类
        /// </summary>
        public MeasureBusiness()
        {
            this.baseDal = RepositoryFactory<IMeasureRepository>.Instance;
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 获取账户抄表计量
        /// </summary>
        /// <param name="accountId">回收账户ID</param>
        /// <returns></returns>
        public IEnumerable<Measure> FindByAccount(string accountId)
        {
            return this.baseDal.FindListByField("accountId", accountId).OrderByDescending(r => r.MeasureDate);
        }

        /// <summary>
        /// 添加抄表计量
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="user">操作用户</param>
        public void Create(Measure entity, ILoginUser user)
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
        }

        /// <summary>
        /// 编辑抄表计量
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <param name="user">操作用户</param>
        /// <returns></returns>
        public (bool success, string errorMessage) Update(Measure entity, ILoginUser user)
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
