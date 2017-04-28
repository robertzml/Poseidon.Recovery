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
    /// 账户回收模型
    /// </summary>
    public partial class AccountReceiptModule : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 当前关联账户
        /// </summary>
        private Account currentAccount;
        
        /// <summary>
        /// 今年
        /// </summary>
        private int nowYear;
        #endregion //Field

        #region Constructor
        public AccountReceiptModule()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 显示基本信息
        /// </summary>
        /// <param name="account"></param>
        private void DisplayInfo(Account account)
        {
            this.txtName.Text = account.Name;
            this.txtShortName.Text = account.ShortName;

            if (!string.IsNullOrEmpty(account.ParentId))
                this.txtParent.Text = BusinessFactory<AccountBusiness>.Instance.FindById(account.ParentId).Name;

            //if (!string.IsNullOrEmpty(account.ChargeBuildingId))
            //    this.txtChargeBuilding.Text = BusinessFactory<ChargeBuildingBusiness>.Instance.FindById(account.ChargeBuildingId).Name;

            this.txtOpenYear.Text = $"{account.OpenYear}年";
            if (account.CloseYear != null && account.CloseYear != 0)
                this.txtCloseYear.Text = $"{account.CloseYear}年";

            if (account.EnergyType.Contains(1))
                this.chkType1.Checked = true;
            if (account.EnergyType.Contains(2))
                this.chkType2.Checked = true;

            this.txtContact.Text = account.Contract;
            this.txtRemark.Text = account.Remark;

            this.meterGrid.Init();
            this.meterGrid.DataSource = account.Meters;
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 设置账户
        /// </summary>
        /// <param name="id">支出账户ID</param>
        public void SetAccount(string id)
        {
            this.currentAccount = BusinessFactory<AccountBusiness>.Instance.FindById(id);
            this.nowYear = DateTime.Now.Year;

            DisplayInfo(currentAccount);
            //ClearDisplay();
            //DisplaySummary(this.currentAccount);
            //DisplayReceipt(this.currentAccount);
            //DisplayCompare(this.currentAccount);
            //DisplayYear(this.currentAccount);
        }
        #endregion //Method
    }
}
