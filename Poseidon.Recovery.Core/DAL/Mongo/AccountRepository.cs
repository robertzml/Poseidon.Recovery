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
    /// 回收账户数据访问类
    /// </summary>
    internal class AccountRepository : AbstractDALMongo<Account>, IAccountRepository
    {
        #region Field
        #endregion //Field

        #region Constructor
        /// <summary>
        /// 回收账户数据访问类
        /// </summary>
        public AccountRepository()
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
        protected override Account DocToEntity(BsonDocument doc)
        {
            Account entity = new Account();
            entity.Id = doc["_id"].ToString();
            entity.Name = doc["name"].ToString();
            entity.ShortName = doc["shortName"].ToString();
            entity.TicketName = doc["ticketName"].ToString();
            entity.ModelType = doc["modelType"].ToString();
            entity.OpenYear = doc["openYear"].ToInt32();
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
        protected override BsonDocument EntityToDoc(Account entity)
        {
            throw new NotImplementedException();
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 设置表具
        /// </summary>
        /// <param name="id">账户ID</param>
        /// <param name="meters">表具列表</param>
        public void SetMeters(string id, List<Meter> meters)
        {
            BsonArray array = new BsonArray();
            foreach (var item in meters)
            {
                if (string.IsNullOrEmpty(item.Id))
                    item.Id = ObjectId.GenerateNewId().ToString();

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

            var filter = Builders<BsonDocument>.Filter.Eq("_id", new ObjectId(id));
            var update = Builders<BsonDocument>.Update.Set("meters", array);

            base.Update(filter, update);
        }
        #endregion //Method
    }
}
