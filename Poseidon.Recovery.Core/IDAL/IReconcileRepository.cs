﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Recovery.Core.IDAL
{
    using Poseidon.Base.Framework;
    using Poseidon.Recovery.Core.DL;

    /// <summary>
    /// 财务对账数据访问接口
    /// </summary>
    internal interface IReconcileRepository : IBaseDAL<Reconcile>
    {
        /// <summary>
        /// 按结算查找
        /// </summary>
        /// <param name="settleId">结算ID</param>
        /// <returns></returns>
        IEnumerable<Reconcile> FindBySettle(string settleId);
    }
}
