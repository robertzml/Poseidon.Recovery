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
    /// 工程类回收账户业务类
    /// </summary>
    public class ConstructionAccountBusiness : AbstractBusiness<ConstructionAccount>
    {
        #region Constructor
        /// <summary>
        /// 工程类回收账户业务类
        /// </summary>
        public ConstructionAccountBusiness()
        {
            this.baseDal = RepositoryFactory<IConstructionAccountRepository>.Instance;
        }
        #endregion //Constructor
    }
}
