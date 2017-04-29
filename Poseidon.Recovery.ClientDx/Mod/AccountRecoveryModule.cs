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
        /// 显示表具信息
        /// </summary>
        /// <param name="account"></param>
        private void DisplayMeter(Account account)
        {
            this.meterGrid.Init();
            this.meterGrid.DataSource = account.Meters;
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

            DisplayMeter(currentAccount);
            //DisplayBusiness(currentAccount);

        }
        #endregion //Method
    }
}
