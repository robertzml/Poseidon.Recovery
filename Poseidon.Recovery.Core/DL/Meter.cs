using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Recovery.Core.DL
{
    using Poseidon.Base.Framework;

    /// <summary>
    /// 计量表具
    /// </summary>
    public class Meter : ObjectEntity
    {
        #region Property
        /// <summary>
        /// 表号
        /// </summary>
        [Display(Name = "表号")]
        public string Number { get; set; }

        /// <summary>
        /// 类型，电表、水表
        /// </summary>
        [Display(Name = "类型")]
        public int EnergyType { get; set; }

        /// <summary>
        /// 计费方式，预付费、后付费
        /// </summary>
        [Display(Name = "计费方式")]
        public int ChargeType { get; set; }

        /// <summary>
        /// 倍率
        /// </summary>
        [Display(Name = "倍率")]
        public decimal Multiple { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        [Display(Name = "地址")]
        public string Address { get; set; }
        #endregion //Property
    }
}
