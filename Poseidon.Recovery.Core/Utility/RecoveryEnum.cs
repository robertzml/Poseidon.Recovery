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

    /// <summary>
    /// 表具类型
    /// </summary>
    public enum MeterEnergyType
    {
        /// <summary>
        /// 电表
        /// </summary>
        [Display(Name = "电表")]
        Electric = 1,

        /// <summary>
        /// 水表
        /// </summary>
        [Display(Name = "水表")]
        Water = 2,
    }

    /// <summary>
    /// 表具计费类型
    /// </summary>
    public enum MeterChargeType
    {
        /// <summary>
        /// 预付费
        /// </summary>
        [Display(Name = "预付费")]
        PrePaid = 1,

        /// <summary>
        /// 后付费
        /// </summary>
        [Display(Name = "后付费")]
        PosePaid = 2
    }
}
