using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Recovery.Core.DL
{
    using Poseidon.Base.Framework;
    using Poseidon.Core.DL;

    /// <summary>
    /// 回收账户类
    /// </summary>
    public class Account : Organization
    {
        #region Property
        /// <summary>
        /// 简称
        /// </summary>
        [Display(Name = "简称")]
        public string ShortName { get; set; }

        /// <summary>
        /// 能源类型
        /// </summary>
        [Display(Name = "能源类型")]
        public List<int> EnergyType { get; set; }

        /// <summary>
        /// 计费建筑
        /// </summary>
        [Display(Name = "计费建筑")]
        public string ChargeBuildingId { get; set; }

        /// <summary>
        /// 启用年份
        /// </summary>
        [Display(Name = "启用年份")]
        public int OpenYear { get; set; }

        /// <summary>
        /// 关闭年份
        /// </summary>
        [Display(Name = "关闭年份")]
        public int? CloseYear { get; set; }

        /// <summary>
        /// 联系方式
        /// </summary>
        [Display(Name = "联系方式")]
        public string Contract { get; set; }

        /// <summary>
        /// 包含表具
        /// </summary>
        [Display(Name = "包含表具")]
        public List<Meter> Meters { get; set; }
        #endregion //Property
    }
}
