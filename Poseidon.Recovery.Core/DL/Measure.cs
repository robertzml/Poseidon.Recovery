using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Recovery.Core.DL
{
    using Poseidon.Base.Framework;
    using Poseidon.Base.Utility;

    /// <summary>
    /// 抄表计量类
    /// </summary>
    public class Measure : BusinessEntity
    {
        #region Property
        /// <summary>
        /// 账户ID
        /// </summary>
        [Display(Name = "账户ID")]
        public string AccountId { get; set; }

        ///// <summary>
        ///// 费用类型
        ///// </summary>
        //[Dict("Energy.Recovery.FeeType")]
        //[Display(Name = "费用类型")]
        //public int FeeType { get; set; }

        /// <summary>
        /// 抄表日期
        /// </summary>
        [Display(Name = "抄表日期")]
        public DateTime MeasureDate { get; set; }

        /// <summary>
        /// 抄表记录
        /// </summary>
        [Display(Name = "抄表记录")]
        public List<MeasureRecord> Records { get; set; }
        #endregion //Property
    }

    /// <summary>
    /// 抄表记录
    /// </summary>
    public class MeasureRecord : BaseEntity
    {
        #region Property
        /// <summary>
        /// 表具ID
        /// </summary>
        [Display(Name = "表具ID")]
        public string MeterId { get; set; }

        /// <summary>
        /// 读数
        /// </summary>
        [Display(Name = "读数")]
        public decimal Indication { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [Display(Name = "备注")]
        public string Remark { get; set; }
        #endregion //Property
    }
}
