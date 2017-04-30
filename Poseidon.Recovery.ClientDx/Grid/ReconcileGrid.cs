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
    using Poseidon.Winform.Base;
    using Poseidon.Winform.Core.Utility;
    using Poseidon.Recovery.Core.BL;
    using Poseidon.Recovery.Core.DL;
    using Poseidon.Recovery.Core.Utility;

    /// <summary>
    /// 对账表格控件
    /// </summary>
    public partial class ReconcileGrid : WinEntityGrid<Reconcile>
    {
        #region Constructor
        public ReconcileGrid()
        {
            InitializeComponent();
        }
        #endregion //Constructor
    }
}
