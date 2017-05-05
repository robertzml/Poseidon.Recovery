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

    /// <summary>
    /// 应收实收年度图表组件
    /// </summary>
    public partial class RecoveryYearChartModule : DevExpress.XtraEditors.XtraUserControl
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
        public RecoveryYearChartModule()
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
                List<RecoveryDataModel> data = new List<RecoveryDataModel>();

                var data1 = BusinessFactory<SettleBusiness>.Instance.FindByAccount(account.Id);
                foreach (var item in data1)
                {
                    var find = data.FirstOrDefault(r => r.BelongDate == $"{item.SettleDate.Year}年");
                    if (find == null)
                    {
                        RecoveryDataModel model = new RecoveryDataModel
                        {
                            BelongDate = $"{item.SettleDate.Year}年",
                            DueFee = item.TotalAmount
                        };
                        data.Add(model);
                    }
                    else
                    {
                        find.DueFee += item.TotalAmount;
                    }
                }

                var data2 = BusinessFactory<ReconcileBusiness>.Instance.FindByAccount(account.Id);
                foreach (var item in data2)
                {
                    var find = data.FirstOrDefault(r => r.BelongDate == $"{item.ReconcileDate.Year}年");
                    if (find == null)
                    {
                        RecoveryDataModel model = new RecoveryDataModel
                        {
                            BelongDate = $"{item.ReconcileDate.Year}年",
                            PaidFee = item.Amount
                        };
                        data.Add(model);
                    }
                    else
                    {
                        find.PaidFee += item.Amount;
                    }
                }

                return data.OrderBy(r => r.BelongDate).ToList();
            });

            var result = await task;

            this.recoveryChart.SetChartTitle($"{account.Name}历年应收实收费用");
            this.recoveryChart.SetSeriesName(0, "应收金额(元)");
            this.recoveryChart.SetSeriesName(1, "实收金额(元)");
            this.recoveryChart.DataSource = result;
        }

        /// <summary>
        /// 载入分组数据
        /// </summary>
        /// <param name="group"></param>
        private async void LoadGroupData(Group group)
        {
            var task = Task.Run(() =>
            {
                List<RecoveryDataModel> data = new List<RecoveryDataModel>();
                var items = BusinessFactory<GroupBusiness>.Instance.FindAllItems(group.Id);

                foreach (var item in items)
                {
                    var settles = BusinessFactory<SettleBusiness>.Instance.FindByAccount(item.EntityId);
                    foreach (var settle in settles)
                    {
                        var find = data.FirstOrDefault(r => r.BelongDate == $"{settle.SettleDate.Year}年");
                        if (find == null)
                        {
                            RecoveryDataModel model = new RecoveryDataModel
                            {
                                BelongDate = $"{settle.SettleDate.Year}年",
                                DueFee = settle.TotalAmount
                            };
                            data.Add(model);
                        }
                        else
                        {
                            find.DueFee += settle.TotalAmount;
                        }
                    }

                    var recycles = BusinessFactory<ReconcileBusiness>.Instance.FindByAccount(item.EntityId);
                    foreach (var recycle in recycles)
                    {
                        var find = data.FirstOrDefault(r => r.BelongDate == $"{recycle.ReconcileDate.Year}年");
                        if (find == null)
                        {
                            RecoveryDataModel model = new RecoveryDataModel
                            {
                                BelongDate = $"{recycle.ReconcileDate.Year}年",
                                PaidFee = recycle.Amount
                            };
                            data.Add(model);
                        }
                        else
                        {
                            find.PaidFee += recycle.Amount;
                        }
                    }
                }

                data.ForEach((r) =>
                {
                    r.DueFee = Math.Round(r.DueFee / 10000, 2);
                    r.PaidFee = Math.Round(r.PaidFee / 10000, 2);
                });
                return data.OrderBy(r => r.BelongDate).ToList();
            });

            var result = await task;

            this.recoveryChart.SetChartTitle($"{group.Name}历年应收实收费用");
            this.recoveryChart.SetSeriesName(0, "应收金额(万元)");
            this.recoveryChart.SetSeriesName(1, "实收金额(万元)");
            this.recoveryChart.DataSource = result;
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
            this.recoveryChart.DataSource = null;
        }
        #endregion //Method
    }
}
