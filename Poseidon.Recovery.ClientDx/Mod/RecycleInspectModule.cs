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
    using Poseidon.Winform.Base;

    public partial class RecycleInspectModule : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 当前关联账户
        /// </summary>
        private Account currentAccount;
        #endregion //Field

        #region Constructor
        public RecycleInspectModule()
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
            this.recordGrid.Init();
            this.debitGrid.Init(this.currentAccount.Id);
            this.debitOtherGrid.Init(this.currentAccount.Id);
            this.creditGrid.Init(this.currentAccount.Id);
            this.recycleRecordGrid.Init();
            this.bsRecycle.DataSource = BusinessFactory<RecycleBusiness>.Instance.FindByAccount(this.currentAccount.Id);
        }

        /// <summary>
        /// 显示回收信息
        /// </summary>
        /// <param name="recycle"></param>
        private void DisplayRecycleInfo(Recycle recycle)
        {
            this.txtRecycleDate.Text = recycle.RecycleDate.ToDateString();
            this.txtTotalAmount.Text = recycle.TotalAmount.ToString();
            this.chkIsPost.Checked = recycle.IsPost;
            this.txtRemark.Text = recycle.Remark;
            this.txtCreateUser.Text = recycle.CreateBy.Name;
            this.txtCreateTime.Text = recycle.CreateBy.Time.ToDateTimeString();
            this.txtEditUser.Text = recycle.UpdateBy.Name;
            this.txtEditTime.Text = recycle.UpdateBy.Time.ToDateTimeString();

            this.recordGrid.DataSource = recycle.Records;
        }

        /// <summary>
        /// 显示对账信息
        /// </summary>
        /// <param name="recyclee"></param>
        private void DisplayReconcile(Recycle recyclee)
        {
            this.reconcileGrid.DataSource = BusinessFactory<ReconcileBusiness>.Instance.FindByRecycle(recyclee.Id).ToList();
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
        public void Clear()
        {
            this.txtRecycleDate.Text = "";
            this.txtTotalAmount.Text = "";
            this.txtRemark.Text = "";
            this.txtCreateUser.Text = "";
            this.txtCreateTime.Text = "";
            this.txtEditUser.Text = "";
            this.txtEditTime.Text = "";

            this.recordGrid.Clear();
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

            var recycle = this.luReceipt.GetSelectedDataRow() as Recycle;
            DisplayRecycleInfo(recycle);
            DisplayReconcile(recycle);
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

            this.debitGrid.DataSource = reconcile.Debits.Where(r => !string.IsNullOrEmpty(r.SettleId)).ToList();
            this.debitOtherGrid.DataSource = reconcile.Debits.Where(r => string.IsNullOrEmpty(r.SettleId)).ToList();

            this.creditGrid.DataSource = reconcile.Credits.ToList();

            var recycle = BusinessFactory<RecycleBusiness>.Instance.FindById(reconcile.Credits.First().RecycleId);
            this.recycleRecordGrid.DataSource = recycle.Records;
        }
        #endregion //Event
    }
}
