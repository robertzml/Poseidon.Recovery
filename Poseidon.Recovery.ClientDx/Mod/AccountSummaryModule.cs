﻿using System;
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
    using Poseidon.Recovery.Core.BL;
    using Poseidon.Recovery.Core.DL;
    using Poseidon.Recovery.Core.Utility;
    using Poseidon.Winform.Base;

    /// <summary>
    /// 账户汇总模块
    /// </summary>
    public partial class AccountSummaryModule : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 当前关联账户
        /// </summary>
        private Account currentAccount;
        #endregion //Field

        #region Constructor
        public AccountSummaryModule()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 载入结算数据
        /// </summary>
        /// <param name="account"></param>
        private async void LoadSettleData(Account account)
        {
            var task1 = Task.Run(() =>
            {
                var data = BusinessFactory<SettleBusiness>.Instance.FindByAccount(account.Id);
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
            this.digGagDebt.Text = Convert.ToInt32(debtFee).ToString();
            this.arcScaleComponent1.Value = Convert.ToSingle(rate);

            this.unoffSettleGrid.DataSource = settles.Where(r => r.IsWriteOff == false).ToList();
        }

        /// <summary>
        /// 载入回收数据
        /// </summary>
        /// <param name="account"></param>
        private async void LoadRecycleData(Account account)
        {
            var task1 = Task.Run(() =>
            {
                var data = BusinessFactory<RecycleBusiness>.Instance.FindByAccount(account.Id);

                List<RecycleRecord> records = new List<RecycleRecord>();
                foreach (var recycle in data)
                {
                    records.AddRange(recycle.Records);
                }

                var groups = records.GroupBy(r => r.FeeType).Select(g => new RecycleRecord
                {
                    FeeType = g.Key,
                    Amount = g.Sum(s => s.Amount)
                });

                return new { Recycle = data, Group = groups };
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

            this.feeTypeChart.SetChartTitle($"{account.Name}回收费用类型");
            this.feeTypeChart.SetSeriesLabel("元");
            this.feeTypeChart.SetSeries(recycles.Group.ToList());

            this.unpostRecycleGrid.DataSource = recycles.Recycle.Where(r => r.IsPost == false).ToList();
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 设置账户
        /// </summary>
        /// <param name="account">支出账户</param>
        public void SetAccount(Account account)
        {
            this.currentAccount = account;

            LoadSettleData(account);
            LoadRecycleData(account);
        }
        #endregion //Method
    }
}
