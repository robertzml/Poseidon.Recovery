using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poseidon.Recovery.Core.DAL.Mongo
{
    using MongoDB.Bson;
    using Poseidon.Base.Framework;
    using Poseidon.Data;
    using Poseidon.Recovery.Core.DL;
    using Poseidon.Recovery.Core.IDAL;

    /// <summary>
    /// 计费建筑数据访问类
    /// </summary>
    internal class ChargeBuildingRepository : AbstractDALMongo<ChargeBuilding>, IChargeBuildingRepository
    {
        #region Field
        /// <summary>
        /// 模型类型
        /// </summary>
        private readonly string modelType = Utility.ModelTypeCode.ChargeBuilding;
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 回收账户数据访问类
        /// </summary>
        public ChargeBuildingRepository()
        {
            base.Init("core_building");
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// BsonDocument转实体对象
        /// </summary>
        /// <param name="doc">Bson文档</param>
        /// <returns></returns>
        protected override ChargeBuilding DocToEntity(BsonDocument doc)
        {
            ChargeBuilding entity = new ChargeBuilding();
            entity.Id = doc["_id"].ToString();
            entity.Name = doc["name"].ToString();
            entity.ModelType = doc["modelType"].ToString();
            entity.Remark = doc["remark"].ToString();
            entity.Status = doc["status"].ToInt32();

            if (doc.Contains("parentId"))
                entity.ParentId = doc["parentId"].ToString();

            return entity;
        }

        /// <summary>
        /// 实体对象转BsonDocument
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        protected override BsonDocument EntityToDoc(ChargeBuilding entity)
        {
            BsonDocument doc = new BsonDocument
            {
                { "name", entity.Name },
                { "modelType", entity.ModelType },
                { "remark", entity.Remark },
                { "status", entity.Status }
            };

            if (entity.ParentId != null)
                doc.Add("parentId", entity.ParentId);

            return doc;
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 添加计费建筑
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        public override ChargeBuilding Create(ChargeBuilding entity)
        {
            entity.ModelType = this.modelType;
            entity.Status = 0;
            return base.Create(entity);
        }
        #endregion //Method
    }
}
