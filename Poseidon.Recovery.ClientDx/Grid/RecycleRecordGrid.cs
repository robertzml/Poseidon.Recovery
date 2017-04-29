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
    /// 回收记录表格控件
    /// </summary>
    public partial class RecycleRecordGrid : WinEntityGrid<RecycleRecord>
    {
        #region Constructor
        public RecycleRecordGrid()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 初始化控件
        /// </summary>
        public void Init()
        {
            ControlUtil.BindDictToComboBox(this.cmbFeeType, typeof(RecycleRecord), "FeeType");
        }
        #endregion //Method
    }
}
