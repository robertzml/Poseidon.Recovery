using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Recovery.Core.BL
{
    using Poseidon.Base.Framework;
    using Poseidon.Recovery.Core.DL;
    using Poseidon.Recovery.Core.IDAL;

    /// <summary>
    /// 回收账户业务类
    /// </summary>
    public class AccountBusiness : AbstractBusiness<Account>
    {
        #region Constructor
        /// <summary>
        /// 回收账户业务类
        /// </summary>
        public AccountBusiness()
        {
            this.baseDal = RepositoryFactory<IAccountRepository>.Instance;
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 按模型类型获取账户
        /// </summary>
        /// <param name="modelType">模型类型</param>
        /// <returns></returns>
        public IEnumerable<Account> FindAll(string modelType)
        {
            return this.baseDal.FindListByField("modelType", modelType);
        }

        /// <summary>
        /// 设置表具
        /// </summary>
        /// <param name="id">账户ID</param>
        /// <param name="meters">表具列表</param>
        public void SetMeters(string id, List<Meter> meters)
        {
            var dal = this.baseDal as IAccountRepository;
            dal.SetMeters(id, meters);
        }

        /// <summary>
        /// 设置账户附件
        /// </summary>
        /// <param name="id">账户ID</param>
        /// <param name="attachmentIds">附件列表</param>
        public void SetAttachments(string id, List<string> attachmentIds)
        {
            var dal = this.baseDal as IAccountRepository;
            dal.SetAttachments(id, attachmentIds);
        }
        #endregion //Method
    }
}
