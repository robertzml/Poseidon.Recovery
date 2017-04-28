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
    /// 费用结算单据模块
    /// </summary>
    public partial class SettleReceiptModule : DevExpress.XtraEditors.XtraUserControl
    {
        #region Constructor
        public SettleReceiptModule()
        {
            InitializeComponent();
        }
        #endregion //Constructor
    }
}
