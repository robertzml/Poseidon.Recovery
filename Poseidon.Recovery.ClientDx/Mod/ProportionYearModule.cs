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
    using Poseidon.Core.DL;
    using Poseidon.Core.BL;
    using Poseidon.Core.Utility;
    using Poseidon.Recovery.Core.BL;
    using Poseidon.Recovery.Core.DL;
    using Poseidon.Recovery.Core.Utility;

    /// <summary>
    /// 年度比例图表组件
    /// </summary>
    public partial class ProportionYearModule : DevExpress.XtraEditors.XtraUserControl
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

        private int startYear = 2014;

        private int nowYear;

        /// <summary>
        /// 显示类型  1:部门  2:分组
        /// </summary>
        private int showType;

        /// <summary>
        /// 数据类型  
        /// 1:费用分类  2:入账比例  3:核销比例  4:水电费比例  5:账户结算  6:账户回收
        /// </summary>
        private int dataType;
        #endregion //Field

        #region Constructor
        public ProportionYearModule()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 初始化控件
        /// </summary>
        private void InitControls()
        {
            this.cmbYear.Properties.Items.Clear();

            for (int i = nowYear; i >= startYear; i--)
            {
                this.cmbYear.Properties.Items.Add(i.ToString() + "年");
            }

            this.cmbYear.SelectedIndex = 0;
        }

        /// <summary>
        /// 按回收费用类型分类
        /// </summary>
        /// <param name="account"></param>
        /// <param name="year"></param>
        private async void LoadAccountFeeType(Account account, int year)
        {
            var task = Task.Run(() =>
            {
                List<AccountDataModel> model = new List<AccountDataModel>();
                List<RecycleRecord> records = new List<RecycleRecord>();

                var data = BusinessFactory<RecycleBusiness>.Instance.FindByAccount(account.Id, year);

                foreach (var recycle in data)
                {
                    records.AddRange(recycle.Records);
                }

                var groups = records.GroupBy(r => r.FeeType).Select(g => new RecycleRecord
                {
                    FeeType = g.Key,
                    Amount = g.Sum(s => s.Amount)
                });

                foreach (var item in groups)
                {
                    AccountDataModel ad = new AccountDataModel();
                    string dict = DictUtility.GetDictValue(item, "FeeType", item.FeeType);
                    ad.AccountName = dict;
                    ad.Amount = item.Amount;

                    model.Add(ad);
                }

                return model;
            });

            var result = await task;
            this.pieChart.SetChartTitle($"{year}年{currentAccount.Name}回收费用类型");
            this.pieChart.SetSeriesLabel("元");
            this.pieChart.DataSource = result;
        }

        /// <summary>
        /// 账户入账比例
        /// </summary>
        /// <param name="account"></param>
        /// <param name="year"></param>
        private async void LoadAccountPost(Account account, int year)
        {
            var task = Task.Run(() =>
            {
                List<AccountDataModel> model = new List<AccountDataModel>();
                var data = BusinessFactory<RecycleBusiness>.Instance.FindByAccount(account.Id, year);

                model.Add(new AccountDataModel
                {
                    AccountName = "已入账费用",
                    Amount = data.Where(r => r.IsPost == true).Sum(r => r.TotalAmount)
                });
                model.Add(new AccountDataModel
                {
                    AccountName = "未入账费用",
                    Amount = data.Where(r => r.IsPost == false).Sum(r => r.TotalAmount)
                });

                return model;
            });

            var result = await task;
            this.pieChart.SetChartTitle($"{year}年{currentAccount.Name}入账费用比例");
            this.pieChart.SetSeriesLabel("元");
            this.pieChart.DataSource = result;
        }

        /// <summary>
        /// 账户核销比例
        /// </summary>
        /// <param name="account"></param>
        /// <param name="year"></param>
        private async void LoadAccountWriteOff(Account account, int year)
        {
            var task = Task.Run(() =>
            {
                List<AccountDataModel> model = new List<AccountDataModel>();
                var data = BusinessFactory<SettleBusiness>.Instance.FindByAccount(account.Id, year);

                model.Add(new AccountDataModel
                {
                    AccountName = "已核销费用",
                    Amount = data.Where(r => r.IsFree == false && r.IsWriteOff == true).Sum(r => r.TotalAmount)
                });
                model.Add(new AccountDataModel
                {
                    AccountName = "未核销费用",
                    Amount = data.Where(r => r.IsFree == false && r.IsWriteOff == false).Sum(r => r.TotalAmount)
                });

                return model;
            });

            var result = await task;
            this.pieChart.SetChartTitle($"{year}年{currentAccount.Name}核销费用比例");
            this.pieChart.SetSeriesLabel("元");
            this.pieChart.DataSource = result;
        }

        /// <summary>
        /// 账户水电费比例
        /// </summary>
        /// <param name="account"></param>
        /// <param name="year"></param>
        private async void LoadAccountEnergy(Account account, int year)
        {
            var task = Task.Run(() =>
            {
                List<AccountDataModel> model = new List<AccountDataModel>();
                List<SettleRecord> records = new List<SettleRecord>();

                var data = BusinessFactory<SettleBusiness>.Instance.FindByAccount(account.Id, year);

                foreach (var settle in data)
                {
                    records.AddRange(settle.Records);
                }

                var groups = records.GroupBy(r => r.MeterType).Select(g => new SettleRecord
                {
                    MeterType = g.Key,
                    Amount = g.Sum(s => s.Amount)
                });

                foreach (var item in groups)
                {
                    AccountDataModel ad = new AccountDataModel();
                    ad.AccountName = item.MeterType == 1 ? "电费" : "水费";
                    ad.Amount = item.Amount;

                    model.Add(ad);
                }

                return model;
            });

            var result = await task;
            this.pieChart.SetChartTitle($"{year}年{currentAccount.Name}水电费比例");
            this.pieChart.SetSeriesLabel("元");
            this.pieChart.DataSource = result;
        }

        /// <summary>
        /// 载入数据
        /// </summary>
        /// <param name="account">账户</param>
        /// <param name="year">年度</param>
        /// <param name="dataType">数据类型</param>
        private void LoadAccountData(Account account, int year, int dataType)
        {
            switch (dataType)
            {
                case 1:
                    LoadAccountFeeType(account, year);
                    break;
                case 2:
                    LoadAccountPost(account, year);
                    break;
                case 3:
                    LoadAccountWriteOff(account, year);
                    break;
                case 4:
                    LoadAccountEnergy(account, year);
                    break;
            }
        }

        /// <summary>
        /// 分组费用分类
        /// </summary>
        /// <param name="group"></param>
        /// <param name="year"></param>
        private async void LoadGroupFeeType(Group group, int year)
        {
            var task = Task.Run(() =>
            {
                List<AccountDataModel> model = new List<AccountDataModel>();

                List<Recycle> recycleData = new List<Recycle>();
                List<RecycleRecord> records = new List<RecycleRecord>();

                var items = BusinessFactory<GroupBusiness>.Instance.FindAllItems(group.Id);

                foreach (var item in items)
                {
                    var recycle = BusinessFactory<RecycleBusiness>.Instance.FindByAccount(item.EntityId, year);
                    recycleData.AddRange(recycle);

                    foreach (var rc in recycle)
                    {
                        records.AddRange(rc.Records);
                    }
                }

                var groups = records.GroupBy(r => r.FeeType).Select(g => new RecycleRecord
                {
                    FeeType = g.Key,
                    Amount = g.Sum(s => s.Amount)
                });

                foreach (var item in groups)
                {
                    AccountDataModel ad = new AccountDataModel();
                    string dict = DictUtility.GetDictValue(item, "FeeType", item.FeeType);
                    ad.AccountName = dict;
                    ad.Amount = Math.Round(item.Amount / 10000, 2);

                    model.Add(ad);
                }

                return model;
            });

            var result = await task;
            this.pieChart.SetChartTitle($"{year}年{currentGroup.Name}回收费用类型");
            this.pieChart.SetSeriesLabel("万元");
            this.pieChart.DataSource = result;
        }

        /// <summary>
        /// 分组入账比例
        /// </summary>
        /// <param name="group"></param>
        /// <param name="year"></param>
        private async void LoadGroupPost(Group group, int year)
        {
            var task = Task.Run(() =>
            {
                List<AccountDataModel> model = new List<AccountDataModel>();
                var items = BusinessFactory<GroupBusiness>.Instance.FindAllItems(group.Id);

                var model1 = new AccountDataModel
                {
                    Id = "1",
                    AccountName = "已入账费用",
                    Amount = 0
                };
                var model2 = new AccountDataModel
                {
                    Id = "2",
                    AccountName = "未入账费用",
                    Amount = 0
                };

                foreach (var item in items)
                {
                    var data = BusinessFactory<RecycleBusiness>.Instance.FindByAccount(item.EntityId, year);

                    model1.Amount += data.Where(r => r.IsPost == true).Sum(r => r.TotalAmount);
                    model2.Amount += data.Where(r => r.IsPost == false).Sum(r => r.TotalAmount);
                }

                model1.Amount = Math.Round(model1.Amount / 10000, 2);
                model2.Amount = Math.Round(model2.Amount / 10000, 2);
                model.Add(model1);
                model.Add(model2);

                return model;
            });

            var result = await task;
            this.pieChart.SetChartTitle($"{year}年{currentGroup.Name}入账费用比例");
            this.pieChart.SetSeriesLabel("万元");
            this.pieChart.DataSource = result;
        }

        /// <summary>
        /// 分组核销比例
        /// </summary>
        /// <param name="group"></param>
        /// <param name="year"></param>
        private async void LoadGroupWriteOff(Group group, int year)
        {
            var task = Task.Run(() =>
            {
                List<AccountDataModel> model = new List<AccountDataModel>();
                var items = BusinessFactory<GroupBusiness>.Instance.FindAllItems(group.Id);

                var model1 = new AccountDataModel
                {
                    Id = "1",
                    AccountName = "已核销费用",
                    Amount = 0
                };
                var model2 = new AccountDataModel
                {
                    Id = "2",
                    AccountName = "未核销费用",
                    Amount = 0
                };

                foreach (var item in items)
                {
                    var data = BusinessFactory<SettleBusiness>.Instance.FindByAccount(item.EntityId, year);

                    model1.Amount += data.Where(r => r.IsFree == false && r.IsWriteOff == true).Sum(r => r.TotalAmount);
                    model2.Amount += data.Where(r => r.IsFree == false && r.IsWriteOff == false).Sum(r => r.TotalAmount);
                }

                model1.Amount = Math.Round(model1.Amount / 10000, 2);
                model2.Amount = Math.Round(model2.Amount / 10000, 2);
                model.Add(model1);
                model.Add(model2);

                return model;
            });

            var result = await task;
            this.pieChart.SetChartTitle($"{year}年{currentGroup.Name}核销费用比例");
            this.pieChart.SetSeriesLabel("万元");
            this.pieChart.DataSource = result;
        }

        /// <summary>
        /// 分组水电费比例
        /// </summary>
        /// <param name="group"></param>
        /// <param name="year"></param>
        private async void LoadGroupEnergy(Group group, int year)
        {
            var task = Task.Run(() =>
            {
                List<AccountDataModel> model = new List<AccountDataModel>();

                List<Settle> settleData = new List<Settle>();
                List<SettleRecord> records = new List<SettleRecord>();

                var items = BusinessFactory<GroupBusiness>.Instance.FindAllItems(group.Id);

                foreach (var item in items)
                {
                    var settle = BusinessFactory<SettleBusiness>.Instance.FindByAccount(item.EntityId, year);
                    settleData.AddRange(settle);

                    foreach (var st in settle)
                    {
                        records.AddRange(st.Records);
                    }
                }

                var groups = records.GroupBy(r => r.MeterType).Select(g => new SettleRecord
                {
                    MeterType = g.Key,
                    Amount = g.Sum(s => s.Amount)
                });

                foreach (var item in groups)
                {
                    AccountDataModel ad = new AccountDataModel();

                    ad.AccountName = item.MeterType == 1 ? "电费" : "水费";
                    ad.Amount = Math.Round(item.Amount / 10000, 2);

                    model.Add(ad);
                }

                return model;
            });

            var result = await task;
            this.pieChart.SetChartTitle($"{year}年{currentGroup.Name}水电费比例");
            this.pieChart.SetSeriesLabel("万元");
            this.pieChart.DataSource = result;
        }

        /// <summary>
        /// 分组账户结算费用
        /// </summary>
        /// <param name="group"></param>
        /// <param name="year"></param>
        private async void LoadGroupSettle(Group group, int year)
        {
            var task = Task.Run(() =>
            {
                List<AccountDataModel> data = new List<AccountDataModel>();
                var items = BusinessFactory<GroupBusiness>.Instance.FindAllItems(group.Id);

                foreach (var item in items)
                {
                    var account = BusinessFactory<AccountBusiness>.Instance.FindById(item.EntityId);
                    var settles = BusinessFactory<SettleBusiness>.Instance.FindByAccount(item.EntityId, year);

                    AccountDataModel model = new AccountDataModel
                    {
                        AccountName = account.Name,
                        Amount = Math.Round(settles.Where(r => r.IsFree == false).Sum(r => r.TotalAmount) / 10000, 2)
                    };

                    data.Add(model);
                }

                return data;
            });

            var result = await task;
            this.pieChart.SetChartTitle($"{year}年{currentGroup.Name}账户结算比例");
            this.pieChart.SetSeriesLabel("万元");
            this.pieChart.DataSource = result;
        }

        /// <summary>
        /// 分组账户回收费用
        /// </summary>
        /// <param name="group"></param>
        /// <param name="year"></param>
        private async void LoadGroupRecycle(Group group, int year)
        {
            var task = Task.Run(() =>
            {
                List<AccountDataModel> data = new List<AccountDataModel>();
                var items = BusinessFactory<GroupBusiness>.Instance.FindAllItems(group.Id);

                foreach (var item in items)
                {
                    var account = BusinessFactory<AccountBusiness>.Instance.FindById(item.EntityId);
                    var recycles = BusinessFactory<RecycleBusiness>.Instance.FindByAccount(item.EntityId, year);

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
            this.pieChart.SetChartTitle($"{year}年{currentGroup.Name}账户回收比例");
            this.pieChart.SetSeriesLabel("万元");
            this.pieChart.DataSource = result;
        }

        /// <summary>
        /// 载入数据
        /// </summary>
        /// <param name="account">账户</param>
        /// <param name="year">年度</param>
        /// <param name="dataType">数据类型</param>
        private void LoadGroupData(Group group, int year, int dataType)
        {
            switch (dataType)
            {
                case 1:
                    LoadGroupFeeType(group, year);
                    break;
                case 2:
                    LoadGroupPost(group, year);
                    break;
                case 3:
                    LoadGroupWriteOff(group, year);
                    break;
                case 4:
                    LoadGroupEnergy(group, year);
                    break;
                case 5:
                    LoadGroupSettle(group, year);
                    break;
                case 6:
                    LoadGroupRecycle(group, year);
                    break;
            }
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 设置账户
        /// </summary>
        /// <param name="account">回收账户</param>
        /// <param name="dataType">数据类型 1:费用分类  2:入账比例  3:核销比例  4:水电费比例</param>
        public void SetAccount(Account account, int dataType)
        {
            this.currentAccount = account;
            this.showType = 1;
            this.dataType = dataType;
            this.nowYear = DateTime.Now.Year;

            InitControls();
        }

        /// <summary>
        /// 设置分组
        /// </summary>
        /// <param name="group">分组</param>
        /// <param name="dataType">数据类型 1:费用分类  2:入账比例  3:核销比例  4:水电费比例  5:账户结算  6:账户回收</param>
        public void SetGroup(Group group, int dataType)
        {
            this.currentGroup = group;
            this.showType = 2;
            this.dataType = dataType;
            this.nowYear = DateTime.Now.Year;

            InitControls();
        }

        /// <summary>
        /// 清空显示
        /// </summary>
        public void Clear()
        {
            this.cmbYear.EditValue = "";
            this.pieChart.DataSource = null;
        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 年度选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbYear.SelectedIndex == -1)
                return;

            int year = Convert.ToInt32(this.cmbYear.SelectedItem.ToString().Substring(0, 4));
            if (this.showType == 1)
                LoadAccountData(this.currentAccount, year, this.dataType);
            else if (this.showType == 2)
                LoadGroupData(this.currentGroup, year, this.dataType);
        }
        #endregion //Event
    }
}
