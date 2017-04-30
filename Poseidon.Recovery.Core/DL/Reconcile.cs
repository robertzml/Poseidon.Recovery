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
        /// 借方信息
        /// </summary>
        [Display(Name = "借方信息")]
        public List<ReconcileDebit> Debits { get; set; }

        /// <summary>
        /// 贷方信息
        /// </summary>
        [Display(Name = "贷方信息")]
        public List<ReconcileCredit> Credits { get; set; }

        /// <summary>
        /// 入账日期
        /// </summary>
        [Display(Name = "入账日期")]
        public DateTime ReconcileDate { get; set; }

        /// <summary>
        /// 凭证ID
        /// </summary>
        [Display(Name = "凭证ID")]
        public string CertificateId { get; set; }

        /// <summary>
        /// 凭证号
        /// </summary>
        [Display(Name = "凭证号")]
        public string CertificateNumber { get; set; }

        /// <summary>
        /// 摘要
        /// </summary>
        [Display(Name = "摘要")]
        public string Summary { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [Display(Name = "金额")]
        public decimal Amount { get; set; }
        #endregion //Property
    }

    /// <summary>
    /// 对账借方类
    /// </summary>
    /// <remarks>
    /// 对账中表示账户相关结算信息
    /// </remarks>
    public class ReconcileDebit : BaseEntity
    {
        #region Property
        /// <summary>
        /// 账户ID
        /// </summary>
        [Display(Name = "账户ID")]
        public string AccountId { get; set; }

        /// <summary>
        /// 费用结算ID
        /// </summary>
        [Display(Name = "费用结算ID")]
        public string SettleId { get; set; }

        /// <summary>
        /// 借方金额
        /// </summary>
        [Display(Name = "借方金额")]
        public decimal Amount { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [Display(Name = "备注")]
        public string Remark { get; set; }
        #endregion //Property
    }

    /// <summary>
    /// 对账贷方类
    /// </summary>
    /// <remarks>
    /// 对账中表示账户相关回收信息
    /// </remarks>
    public class ReconcileCredit : BaseEntity
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
        /// 贷方金额
        /// </summary>
        [Display(Name = "贷方金额")]
        public decimal Amount { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [Display(Name = "备注")]
        public string Remark { get; set; }
        #endregion //Property
    }
}
