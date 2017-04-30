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
            entity.Certificate = doc["certificate"].ToString();
            entity.Summary = doc["summary"].ToString();

            entity.RecycleId = doc["recycleId"].ToString();
            entity.SettleIds = new List<string>();
            if (doc.Contains("settleIds"))
            {
                BsonArray array = doc["settleIds"].AsBsonArray;
                foreach (var item in array)
                {
                    entity.SettleIds.Add(item.ToString());
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
                { "certificate", entity.Certificate },
                { "summary", entity.Summary },
                { "recycleId", entity.RecycleId },
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

            if (entity.SettleIds != null && entity.SettleIds.Count > 0)
            {
                BsonArray array = new BsonArray();
                foreach (var item in entity.SettleIds)
                {
                    array.Add(item);
                }

                doc.Add("settleIds", array);
            }

            return doc;
        }
        #endregion //Function
    }
}
