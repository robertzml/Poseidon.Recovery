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
    using Poseidon.Base.System;
    using Poseidon.Winform.Base;
    using Poseidon.Recovery.Core.BL;
    using Poseidon.Recovery.Core.DL;

    /// <summary>
    /// 增加工程类回收账户窗体
    /// </summary>
    public partial class FrmConstructionAccountAdd : BaseSingleForm
    {
        #region Constructor
        public FrmConstructionAccountAdd()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            //this.bsAccount.DataSource = BusinessFactory<Construction>.Instance.FindAll();
            
            base.InitForm();
        }

        #endregion //Function

        private void btnConfirm_Click(object sender, EventArgs e)
        {

        }
    }
}
