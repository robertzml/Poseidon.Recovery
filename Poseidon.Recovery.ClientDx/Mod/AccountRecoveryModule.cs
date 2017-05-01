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
    using Poseidon.Recovery.Core.BL;
    using Poseidon.Recovery.Core.DL;
    using Poseidon.Recovery.Core.Utility;

    /// <summary>
    /// 账户回收总览模块
    /// </summary>
    public partial class AccountRecoveryModule : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 当前关联账户
        /// </summary>
        private Account currentAccount;
        #endregion //Field

        #region Constructor
        public AccountRecoveryModule()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 清空显示
        /// </summary>
        private void ClearDisplay()
        {
            this.commerceAccountMod.Clear();
            this.meterGrid.Clear();

            this.settleGrid.Clear();
            this.recycleGrid.Clear();
            this.reconcileGrid.Clear();

            this.settleYearMod.Clear();
            this.settleYearChartMod.Clear();
            this.recycleYearMod.Clear();
            this.recycleYearChartMod.Clear();
        }

        /// <summary>
        /// 显示表具信息
        /// </summary>
        /// <param name="account"></param>
        private void DisplayMeter(Account account)
        {
            this.meterGrid.Init();
            this.meterGrid.DataSource = account.Meters;
        }

        /// <summary>
        /// 显示汇总信息
        /// </summary>
        /// <param name="account"></param>
        private void DisplaySummary(Account account)
        {
            this.settleGrid.DataSource = BusinessFactory<SettleBusiness>.Instance.FindByAccount(account.Id).ToList();
            this.recycleGrid.DataSource = BusinessFactory<RecycleBusiness>.Instance.FindByAccount(account.Id).ToList();
            this.reconcileGrid.DataSource = BusinessFactory<ReconcileBusiness>.Instance.FindByAccount(account.Id).ToList();
        }

        /// <summary>
        /// 显示单据信息
        /// </summary>
        /// <param name="account"></param>
        private void DisplayReceipt(Account account)
        {
            this.settleReceiptMod.SetAccount(account);
            this.recycleReceiptMod.SetAccount(account);
            this.measureReceiptMod.SetAccount(account);
            this.reconcileReceiptMod.SetAccount(account);
        }

        /// <summary>
        /// 显示年度信息
        /// </summary>
        /// <param name="account"></param>
        private void DisplayYear(Account account)
        {
            this.settleYearMod.SetAccount(account);
            this.settleYearChartMod.SetAccount(account);
            this.recycleYearMod.SetAccount(account);
            this.recycleYearChartMod.SetAccount(account);
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 设置账户
        /// </summary>
        /// <param name="id">支出账户ID</param>
        /// <param name="accountType">账户类型 1:经营类账户 2:工程类账户</param>
        public void SetAccount(string id, int accountType)
        {
            this.currentAccount = BusinessFactory<AccountBusiness>.Instance.FindById(id);

            ClearDisplay();

            if (accountType == 1)
            {
                this.navFrame.SelectedPageIndex = 0;
                this.commerceAccountMod.SetAccount(id);
            }
            else if (accountType == 2)
            {
                this.navFrame.SelectedPageIndex = 1;
            }

            this.accountSummaryMod.SetAccount(currentAccount);
            DisplayMeter(currentAccount);
            DisplaySummary(currentAccount);
            DisplayReceipt(currentAccount);
            DisplayYear(currentAccount);
        }
        #endregion //Method
    }
}
