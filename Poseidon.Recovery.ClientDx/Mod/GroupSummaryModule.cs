using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Recovery.ClientDx
{
    using Poseidon.Base.Framework;
    using Poseidon.Common;
    using Poseidon.Core.BL;
    using Poseidon.Core.DL;
    using Poseidon.Recovery.Core.BL;
    using Poseidon.Recovery.Core.DL;
    using Poseidon.Recovery.Core.Utility;
    using Poseidon.Winform.Base;

    /// <summary>
    /// 分组汇总模块
    /// </summary>
    public partial class GroupSummaryModule : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 当前关联账户
        /// </summary>
        private Group currentGroup;
        #endregion //Field

        #region Constructor
        public GroupSummaryModule()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 载入结算数据
        /// </summary>
        /// <param name="group"></param>
        private async void LoadSettleData(Group group)
        {
            var task1 = Task.Run(() =>
            {
                var items = BusinessFactory<GroupBusiness>.Instance.FindAllItems(group.Id);

                List<Settle> data = new List<Settle>();
                foreach (var item in items)
                {
                    var settle = BusinessFactory<SettleBusiness>.Instance.FindByAccount(item.EntityId);
                    data.AddRange(settle);
                }

                return data;
            });

            var settles = await task1;

            // 总金额
            var totalFee = settles.Sum(r => r.TotalAmount);

            // 应收款
            var dueFee = settles.Where(r => r.IsFree == false).Sum(r => r.TotalAmount);

            // 已收款
            var paidFee = settles.Where(r => r.IsFree == false && r.IsWriteOff == true).Sum(r => r.TotalAmount);

            ///欠款
            var debtFee = dueFee - paidFee;

            this.txtSettleAmount.Text = totalFee.ToString();
            this.txtSettleDue.Text = dueFee.ToString();
            this.txtSettleWriteOff.Text = paidFee.ToString();
            this.txtSettleNotWriteOff.Text = debtFee.ToString();
            this.txtSettleFree.Text = settles.Where(r => r.IsFree == true).Sum(r => r.TotalAmount).ToString();

            //核销率
            decimal rate = 1;
            if (dueFee != 0)
                rate = Math.Round(paidFee / dueFee * 100, 2);

            // Gauge
            this.digitalGauge1.Text = Convert.ToInt32(debtFee).ToString();
            this.arcScaleComponent1.Value = Convert.ToSingle(rate);
        }

        /// <summary>
        /// 载入回收数据
        /// </summary>
        /// <param name="group"></param>
        private async void LoadRecycleData(Group group)
        {
            var task1 = Task.Run(() =>
            {
                var items = BusinessFactory<GroupBusiness>.Instance.FindAllItems(group.Id);

                List<Recycle> recycleData = new List<Recycle>();
                List<RecycleRecord> records = new List<RecycleRecord>();

                foreach (var item in items)
                {
                    var recycle = BusinessFactory<RecycleBusiness>.Instance.FindByAccount(item.EntityId);
                    recycleData.AddRange(recycle);

                    foreach (var rc in recycle)
                    {
                        records.AddRange(rc.Records);
                    }
                }

                var groups = records.GroupBy(r => r.FeeType).Select(g => new RecycleRecord
                {
                    FeeType = g.Key,
                    Amount = Math.Round(g.Sum(s => s.Amount) / 10000, 2)
                });

                return new { Recycle = recycleData, Group = groups };
            });

            var recycles = await task1;

            var totalFee = recycles.Recycle.Sum(r => r.TotalAmount);
            var postFee = recycles.Recycle.Where(r => r.IsPost == true).Sum(r => r.TotalAmount);
            var notPostFee = recycles.Recycle.Where(r => r.IsPost == false).Sum(r => r.TotalAmount);

            this.txtRecycleAmount.Text = totalFee.ToString();
            this.txtRecyclePost.Text = postFee.ToString();
            this.txtRecycleNotPost.Text = notPostFee.ToString();

            decimal rate = 1;
            if (totalFee != 0)
                rate = Math.Round(postFee / totalFee * 100, 2);

            //gauge
            this.arcScaleComponent2.Value = Convert.ToSingle(rate);

            this.feeTypeChart.SetChartTitle($"{group.Name}回收费用类型");
            this.feeTypeChart.SetSeriesLabel("万元");
            this.feeTypeChart.SetSeries(recycles.Group.ToList());
        }

        /// <summary>
        /// 载入账户数据
        /// </summary>
        /// <param name="group"></param>
        private async void LoadAccountData(Group group)
        {
            var task = Task.Run(() =>
            {
                List<AccountDataModel> data = new List<AccountDataModel>();
                var items = BusinessFactory<GroupBusiness>.Instance.FindAllItems(group.Id);

                foreach (var item in items)
                {
                    var account = BusinessFactory<AccountBusiness>.Instance.FindById(item.EntityId);
                    var recycles = BusinessFactory<RecycleBusiness>.Instance.FindByAccount(item.EntityId);

                    AccountDataModel model = new AccountDataModel
                    {
                        AccountName = account.Name,
                        Amount = Math.Round(recycles.Where(r => r.IsPost == true).Sum(r => r.TotalAmount) / 10000, 2)
                    };

                    data.Add(model);
                }

                return data;
            });

            var result = await task;

            this.accountPieChart.SetChartTitle($"{group.Name}回收情况");
            this.accountPieChart.SetSeriesLabel("万元");
            this.accountPieChart.DataSource = result;
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 设置账户
        /// </summary>
        /// <param name="account">支出账户</param>
        public void SetGroup(Group group)
        {
            this.currentGroup = group;

            LoadSettleData(group);
            LoadRecycleData(group);
            LoadAccountData(group);
        }
        #endregion //Method
    }
}
