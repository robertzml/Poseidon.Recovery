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
            entity.IsPost = doc["isPost"].ToBoolean();

            if (doc.Contains("postAmount"))
                entity.PostAmount = doc["postAmount"].ToDecimal();

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
        protected override BsonDocument EntityToDoc(Recycle entity)
        {
            BsonDocument doc = new BsonDocument
            {
                { "accountId", entity.AccountId },
                { "recycleDate", entity.RecycleDate },
                { "totalAmount", entity.TotalAmount },
                { "postAmount", entity.PostAmount },
                { "isPost", entity.IsPost },
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

        #region Method
        /// <summary>
        /// 获取账户费用回收
        /// </summary>
        /// <param name="accountId">回收账户ID</param>
        /// <param name="isPost">是否入账</param>
        /// <returns></returns>
        public IEnumerable<Recycle> FindByAccount(string accountId, bool isPost)
        {
            var builder = Builders<BsonDocument>.Filter;
            var filter = builder.Eq("accountId", accountId) & builder.Eq("isPost", isPost);

            return base.FindList(filter);
        }

        /// <summary>
        /// 获取账户费用回收
        /// </summary>
        /// <param name="accountId">回收账户ID</param>
        /// <param name="year">年度</param>
        /// <returns></returns>
        public IEnumerable<Recycle> FindByAccount(string accountId, int year)
        {
            var start = new DateTime(year, 1, 1);
            var end = new DateTime(year, 12, 31);

            var builder = Builders<BsonDocument>.Filter;
            var filter = builder.Eq("accountId", accountId) & builder.Gte("recycleDate", start) & builder.Lte("recycleDate", end);

            return base.FindList(filter);
        }
        #endregion //Method
    }
}
