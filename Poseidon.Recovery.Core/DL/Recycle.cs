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
    /// 费用回收类
    /// </summary>
    public class Recycle : BusinessEntity
    {
        #region Property
        /// <summary>
        /// 账户ID
        /// </summary>
        [Display(Name = "账户ID")]
        public string AccountId { get; set; }

        /// <summary>
        /// 回收日期
        /// </summary>
        [Display(Name = "回收日期")]
        public DateTime RecycleDate { get; set; }      

        /// <summary>
        /// 回收金额
        /// </summary>
        [Display(Name = "回收金额")]
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// 结算记录
        /// </summary>
        [Display(Name = "结算记录")]
        public List<SettleRecord> Records { get; set; }
        #endregion //Property
    }

    /// <summary>
    /// 回收记录类
    /// </summary>
    public class RecycleRecord : BaseEntity
    {
        #region Property
        /// <summary>
        /// 费用类型
        /// </summary>
        [Dict("Energy.Recovery.FeeType")]
        [Display(Name = "费用类型")]
        public int FeeType { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [Display(Name = "金额")]
        public decimal Amount { get; set; }
        #endregion //Property
    }
}
