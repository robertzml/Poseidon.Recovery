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
    using Poseidon.Attachment.Core.Utility;

    /// <summary>
    /// 费用回收类
    /// </summary>
    public class Recycle : BusinessEntity, IAttachmentEntity
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
        /// 是否入账
        /// </summary>
        [Display(Name = "是否入账")]
        public bool IsPost { get; set; }

        /// <summary>
        /// 回收记录
        /// </summary>
        [Display(Name = "回收记录")]
        public List<RecycleRecord> Records { get; set; }

        /// <summary>
        /// 附件ID
        /// </summary>
        [Display(Name = "附件ID")]
        public List<string> AttachmentIds { get; set; }
        #endregion //Property
    }

    /// <summary>
    /// 回收记录类
    /// </summary>
    public class RecycleRecord : BaseEntity
    {
        #region Property
        /// <summary>
        /// 名称
        /// </summary>
        [Display(Name = "名称")]
        public string Name { get; set; }

        /// <summary>
        /// 费用类型
        /// </summary>
        [Dict("Recovery.FeeType")]
        [Display(Name = "费用类型")]
        public int FeeType { get; set; }

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
