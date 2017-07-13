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
    /// 回收账户数据访问接口
    /// </summary>
    internal interface IAccountRepository : IBaseDAL<Account>
    {
        /// <summary>
        /// 设置表具
        /// </summary>
        /// <param name="id">账户ID</param>
        /// <param name="meters">表具列表</param>
        void SetMeters(string id, List<Meter> meters);

        /// <summary>
        /// 设置账户附件
        /// </summary>
        /// <param name="id">账户ID</param>
        /// <param name="attachmentIds">附件列表</param>
        void SetAttachments(string id, List<string> attachmentIds);
    }
}
