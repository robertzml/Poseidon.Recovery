﻿using System;
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
    /// 费用结算数据访问类
    /// </summary>
    internal class SettleRepository : AbstractDALMongo<Settle>, ISettleRepository
    {
        #region Constructor
        /// <summary>
        /// 费用结算数据访问类
        /// </summary>
        public SettleRepository()
        {
            base.Init("recovery_settle");
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// BsonDocument转实体对象
        /// </summary>
        /// <param name="doc">Bson文档</param>
        /// <returns></returns>
        protected override Settle DocToEntity(BsonDocument doc)
        {
            Settle entity = new Settle();
            entity.Id = doc["_id"].ToString();
            entity.AccountId = doc["accountId"].ToString();
            entity.Period = doc["period"].ToString();
            entity.SettleDate = doc["settleDate"].ToLocalTime();
            entity.PreviousDate = doc["previousDate"].ToLocalTime();
            entity.CurrentDate = doc["currentDate"].ToLocalTime();
            entity.TotalAmount = doc["totalAmount"].ToDecimal();
            entity.IsDebt = doc["isDebt"].ToBoolean();
            entity.IsWriteOff = doc["isWriteOff"].ToBoolean();

            entity.Records = new List<SettleRecord>();
            if (doc.Contains("records"))
            {
                BsonArray array = doc["records"].AsBsonArray;
                foreach (BsonDocument item in array)
                {
                    SettleRecord record = new SettleRecord();
                    record.MeterName = item["meterName"].ToString();
                    record.MeterNumber = item["meterNumber"].ToString();
                    record.MeterType = item["meterType"].ToInt32();
                    record.Multiple = item["multiple"].ToDecimal();
                    record.Previous = item["previous"].ToDecimal();
                    record.Current = item["current"].ToDecimal();
                    record.UnitPrice = item["unitPrice"].ToDecimal();
                    record.Quantum = item["quantum"].ToDecimal();
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
        protected override BsonDocument EntityToDoc(Settle entity)
        {
            BsonDocument doc = new BsonDocument
            {
                { "accountId", entity.AccountId },
                { "period", entity.Period },
                { "settleDate", entity.SettleDate },
                { "previousDate", entity.PreviousDate },
                { "currentDate", entity.CurrentDate },
                { "totalAmount", entity.TotalAmount },
                { "isDebt", entity.IsDebt },
                { "isWriteOff", entity.IsWriteOff },
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
                        { "multiple", item.Multiple },
                        { "previous", item.Previous },
                        { "current", item.Current },
                        { "unitPrice", item.UnitPrice },
                        { "quantum", item.Quantum },
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
