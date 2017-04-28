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
    using Poseidon.Core.BL;
    using Poseidon.Core.DL;
    using Poseidon.Winform.Base;
    using Poseidon.Recovery.Core.BL;
    using Poseidon.Recovery.Core.DL;
    using Poseidon.Recovery.Core.Utility;

    /// <summary>
    /// 费用回收单据窗体
    /// </summary>
    public partial class FrmRecoveryReceipt : BaseMdiForm
    {
        #region Constructor
        public FrmRecoveryReceipt()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            this.accountTree.SetGroupCode(RecoveryConstant.RecoveryAccountGroupCode);

            base.InitForm();
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 账户选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void accountTree_EntitySelected(object sender, EventArgs e)
        {
            this.navFrame.SelectedPageIndex = 1;
            var accountId = this.accountTree.GetCurrentSelectId();
            this.accountReceiptMod.SetAccount(accountId);
        }
        #endregion //Event
    }
}
