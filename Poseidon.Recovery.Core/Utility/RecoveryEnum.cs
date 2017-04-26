using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Recovery.Core.Utility
{
    /// <summary>
    /// 回收能源类型
    /// </summary>
    public enum RecoveryEnergyType
    {
        /// <summary>
        /// 电
        /// </summary>
        [Display(Name = "电")]
        Electric = 1,

        /// <summary>
        /// 水
        /// </summary>
        [Display(Name = "水")]
        Water = 2,
    }
}
