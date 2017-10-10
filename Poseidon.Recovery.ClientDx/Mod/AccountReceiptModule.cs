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
    using Poseidon.Winform.Base;
    using Poseidon.Recovery.Core.BL;
    using Poseidon.Recovery.Core.DL;
    using Poseidon.Recovery.Core.Utility;

    /// <summary>
    /// 账户回收单据模块
    /// </summary>
    public partial class AccountReceiptModule : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 当前关联账户
        /// </summary>
        private Account currentAccount;
        #endregion //Field

        #region Constructor
        public AccountReceiptModule()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
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
        /// 显示业务相关信息
        /// </summary>
        /// <param name="account"></param>
        private void DisplayBusiness(Account account)
        {
            this.settleMod.SetAccount(account);
            this.recycleMod.SetAccount(account);
            this.measureMod.SetAccount(account);
            this.reconcileMod.SetAccount(account);
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 设置账户
        /// </summary>
        /// <param name="id">支出账户ID</param>
        /// <param name="accountType">账户类型</param>
        public void SetAccount(string id, int accountType)
        {
            this.currentAccount = BusinessFactory<AccountBusiness>.Instance.FindById(id);

            if (accountType == 1)
            {
                this.navFrame.SelectedPageIndex = 0;
                this.commerceAccountMod.SetAccount(id);
            }
            else if (accountType == 2)
            {
                this.navFrame.SelectedPageIndex = 1;
                this.constructionAccountMod.SetAccount(id);
            }

            this.reconcileMod.Clear();

            DisplayMeter(currentAccount);
            DisplayBusiness(currentAccount);
        }

        /// <summary>
        /// 清空显示
        /// </summary>
        public void Clear()
        {
            this.commerceAccountMod.Clear();
            this.constructionAccountMod.Clear();
        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 批量检查核销
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheckWriteOff_Click(object sender, EventArgs e)
        {
            if (MessageUtil.ConfirmYesNo("是否批量检查结算核销") == DialogResult.Yes)
            {
                this.Cursor = Cursors.WaitCursor;

                var settles = BusinessFactory<SettleBusiness>.Instance.FindByAccount(this.currentAccount.Id);

                foreach (var item in settles)
                {
                    BusinessFactory<SettleBusiness>.Instance.UpdateOffAmount(item.Id);
                }

                this.Cursor = Cursors.Default;

                MessageUtil.ShowInfo("检查完成");
            }
        }

        /// <summary>
        /// 批量检查入账
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheckPost_Click(object sender, EventArgs e)
        {
            if (MessageUtil.ConfirmYesNo("是否批量检查回收入账") == DialogResult.Yes)
            {
                this.Cursor = Cursors.WaitCursor;

                var recycles = BusinessFactory<RecycleBusiness>.Instance.FindByAccount(this.currentAccount.Id);

                foreach (var item in recycles)
                {
                    BusinessFactory<RecycleBusiness>.Instance.UpdatePostAmount(item.Id);
                }

                this.Cursor = Cursors.Default;

                MessageUtil.ShowInfo("检查完成");
            }
        }
        #endregion //Event
    }
}
