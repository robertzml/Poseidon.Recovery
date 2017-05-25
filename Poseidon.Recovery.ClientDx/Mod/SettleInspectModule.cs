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
    /// 结算核查组件
    /// </summary>
    public partial class SettleInspectModule : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 当前关联账户
        /// </summary>
        private Account currentAccount;
        #endregion //Field

        #region Constructor
        public SettleInspectModule()
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
            this.settleRecordGrid.Init();
            this.debitGrid.Init(this.currentAccount.Id);
            this.debitOtherGrid.Init(this.currentAccount.Id);
            this.creditGrid.Init(this.currentAccount.Id);
            this.recycleRecordGrid.Init();
            this.bsSettle.DataSource = BusinessFactory<SettleBusiness>.Instance.FindByAccount(this.currentAccount.Id);
        }

        /// <summary>
        /// 显示结算信息
        /// </summary>
        /// <param name="settle"></param>
        private void DisplaySettleInfo(Settle settle)
        {
            this.txtPeriod.Text = settle.Period;
            this.txtSettleDate.Text = settle.SettleDate.ToDateString();
            this.txtPreviousDate.Text = settle.PreviousDate.ToDateString();
            this.txtCurrentDate.Text = settle.CurrentDate.ToDateString();
            this.txtTotalAmount.Text = settle.TotalAmount.ToString();
            this.chkIsFree.Checked = settle.IsFree;
            this.chkIsWriteOff.Checked = settle.IsWriteOff;
            this.txtRemark.Text = settle.Remark;
            this.txtCreateUser.Text = settle.CreateBy.Name;
            this.txtCreateTime.Text = settle.CreateBy.Time.ToDateTimeString();
            this.txtEditUser.Text = settle.UpdateBy.Name;
            this.txtEditTime.Text = settle.UpdateBy.Time.ToDateTimeString();

            this.settleRecordGrid.DataSource = settle.Records;
        }

        /// <summary>
        /// 显示对账信息
        /// </summary>
        /// <param name="settle"></param>
        private void DisplayReconcile(Settle settle)
        {
            this.reconcileGrid.DataSource = BusinessFactory<ReconcileBusiness>.Instance.FindBySettle(settle.Id).ToList();
        }

        /// <summary>
        /// 显示对账明细
        /// </summary>
        /// <param name="reconcile"></param>
        /// <param name="settle"></param>
        private void DisplayReconcileDetails(Reconcile reconcile, Settle settle)
        {
            this.debitGrid.DataSource = reconcile.Debits.Where(r => r.SettleId == settle.Id).ToList();
            this.debitOtherGrid.DataSource = reconcile.Debits.Where(r => r.SettleId == settle.Id).ToList();

            this.creditGrid.DataSource = reconcile.Credits.ToList();

            var recycle = BusinessFactory<RecycleBusiness>.Instance.FindById(reconcile.Credits.First().RecycleId);
            this.recycleRecordGrid.DataSource = recycle.Records;
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
            InitControls();
        }

        /// <summary>
        /// 清空显示
        /// </summary>
        /// <param name="include">是否包含选择框</param>
        public void Clear(bool include = true)
        {
            if (include)
                this.bsSettle.DataSource = null;

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
            this.reconcileGrid.Clear();
            this.debitGrid.Clear();
            this.debitOtherGrid.Clear();
            this.creditGrid.Clear();
            this.recycleRecordGrid.Clear();
        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 选择记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void luReceipt_EditValueChanged(object sender, EventArgs e)
        {
            if (this.luReceipt.EditValue == null)
                return;

            this.Clear(false);
            var settle = this.luReceipt.GetSelectedDataRow() as Settle;
            DisplaySettleInfo(settle);
            DisplayReconcile(settle);
        }

        /// <summary>
        /// 对账选择
        /// </summary>
        /// <param name="arg1"></param>
        /// <param name="arg2"></param>
        private void reconcileGrid_RowSelected(object arg1, EventArgs arg2)
        {
            var reconcile = this.reconcileGrid.GetCurrentSelect();
            if (reconcile == null)
            {
                this.debitGrid.Clear();
                this.debitOtherGrid.Clear();
                this.creditGrid.Clear();
                this.recycleRecordGrid.Clear();
                return;
            }

            var settle = this.luReceipt.GetSelectedDataRow() as Settle;
            DisplayReconcileDetails(reconcile, settle);
        }
        #endregion //Event
    }
}
