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
    /// 费用结算单据模块
    /// </summary>
    public partial class SettleReceiptModule : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 当前关联账户
        /// </summary>
        private Account currentAccount;

        /// <summary>
        /// 是否能编辑
        /// </summary>
        private bool editable;
        #endregion //Field

        #region Constructor
        public SettleReceiptModule()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 载入结算数据
        /// </summary>
        /// <param name="account"></param>
        private void LoadData(Account account)
        {
            this.bsSettle.DataSource = BusinessFactory<SettleBusiness>.Instance.FindByAccount(account.Id);
        }

        /// <summary>
        /// 显示结算信息
        /// </summary>
        /// <param name="settle"></param>
        private void ShowSettleInfo(Settle settle)
        {
            this.txtPeriod.Text = settle.Period;
            this.txtSettleDate.Text = settle.SettleDate.ToDateString();
            this.txtPreviousDate.Text = settle.PreviousDate.ToDateString();
            this.txtCurrentDate.Text = settle.CurrentDate.ToDateString();
            this.txtTotalAmount.Text = settle.TotalAmount.ToString();
            this.txtRemark.Text = settle.Remark;
            this.txtCreateUser.Text = settle.CreateBy.Name;
            this.txtCreateTime.Text = settle.CreateBy.Time.ToDateTimeString();
            this.txtEditUser.Text = settle.UpdateBy.Name;
            this.txtEditTime.Text = settle.UpdateBy.Time.ToDateTimeString();

            this.settleRecordGrid.DataSource = settle.Records;
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 设置账户
        /// </summary>
        /// <param name="account"></param>
        public void SetAccount(Account account)
        {
            this.currentAccount = account;

            this.settleRecordGrid.Init();
            LoadData(account);
        }

        /// <summary>
        /// 清空显示
        /// </summary>
        private void Clear()
        {
            this.txtPeriod.Text = "";
            this.txtSettleDate.Text = "";
            this.txtPreviousDate.Text = "";
            this.txtCurrentDate.Text = "";
            this.txtTotalAmount.Text = "";
            this.txtRemark.Text = "";
            this.txtCreateUser.Text = "";
            this.txtCreateTime.Text = "";
            this.txtEditUser.Text = "";
            this.txtEditTime.Text = "";

            this.settleRecordGrid.Clear();
        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 控件载入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SettleReceiptModule_Load(object sender, EventArgs e)
        {
            if (!this.editable)
                this.lcgAction.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }

        /// <summary>
        /// 选择费用结算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbSettles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lbSettles.SelectedValue == null)
            {
                Clear();
                return;
            }

            ShowSettleInfo(this.lbSettles.SelectedItem as Settle);
        }

        /// <summary>
        /// 新增费用结算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmSettleAdd), new object[] { this.currentAccount.Id });
            LoadData(this.currentAccount);
        }
        #endregion //Event

        #region Property
        /// <summary>
        /// 是否能编辑
        /// </summary>
        [Description("是否能编辑"), Category("功能"), Browsable(true)]
        public bool Editable
        {
            get
            {
                return this.editable;
            }
            set
            {
                this.editable = value;
            }
        }
        #endregion //Property
    }
}