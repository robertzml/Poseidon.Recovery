using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poseidon.Recovery.ClientDx
{
    using Poseidon.Base.Framework;
    using Poseidon.Winform.Base;
    using Poseidon.Recovery.Core.BL;
    using Poseidon.Recovery.Core.DL;

    /// <summary>
    /// 回收表格控件
    /// </summary>
    public partial class RecycleGrid : WinEntityGrid<Recycle>
    {
        #region Constructor
        public RecycleGrid()
        {
            InitializeComponent();
        }
        #endregion //Constructor
    }
}
