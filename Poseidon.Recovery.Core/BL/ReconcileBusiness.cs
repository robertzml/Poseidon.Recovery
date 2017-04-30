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
    }
}
