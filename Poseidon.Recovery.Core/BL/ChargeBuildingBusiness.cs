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
    /// 计费建筑业务类
    /// </summary>
    public class ChargeBuildingBusiness : AbstractBusiness<ChargeBuilding>
    {
        #region Constructor
        /// <summary>
        /// 计费建筑业务类
        /// </summary>
        public ChargeBuildingBusiness()
        {
            this.baseDal = RepositoryFactory<IChargeBuildingRepository>.Instance;
        }
        #endregion //Constructor
    }
}
