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
    /// 抄表计量数据访问类
    /// </summary>
    internal class MeasureRepository : AbstractDALMongo<Measure>, IMeasureRepository
    {
        #region Constructor
        /// <summary>
        /// 抄表计量数据访问类
        /// </summary>
        public MeasureRepository()
        {
            base.Init("recovery_measure");
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// BsonDocument转实体对象
        /// </summary>
        /// <param name="doc">Bson文档</param>
        /// <returns></returns>
        protected override Measure DocToEntity(BsonDocument doc)
        {
            Measure entity = new Measure();
            entity.Id = doc["_id"].ToString();
            entity.AccountId = doc["accountId"].ToString();
            entity.MeasureDate = doc["measureDate"].ToLocalTime();

            entity.Records = new List<MeasureRecord>();
            if (doc.Contains("records"))
            {
                BsonArray array = doc["records"].AsBsonArray;
                foreach (BsonDocument item in array)
                {
                    MeasureRecord record = new MeasureRecord();
                    record.MeterName = item["meterName"].ToString();
                    record.MeterNumber = item["meterNumber"].ToString();
                    record.MeterType = item["meterType"].ToInt32();
                    record.ChargeType = item["chargeType"].ToInt32();
                    record.Multiple = item["multiple"].ToDecimal();
                    record.Indication = item["indication"].ToDecimal();
                    record.Remark = item["remark"].ToString();

                    entity.Records.Add(record);
                }
            }

            entity.AttachmentIds = new List<string>();
            if (doc.Contains("attachmentIds"))
            {
                BsonArray array = doc["attachmentIds"].AsBsonArray;
                foreach (string item in array)
                {
                    entity.AttachmentIds.Add(item);
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
        protected override BsonDocument EntityToDoc(Measure entity)
        {
            BsonDocument doc = new BsonDocument
            {
                { "accountId", entity.AccountId },
                { "measureDate", entity.MeasureDate },
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
                        { "meterName", item.MeterName },
                        { "meterNumber", item.MeterNumber },
                        { "meterType", item.MeterType },
                        { "chargeType", item.ChargeType },
                        { "multiple", item.Multiple },
                        { "indication", item.Indication },
                        { "remark", item.Remark }
                    };

                    array.Add(record);
                }

                doc.Add("records", array);
            }

            if (entity.AttachmentIds != null && entity.AttachmentIds.Count > 0)
            {
                BsonArray array = new BsonArray();
                foreach (var item in entity.AttachmentIds)
                {
                    array.Add(item);
                }

                doc.Add("attachmentIds", array);
            }

            return doc;
        }
        #endregion //Function
    }
}
