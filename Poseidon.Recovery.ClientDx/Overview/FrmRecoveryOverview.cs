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
    /// 回收总览窗体
    /// </summary>
    public partial class FrmRecoveryOverview : BaseMdiForm
    {
        #region Constructor
        public FrmRecoveryOverview()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            this.accountTree.SetGroupCode(RecoveryConstant.RecoveryAccountGroupCode, true);
            base.InitForm();
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 分组选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void accountTree_GroupSelected(object sender, EventArgs e)
        {
            this.SuspendLayout();

            this.navFrame.SelectedPageIndex = 0;
            var id = this.accountTree.GetCurrentSelectId();
            this.groupMod.SetGroup(id);

            this.ResumeLayout();
        }

        /// <summary>
        /// 账户选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void accountTree_EntitySelected(object sender, EventArgs e)
        {
            this.SuspendLayout();

            this.navFrame.SelectedPageIndex = 1;
            var accountId = this.accountTree.GetCurrentSelectId();
            var account = BusinessFactory<AccountBusiness>.Instance.FindById(accountId);

            if (account.ModelType == ModelTypeCode.CommerceAccount)
                this.accountMod.SetAccount(accountId, 1);
            else if (account.ModelType == ModelTypeCode.ConstructionAccount)
                this.accountMod.SetAccount(accountId, 2);

            this.ResumeLayout();
        }
        #endregion //Event
    }
}
