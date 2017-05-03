using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Recovery.Core.DAL.Mongo
{
    using MongoDB.Bson;
    using MongoDB.Driver;
    using Poseidon.Base.Framework;
    using Poseidon.Data;
    using Poseidon.Recovery.Core.DL;
    using Poseidon.Recovery.Core.IDAL;

    /// <summary>
    /// 工程类回收账户数据访问类
    /// </summary>
    internal class ConstructionAccountRepository : AbstractDALMongo<ConstructionAccount>, IConstructionAccountRepository
    {
        #region Field
        /// <summary>
        /// 模型类型
        /// </summary>
        private readonly string modelType = Utility.ModelTypeCode.ConstructionAccount;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 工程类回收账户数据访问类
        /// </summary>
        public ConstructionAccountRepository()
        {
            base.Init("core_organization");
        }
        #endregion //Constructor

        #region Function
        protected override ConstructionAccount DocToEntity(BsonDocument doc)
        {
            throw new NotImplementedException();
        }

        protected override BsonDocument EntityToDoc(ConstructionAccount entity)
        {
            throw new NotImplementedException();
        }
        #endregion //Function
    }
}
