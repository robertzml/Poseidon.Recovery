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

        #region Method
        /// <summary>
        /// 设置账户
        /// </summary>
        /// <param name="account"></param>
        public void SetAccount(Account account)
        {
            this.currentAccount = account;

            //this.recycleRecordGrid.Init();
            //LoadData(account);
        }
        #endregion //Method

        #region Event
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
            //LoadData(this.currentAccount);
        }
        #endregion //Event
    }
}
