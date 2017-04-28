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
        /// <summary>
        /// 模型类型
        /// </summary>
        private readonly string modelType = Utility.ModelTypeCode.Account;
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
            entity.ModelType = doc["modelType"].ToString();
            entity.OpenYear = doc["openYear"].ToInt32();
            entity.Remark = doc["remark"].ToString();
            entity.Status = doc["status"].ToInt32();

            if (doc.Contains("parentId"))
                entity.ParentId = doc["parentId"].ToString();

            if (doc.Contains("chargeBuildingId"))
                entity.ChargeBuildingId = doc["chargeBuildingId"].ToString();

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
            BsonDocument doc = new BsonDocument
            {
                { "name", entity.Name },
                { "shortName", entity.ShortName },
                { "modelType", entity.ModelType },
                { "openYear", entity.OpenYear },
                { "remark", entity.Remark },
                { "status", entity.Status }
            };

            if (!string.IsNullOrEmpty(entity.ParentId))
                doc.Add("parentId", entity.ParentId);

            if (!string.IsNullOrEmpty(entity.ChargeBuildingId))
                doc.Add("chargeBuildingId", entity.ChargeBuildingId);

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
        public override IEnumerable<Account> FindAll()
        {
            return base.FindListByField("modelType", this.modelType);
        }

        /// <summary>
        /// 设置表具
        /// </summary>
        /// <param name="id">账户ID</param>
        /// <param name="meters">表具列表</param>
        public void SetMeters(string id, List<Meter> meters)
        {
            foreach(var item in meters)
            {
                if (string.IsNullOrEmpty(item.Id))
                    item.Id = ObjectId.GenerateNewId().ToString();
            }

            var entity = base.FindById(id);
            entity.Meters = meters;
            base.Update(entity);
        }

        /// <summary>
        /// 添加回收账户
        /// </summary>
        /// <param name="entity">实体对象</param>
        /// <returns></returns>
        public override Account Create(Account entity)
        {
            entity.ModelType = this.modelType;
            entity.Status = 0;
            return base.Create(entity);
        }
        #endregion //Method
    }
}
