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
        /// 1:费用分类  2:入账比例  3:核销比例  4:水电费比例
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
            this.pieChart.SetChartTitle($"{currentAccount.Name}回收费用类型");
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
            this.pieChart.SetChartTitle($"{currentAccount.Name}入账费用比例");
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
            this.pieChart.SetChartTitle($"{currentAccount.Name}核销费用比例");
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
            this.pieChart.SetChartTitle($"{currentAccount.Name}水电费比例");
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
            //else if (this.showType == 2)
            //    LoadGroupData(this.currentGroup, year);
        }
        #endregion //Event
    }
}
