using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Recovery.Core.IDAL
{
    using Poseidon.Base.Framework;
    using Poseidon.Recovery.Core.DL;

    /// <summary>
    /// 费用结算数据访问接口
    /// </summary>
    internal interface ISettleRepository : IBaseDAL<Settle>
    {
        /// <summary>
        /// 获取账户费用结算
        /// </summary>
        /// <param name="accountId">回收账户ID</param>
        /// <param name="isFree">是否免费</param>
        /// <param name="isWriteOff">是否核销</param>
        /// <returns></returns>
        IEnumerable<Settle> FindByAccount(string accountId, bool isFree, bool isWriteOff);

        /// <summary>
        /// 获取账户费用结算
        /// </summary>
        /// <param name="accountId">回收账户ID</param>
        /// <param name="year">年度</param>
        /// <returns></returns>
        IEnumerable<Settle> FindByAccount(string accountId, int year);
    }
}
