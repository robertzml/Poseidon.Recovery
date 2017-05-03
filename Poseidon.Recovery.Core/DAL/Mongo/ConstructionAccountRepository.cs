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
        /// <summary>
        /// BsonDocument转实体对象
        /// </summary>
        /// <param name="doc">Bson文档</param>
        /// <returns></returns>
        protected override ConstructionAccount DocToEntity(BsonDocument doc)
        {
            ConstructionAccount entity = new ConstructionAccount();
            entity.Id = doc["_id"].ToString();
            entity.Name = doc["name"].ToString();
            entity.ShortName = doc["shortName"].ToString();
            entity.TicketName = doc["ticketName"].ToString();
            entity.ModelType = doc["modelType"].ToString();
            entity.ConstructionCompany = doc["constructionCompany"].ToString();
            entity.ConstructionName = doc["constructionName"].ToString();
            entity.ChargeType = doc["chargeType"].ToInt32();
            entity.OpenYear = doc["openYear"].ToInt32();
            entity.Contact = doc["contact"].ToString();
            entity.Remark = doc["remark"].ToString();
            entity.Status = doc["status"].ToInt32();

            if (doc.Contains("parentId"))
                entity.ParentId = doc["parentId"].ToString();

            if (doc.Contains("closeYear"))
                entity.CloseYear = doc["closeYear"].ToInt32();

            entity.EnergyType = new List<int>();
            if (doc.Contains("energyType"))
            {
                BsonArray array = doc["energyType"].AsBsonArray;
                foreach (var item in array)
                {
                    entity.EnergyType.Add(item.ToInt32());
                }
            }

            entity.Meters = new List<Meter>();
            if (doc.Contains("meters"))
            {
                BsonArray array = doc["meters"].AsBsonArray;
                foreach (BsonDocument item in array)
                {
                    Meter meter = new Meter();
                    meter.Id = item["id"].ToString();
                    meter.Name = item["name"].ToString();
                    meter.Number = item["number"].ToString();
                    meter.EnergyType = item["energyType"].ToInt32();
                    meter.ChargeType = item["chargeType"].ToInt32();
                    meter.Address = item["address"].ToString();
                    meter.Multiple = item["multiple"].ToDecimal();
                    meter.Remark = item["remark"].ToString();
                    meter.Status = item["status"].ToInt32();

                    entity.Meters.Add(meter);
                }
            }

            return entity;
        }

        /// <summary>
        /// 实体对象转BsonDocument
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        protected override BsonDocument EntityToDoc(ConstructionAccount entity)
        {
            BsonDocument doc = new BsonDocument
            {
                { "name", entity.Name },
                { "shortName", entity.ShortName },
                { "ticketName", entity.TicketName },
                { "modelType", entity.ModelType },
                { "constructionCompany", entity.ConstructionCompany },
                { "constructionName", entity.ConstructionName },
                { "chargeType", entity.ChargeType },
                { "openYear", entity.OpenYear },
                { "contact", entity.Contact },
                { "remark", entity.Remark },
                { "status", entity.Status }
            };

            if (!string.IsNullOrEmpty(entity.ParentId))
                doc.Add("parentId", entity.ParentId);

            if (entity.CloseYear != null)
                doc.Add("closeYear", entity.CloseYear.Value);

            if (entity.EnergyType != null && entity.EnergyType.Count > 0)
            {
                BsonArray array = new BsonArray();
                foreach (var item in entity.EnergyType)
                {
                    array.Add(item);
                }

                doc.Add("energyType", array);
            }

            if (entity.Meters != null && entity.Meters.Count > 0)
            {
                BsonArray array = new BsonArray();
                foreach (var item in entity.Meters)
                {
                    BsonDocument sub = new BsonDocument
                    {
                        { "id", item.Id },
                        { "name", item.Name },
                        { "number", item.Number },
                        { "energyType", item.EnergyType },
                        { "chargeType", item.ChargeType },
                        { "address", item.Address },
                        { "multiple", item.Multiple },
                        { "remark", item.Remark },
                        { "status", item.Status }
                    };
                    array.Add(sub);
                }

                doc.Add("meters", array);
            }

            return doc;
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 查找所有对象
        /// </summary>
        /// <returns></returns>
        public override IEnumerable<ConstructionAccount> FindAll()
        {
            return base.FindListByField("modelType", this.modelType);
        }

        /// <summary>
        /// 添加回收账户
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        public override ConstructionAccount Create(ConstructionAccount entity)
        {
            entity.ModelType = this.modelType;
            entity.Status = 0;
            return base.Create(entity);
        }
        #endregion //Method
    }
}
