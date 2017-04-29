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
        #region Field
        /// <summary>
        /// 是否显示计算量
        /// </summary>
        private bool showCalculate;
        #endregion //Field

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

        #region Event
        private void SettleRecordGrid_Load(object sender, EventArgs e)
        {
            this.colCalQuantum.Visible = this.showCalculate;
            this.colCalAmount.Visible = this.showCalculate;
        }
        #endregion //Event

        #region Property
        /// <summary>
        /// 是否显示计算量
        /// </summary>
        [Description("是否显示计算量"), Category("界面"), Browsable(true)]
        public bool ShowCalculate
        {
            get
            {
                return showCalculate;
            }

            set
            {
                showCalculate = value;
            }
        }
        #endregion //Property
    }
}
