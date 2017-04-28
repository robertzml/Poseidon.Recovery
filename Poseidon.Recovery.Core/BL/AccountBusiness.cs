using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Recovery.Core.BL
{
    using Poseidon.Base.Framework;
    using Poseidon.Recovery.Core.DL;
    using Poseidon.Recovery.Core.IDAL;

    /// <summary>
    /// 回收账户业务类
    /// </summary>
    public class AccountBusiness : AbstractBusiness<Account>
    {
        #region Constructor
        /// <summary>
        /// 回收账户业务类
        /// </summary>
        public AccountBusiness()
        {
            this.baseDal = RepositoryFactory<IAccountRepository>.Instance;
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 设置表具
        /// </summary>
        /// <param name="id">账户ID</param>
        /// <param name="meters">表具列表</param>
        public void SetMeters(string id, List<Meter> meters)
        {
            var dal = this.baseDal as IAccountRepository;
            dal.SetMeters(id, meters);
        }
        #endregion //Method
    }
}
