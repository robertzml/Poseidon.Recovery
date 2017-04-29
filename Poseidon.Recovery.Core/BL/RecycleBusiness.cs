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
    }
}
