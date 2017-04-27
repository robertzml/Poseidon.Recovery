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
    /// 回收账户管理窗体
    /// </summary>
    public partial class FrmAccountManage : BaseMdiForm
    {
        #region Constructor
        public FrmAccountManage()
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
        /// 新增账户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmAccountAdd));
        }
        #endregion //Event
    }
}
