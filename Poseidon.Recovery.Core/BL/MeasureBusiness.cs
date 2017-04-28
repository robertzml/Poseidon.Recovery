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
    }
}
