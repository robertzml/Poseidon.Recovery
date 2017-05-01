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
            this.commerceAccountTree.SetGroupCode(RecoveryConstant.CommerceRecoveryAccountGroupCode, true);
            base.InitForm();
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 经营类账户选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void commerceAccountTree_EntitySelected(object sender, EventArgs e)
        {
            this.navFrame.SelectedPageIndex = 1;

            var id = this.commerceAccountTree.GetCurrentSelectId();
            this.accountMod.SetAccount(id, 1);
        }

        /// <summary>
        /// 分组选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void commerceAccountTree_GroupSelected(object sender, EventArgs e)
        {
            this.navFrame.SelectedPageIndex = 0;
            var id = this.commerceAccountTree.GetCurrentSelectId();
            this.groupMod.SetGroup(id);
        }
        #endregion //Event
    }
}
