using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Recovery.Core.DL
{
    /// <summary>
    /// 工程类回收账户
    /// </summary>
    public class ConstructionAccount : Account
    {
        #region Property
        /// <summary>
        /// 施工单位
        /// </summary>
        [Display(Name = "施工单位")]
        public string ConstructionCompany { get; set; }

        /// <summary>
        /// 工程名称
        /// </summary>
        [Display(Name = "工程名称")]
        public string ConstructionName { get; set; }

        /// <summary>
        /// 计费方式 1:抄表  2:比例
        /// </summary>
        [Display(Name = "计费方式")]
        public int ChargeType { get; set; }
        #endregion //Property
    }
}
