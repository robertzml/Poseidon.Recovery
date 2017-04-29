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
    /// 费用回收数据访问类
    /// </summary>
    internal class RecycleRepository : AbstractDALMongo<Recycle>, IRecycleRepository
    {
        #region Constructor
        /// <summary>
        /// 费用回收数据访问类
        /// </summary>
        public RecycleRepository()
        {
            base.Init("recovery_recycle");
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// BsonDocument转实体对象
        /// </summary>
        /// <param name="doc">Bson文档</param>
        /// <returns></returns>
        protected override Recycle DocToEntity(BsonDocument doc)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 实体对象转BsonDocument
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        protected override BsonDocument EntityToDoc(Recycle entity)
        {
            throw new NotImplementedException();
        }
        #endregion //Function
    }
}
