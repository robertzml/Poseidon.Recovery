using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Recovery.Core.Utility
{
    using Poseidon.Base.Framework;

    /// <summary>
    /// 回收数据模型
    /// </summary>
    public class RecoveryDataModel : BaseEntity
    {
        #region Property
        /// <summary>
        /// 归属日期
        /// </summary>
        [Display(Name = "归属日期")]
        public string BelongDate { get; set; }

        /// <summary>
        /// 应收费用
        /// </summary>
        [Display(Name = "应收费用")]
        public decimal DueFee { get; set; }

        /// <summary>
        /// 已收费用
        /// </summary>
        [Display(Name = "已收费用")]
        public decimal PaidFee { get; set; }
        #endregion //Property
    }
}
