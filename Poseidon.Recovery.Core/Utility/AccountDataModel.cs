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
    /// 账户相关回收数据
    /// </summary>
    public class AccountDataModel : BaseEntity
    {
        #region Property
        /// <summary>
        /// 账户名称
        /// </summary>
        [Display(Name = "账户名称")]
        public string AccountName { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        [Display(Name = "金额")]
        public decimal Amount { get; set; }
        #endregion //Property
    }
}
