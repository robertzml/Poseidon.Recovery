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
    /// 经营类回收账户业务类
    /// </summary>
    public class CommerceAccountBusiness : AbstractBusiness<CommerceAccount>
    {
        #region Constructor
        /// <summary>
        /// 经营类回收账户业务类
        /// </summary>
        public CommerceAccountBusiness()
        {
            this.baseDal = RepositoryFactory<ICommerceAccountRepository>.Instance;
        }
        #endregion //Constructor
    }
}
