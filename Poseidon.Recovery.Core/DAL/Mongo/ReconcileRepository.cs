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
    /// 财务对账数据访问类
    /// </summary>
    internal class ReconcileRepository : AbstractDALMongo<Reconcile>, IReconcileRepository
    {
        #region Constructor
        /// <summary>
        /// 财务对账数据访问类
        /// </summary>
        public ReconcileRepository()
        {
            base.Init("recovery_reconcile");
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// BsonDocument转实体对象
        /// </summary>
        /// <param name="doc">Bson文档</param>
        /// <returns></returns>
        protected override Reconcile DocToEntity(BsonDocument doc)
        {
            Reconcile entity = new Reconcile();
            entity.Id = doc["_id"].ToString();
            entity.AccountId = doc["accountId"].ToString();
            entity.ReconcileDate = doc["reconcileDate"].ToLocalTime();
            entity.CertificateId = doc["certificateId"].ToString();
            entity.CertificateNumber = doc["certificateNumber"].ToString();
            entity.Summary = doc["summary"].ToString();
            entity.Amount = doc["amount"].ToDecimal();

            entity.Debits = new List<ReconcileDebit>();
            if (doc.Contains("debits"))
            {
                BsonArray array = doc["debits"].AsBsonArray;
                foreach (BsonDocument item in array)
                {
                    ReconcileDebit record = new ReconcileDebit();
                    record.AccountId = item["accountId"].ToString();
                    record.SettleId = item["settleId"].ToString();
                    record.Amount = item["amount"].ToDecimal();
                    record.Remark = item["remark"].ToString();

                    entity.Debits.Add(record);
                }
            }

            entity.Credits = new List<ReconcileCredit>();
            if (doc.Contains("credits"))
            {
                BsonArray array = doc["credits"].AsBsonArray;
                foreach (BsonDocument item in array)
                {
                    ReconcileCredit record = new ReconcileCredit();
                    record.AccountId = item["accountId"].ToString();
                    record.RecycleId = item["recycleId"].ToString();
                    record.Amount = item["amount"].ToDecimal();
                    record.Remark = item["remark"].ToString();

                    entity.Credits.Add(record);
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
        protected override BsonDocument EntityToDoc(Reconcile entity)
        {
            BsonDocument doc = new BsonDocument
            {
                { "accountId", entity.AccountId },
                { "reconcileDate", entity.ReconcileDate },
                { "certificateId", entity.CertificateId },
                { "certificateNumber", entity.CertificateNumber },
                { "summary", entity.Summary },
                { "amount", entity.Amount },
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

            if (entity.Debits != null && entity.Debits.Count > 0)
            {
                BsonArray array = new BsonArray();
                foreach (var item in entity.Debits)
                {
                    BsonDocument record = new BsonDocument
                    {
                        { "accountId", item.AccountId },
                        { "settleId", item.SettleId },
                        { "amount", item.Amount },
                        { "remark", item.Remark }
                    };

                    array.Add(record);
                }

                doc.Add("debits", array);
            }

            if (entity.Credits != null && entity.Credits.Count > 0)
            {
                BsonArray array = new BsonArray();
                foreach (var item in entity.Credits)
                {
                    BsonDocument record = new BsonDocument
                    {
                        { "accountId", item.AccountId },
                        { "recycleId", item.RecycleId },
                        { "amount", item.Amount },
                        { "remark", item.Remark }
                    };

                    array.Add(record);
                }

                doc.Add("credits", array);
            }

            return doc;
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 按结算查找
        /// </summary>
        /// <param name="settleId">结算ID</param>
        /// <returns></returns>
        public IEnumerable<Reconcile> FindBySettle(string settleId)
        {
            var filter = Builders<BsonDocument>.Filter.Eq("debits.settleId", settleId);
            return base.FindList(filter);
        }
        #endregion //Method
    }
}
