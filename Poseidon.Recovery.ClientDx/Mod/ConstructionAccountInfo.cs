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
    using Poseidon.Core.Utility;
    using Poseidon.Recovery.Core.BL;
    using Poseidon.Recovery.Core.DL;
    using Poseidon.Recovery.Core.Utility;

    /// <summary>
    /// 工程类账户信息模块
    /// </summary>
    public partial class ConstructionAccountInfo : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        private ConstructionAccount currentAccount;
        #endregion //Field

        #region Constructor
        public ConstructionAccountInfo()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 显示基本信息
        /// </summary>
        /// <param name="account"></param>
        private void DisplayInfo(ConstructionAccount account)
        {
            this.txtName.Text = account.Name;
            this.txtShortName.Text = account.ShortName;
            this.txtTicketName.Text = account.TicketName;
            this.txtConstructionCompany.Text = account.ConstructionCompany;
            this.txtConstructionName.Text = account.ConstructionName;

            this.txtChargeType.Text = DictUtility.GetDictValue(account, "ChargeType", account.ChargeType);

            if (!string.IsNullOrEmpty(account.ParentId))
                this.txtParent.Text = BusinessFactory<AccountBusiness>.Instance.FindById(account.ParentId).Name;

            this.txtOpenYear.Text = $"{account.OpenYear}年";
            if (account.CloseYear != null && account.CloseYear != 0)
                this.txtCloseYear.Text = $"{account.CloseYear}年";

            if (account.EnergyType.Contains(1))
                this.chkType1.Checked = true;
            if (account.EnergyType.Contains(2))
                this.chkType2.Checked = true;

            this.txtContact.Text = account.Contact;
            this.txtRemark.Text = account.Remark;
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 设置账户
        /// </summary>
        /// <param name="id">账户ID</param>
        public void SetAccount(string id)
        {
            this.currentAccount = BusinessFactory<ConstructionAccountBusiness>.Instance.FindById(id);
            DisplayInfo(this.currentAccount);
        }

        /// <summary>
        /// 清空显示
        /// </summary>
        public void Clear()
        {
            this.txtName.Text = "";
            this.txtShortName.Text = "";
            this.txtTicketName.Text = "";
            this.txtConstructionCompany.Text = "";
            this.txtConstructionName.Text = "";
            this.txtChargeType.Text = "";
            this.txtOpenYear.Text = "";
            this.txtCloseYear.Text = "";
            this.chkType1.Checked = false;
            this.chkType2.Checked = false;
            this.txtContact.Text = "";
            this.txtRemark.Text = "";
        }
        #endregion //Method
    }
}
