using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Recovery.Core.Utility
{
    /// <summary>
    /// 常量类
    /// </summary>
    public static class RecoveryConstant
    {
        #region Field
        /// <summary>
        /// 模块名称
        /// </summary>
        public static readonly string ModuleName = "Recovery";

        /// <summary>
        /// 全校回收账户分组代码
        /// </summary>
        public static readonly string RecoveryAccountGroupCode = "RecoveryAccount";

        /// <summary>
        /// 经营类回收账户分组代码
        /// </summary>
        public static readonly string CommerceRecoveryAccountGroupCode = "CommerceRecoveryAccount";

        /// <summary>
        /// 工程类回收账户分组代码
        /// </summary>
        public static readonly string ConstructionRecoveryAccountGroupCode = "ConstructionRecoveryAccount";

        /// <summary>
        /// 计费建筑分组代码
        /// </summary>
        public static readonly string ChargeBuilidingGroupCode = "ChargeBuilding";
        #endregion //Field
    }
}
