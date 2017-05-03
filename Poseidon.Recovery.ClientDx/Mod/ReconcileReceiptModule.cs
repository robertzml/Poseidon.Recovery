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

    /// <summary>
    /// 财务对账模块
    /// </summary>
    public partial class ReconcileReceiptModule : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 当前关联账户
        /// </summary>
        /// 
        private Account currentAccount;

        /// <summary>
        /// 是否能编辑
        /// </summary>
        private bool editable;
        #endregion //Field

        #region Constructor
        public ReconcileReceiptModule()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        private void LoadData(Account account)
        {
            var data = BusinessFactory<ReconcileBusiness>.Instance.FindByAccount(account.Id).ToList();
            this.reconcileGrid.DataSource = data;
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

            this.debitGrid.Init(account.Id);
            this.debitOtherGrid.Init(account.Id);
            this.creditGrid.Init(account.Id);
            this.recycleRecordGrid.Init();

            LoadData(account);
        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 控件载入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReconcileReceiptModule_Load(object sender, EventArgs e)
        {
            if (!this.editable)
                this.lcgAction.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }

        /// <summary>
        /// 选择对账记录
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

        /// <summary>
        /// 新增对账
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.currentAccount == null)
                return;

            ChildFormManage.ShowDialogForm(typeof(FrmReconcileAdd), new object[] { this.currentAccount.Id });
            LoadData(this.currentAccount);
        }

        /// <summary>
        /// 撤回对账
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRevert_Click(object sender, EventArgs e)
        {
            if (this.currentAccount == null || this.reconcileGrid.GetCurrentSelect() == null)
                return;

            if (MessageUtil.ConfirmYesNo("是否确认撤回选中对账记录") == DialogResult.Yes)
            {
                var reconcile = this.reconcileGrid.GetCurrentSelect();

                BusinessFactory<ReconcileBusiness>.Instance.Revert(reconcile);
                LoadData(this.currentAccount);
            }
        }

        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
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
