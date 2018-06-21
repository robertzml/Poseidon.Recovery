using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Recovery.Core.DL
{
    using Poseidon.Base.Framework;
    using Poseidon.Archives.Core.Utility;

    /// <summary>
    /// 抄表计量类
    /// </summary>
    public class Measure : BusinessEntity, IAttachmentEntity
    {
        #region Property
        /// <summary>
        /// 账户ID
        /// </summary>
        [Display(Name = "账户ID")]
        public string AccountId { get; set; }

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

        /// <summary>
        /// 附件ID
        /// </summary>
        [Display(Name = "附件ID")]
        public List<string> AttachmentIds { get; set; }
        #endregion //Property
    }

    /// <summary>
    /// 抄表记录类
    /// </summary>
    public class MeasureRecord : BaseEntity
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
