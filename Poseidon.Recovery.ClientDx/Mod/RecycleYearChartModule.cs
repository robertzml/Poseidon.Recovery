using System;
using System.Collections.Generic;
using System.ComponentModel;
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

    /// <summary>
    /// 年度回收趋势组件
    /// </summary>
    public partial class RecycleYearChartModule : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 当前关联账户
        /// </summary>
        private Account currentAccount;

        /// <summary>
        /// 当前关联分组
        /// </summary>
        private Group currentGroup;
        #endregion //Field

        #region Constructor
        public RecycleYearChartModule()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 载入账户数据
        /// </summary>
        /// <param name="account"></param>
        private async void LoadAccountData(Account account)
        {
            var task = Task.Run(() =>
            {
                var recycles = BusinessFactory<RecycleBusiness>.Instance.FindByAccount(account.Id);

                var model = recycles.GroupBy(r => r.RecycleDate.Year).Select(g => new RecoveryDataModel
                {
                    BelongDate = g.Key.ToString() + "年",
                    DueFee = g.Where(r => r.IsPost == true).Sum(r => r.TotalAmount),
                    PaidFee = g.Where(r => r.IsPost == false).Sum(s => s.TotalAmount)
                });

                return model.OrderBy(r => r.BelongDate).ToList();
            });

            var result = await task;
            this.recycleChart.SetChartTitle($"{account.Name}历年回收金额");
            this.recycleChart.SetSeriesName(0, "已入账费用(元)");
            this.recycleChart.SetSeriesName(1, "未入账费用(元)");
            this.recycleChart.DataSource = result;
        }

        /// <summary>
        /// 载入分组数据
        /// </summary>
        /// <param name="group"></param>
        private async void LoadGroupData(Group group)
        {
            var task = Task.Run(() =>
            {
                var items = BusinessFactory<GroupBusiness>.Instance.FindAllItems(group.Id);

                List<RecoveryDataModel> data = new List<RecoveryDataModel>();
                foreach (var item in items)
                {
                    var recycles = BusinessFactory<RecycleBusiness>.Instance.FindByAccount(item.EntityId);

                    var model = recycles.GroupBy(r => r.RecycleDate.Year).Select(g => new RecoveryDataModel
                    {
                        BelongDate = g.Key.ToString() + "年",
                        DueFee = g.Where(r => r.IsPost == true).Sum(r => r.TotalAmount),
                        PaidFee = g.Where(r => r.IsPost == false).Sum(s => s.TotalAmount)
                    });

                    data.AddRange(model);
                }

                var data2 = data.GroupBy(r => r.BelongDate).Select(g => new RecoveryDataModel
                {
                    BelongDate = g.Key.ToString(),
                    DueFee = g.Sum(r => r.DueFee),
                    PaidFee = g.Sum(r => r.PaidFee)
                });

                return data2.OrderBy(r => r.BelongDate).ToList();
            });

            var result = await task;
            this.recycleChart.SetChartTitle($"{group.Name}历年回收金额");
            this.recycleChart.SetSeriesName(0, "已入账费用(元)");
            this.recycleChart.SetSeriesName(1, "未入账费用(元)");
            this.recycleChart.DataSource = result;
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 设置账户
        /// </summary>
        /// <param name="account">回收账户</param>
        public void SetAccount(Account account)
        {
            this.currentAccount = account;
            LoadAccountData(account);
        }

        /// <summary>
        /// 设置分组
        /// </summary>
        /// <param name="group">分组</param>
        public void SetGroup(Group group)
        {
            this.currentGroup = group;
            LoadGroupData(group);
        }

        /// <summary>
        /// 清空显示
        /// </summary>
        public void Clear()
        {
            this.recycleChart.DataSource = null;
        }
        #endregion //Method
    }
}
