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
    using Poseidon.Common;
    using Poseidon.Winform.Base;
    using Poseidon.Winform.Core.Utility;
    using Poseidon.Recovery.Core.BL;
    using Poseidon.Recovery.Core.DL;
    using Poseidon.Recovery.Core.Utility;

    /// <summary>
    /// 结算记录表格控件
    /// </summary>
    public partial class SettleRecordGrid : WinEntityGrid<SettleRecord>
    {
        #region Constructor
        public SettleRecordGrid()
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
            ControlUtil.BindEnumToComboBox(this.cmbMeterType, typeof(MeterEnergyType));          
        }
        #endregion //Method
    }
}
