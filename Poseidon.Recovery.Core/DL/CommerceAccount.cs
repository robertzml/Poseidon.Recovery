using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Recovery.Core.DL
{
    /// <summary>
    /// 经营类回收账户
    /// </summary>
    public class CommerceAccount : Account
    {
        #region Property
        /// <summary>
        /// 计费建筑
        /// </summary>
        [Display(Name = "计费建筑")]
        public string ChargeBuildingId { get; set; }
        #endregion //Property
    }
}
