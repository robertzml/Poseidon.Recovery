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
    /// 财务对账类
    /// </summary>
    public class Reconcile : BusinessEntity
    {
        #region Property
        /// <summary>
        /// 账户ID
        /// </summary>
        [Display(Name = "账户ID")]
        public string AccountId { get; set; }

        /// <summary>
        /// 费用回收ID
        /// </summary>
        [Display(Name = "费用回收ID")]
        public string RecycleId { get; set; }

        /// <summary>
        /// 费用结算ID
        /// </summary>
        [Display(Name = "费用结算ID")]
        public List<string> SettleIds { get; set; }

        /// <summary>
        /// 入账日期
        /// </summary>
        [Display(Name = "入账日期")]
        public DateTime ReconcileDate { get; set; }

        /// <summary>
        /// 凭证号
        /// </summary>
        [Display(Name = "凭证号")]
        public string Certificate { get; set; }

        /// <summary>
        /// 摘要
        /// </summary>
        [Display(Name = "摘要")]
        public string Summary { get; set; }
        #endregion //Property
    }
}
