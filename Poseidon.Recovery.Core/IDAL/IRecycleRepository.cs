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
    /// 费用回收数据访问接口
    /// </summary>
    internal interface IRecycleRepository : IBaseDAL<Recycle>
    {
        /// <summary>
        /// 获取账户费用回收
        /// </summary>
        /// <param name="accountId">回收账户ID</param>
        /// <param name="isPost">是否入账</param>
        /// <returns></returns>
        IEnumerable<Recycle> FindByAccount(string accountId, bool isPost);

        /// <summary>
        /// 获取账户费用回收
        /// </summary>
        /// <param name="accountId">回收账户ID</param>
        /// <param name="year">年度</param>
        /// <returns></returns>
        IEnumerable<Recycle> FindByAccount(string accountId, int year);
    }
}
