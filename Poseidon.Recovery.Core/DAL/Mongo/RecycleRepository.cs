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
            Recycle entity = new Recycle();
            entity.Id = doc["_id"].ToString();
            entity.AccountId = doc["accountId"].ToString();
            entity.RecycleDate = doc["recycleDate"].ToLocalTime();
            entity.TotalAmount = doc["totalAmount"].ToDecimal();

            entity.Records = new List<RecycleRecord>();
            if (doc.Contains("records"))
            {
                BsonArray array = doc["records"].AsBsonArray;
                foreach (BsonDocument item in array)
                {
                    RecycleRecord record = new RecycleRecord();
                    record.Name = item["name"].ToString();
                    record.FeeType = item["feeType"].ToInt32();
                    record.Amount = item["amount"].ToDecimal();
                    record.Remark = item["remark"].ToString();

                    entity.Records.Add(record);
                }
            }

            var createBy = doc["createBy"].ToBsonDocument();
            entity.CreateBy = new UpdateStamp
            {
                UserId = createBy["userId"].ToString(),
                Name = createBy["name"].ToString(),
                Time = createBy["time"].ToLocalTime()
            };

            var updateBy = doc["updateBy"].ToBsonDocument();
            entity.UpdateBy = new UpdateStamp
            {
                UserId = updateBy["userId"].ToString(),
                Name = updateBy["name"].ToString(),
                Time = updateBy["time"].ToLocalTime()
            };

            entity.Remark = doc["remark"].ToString();
            entity.Status = doc["status"].ToInt32();

            return entity;
        }

        /// <summary>
        /// 实体对象转BsonDocument
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        protected override BsonDocument EntityToDoc(Recycle entity)
        {
            BsonDocument doc = new BsonDocument
            {
                { "accountId", entity.AccountId },
                { "recycleDate", entity.RecycleDate },
                { "totalAmount", entity.TotalAmount },
                { "createBy", new BsonDocument {
                    { "userId", entity.CreateBy.UserId },
                    { "name", entity.CreateBy.Name },
                    { "time", entity.CreateBy.Time }
                }},
                { "updateBy", new BsonDocument {
                    { "userId", entity.UpdateBy.UserId },
                    { "name", entity.UpdateBy.Name },
                    { "time", entity.UpdateBy.Time }
                }},
                { "remark", entity.Remark },
                { "status", entity.Status }
            };

            if (entity.Records != null && entity.Records.Count > 0)
            {
                BsonArray array = new BsonArray();
                foreach (var item in entity.Records)
                {
                    BsonDocument record = new BsonDocument
                    {
                        { "name", item.Name },
                        { "feeType", item.FeeType },
                        { "amount", item.Amount },
                        { "remark", item.Remark }
                    };

                    array.Add(record);
                }

                doc.Add("records", array);
            }

            return doc;
        }
        #endregion //Function
    }
}
