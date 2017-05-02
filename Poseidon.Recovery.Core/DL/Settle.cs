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
    /// 费用结算类
    /// </summary>
    public class Settle : BusinessEntity
    {
        #region Property
        /// <summary>
        /// 账户ID
        /// </summary>
        [Display(Name = "账户ID")]
        public string AccountId { get; set; }

        /// <summary>
        /// 结算周期
        /// </summary>
        [Display(Name = "结算周期")]
        public string Period { get; set; }

        /// <summary>
        /// 结算日期
        /// </summary>
        [Display(Name = "结算日期")]
        public DateTime SettleDate { get; set; }

        /// <summary>
        /// 上期日期
        /// </summary>
        [Display(Name = "上期日期")]
        public DateTime PreviousDate { get; set; }

        /// <summary>
        /// 本期日期
        /// </summary>
        [Display(Name = "本期日期")]
        public DateTime CurrentDate { get; set; }

        /// <summary>
        /// 结算金额
        /// </summary>
        [Display(Name = "结算金额")]
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// 是否免费
        /// </summary>
        [Display(Name = "是否免费")]
        public bool IsFree { get; set; }

        /// <summary>
        /// 是否核销
        /// </summary>
        [Display(Name = "是否核销")]
        public bool IsWriteOff { get; set; }

        /// <summary>
        /// 结算记录
        /// </summary>
        [Display(Name = "结算记录")]
        public List<SettleRecord> Records { get; set; }
        #endregion //Property
    }

    /// <summary>
    /// 结算记录类
    /// </summary>
    public class SettleRecord : BaseEntity
    {
        #region Property
        /// <summary>
        /// 表名
        /// </summary>
        [Display(Name = "表名")]
        public string MeterName { get; set; }

        /// <summary>
        /// 表号
        /// </summary>
        [Display(Name = "表号")]
        public string MeterNumber { get; set; }

        /// <summary>
        /// 类型，电表、水表
        /// </summary>
        [Display(Name = "类型")]
        public int MeterType { get; set; }

        /// <summary>
        /// 倍率
        /// </summary>
        [Display(Name = "倍率")]
        public decimal Multiple { get; set; }

        /// <summary>
        /// 上期数
        /// </summary>
        [Display(Name = "上期数")]
        public decimal Previous { get; set; }

        /// <summary>
        /// 本期数
        /// </summary>
        [Display(Name = "本期数")]
        public decimal Current { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        [Display(Name = "单价")]
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// 用量
        /// </summary>
        [Display(Name = "用量")]
        public decimal Quantum { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [Display(Name = "金额")]
        public decimal Amount { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [Display(Name = "备注")]
        public string Remark { get; set; }
        #endregion //Property
    }
}
