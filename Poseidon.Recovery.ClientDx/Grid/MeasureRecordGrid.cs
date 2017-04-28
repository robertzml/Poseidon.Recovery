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
    /// 抄表登记表格控件
    /// </summary>
    public partial class MeasureRecordGrid : WinEntityGrid<MeasureRecord>
    {
        #region Field
        /// <summary>
        /// 是否显示上期数
        /// </summary>
        private bool showPrevious = false;
        #endregion //Field

        #region Constructor
        public MeasureRecordGrid()
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
            ControlUtil.BindEnumToComboBox(this.cmbEnergyType, typeof(MeterEnergyType));
            ControlUtil.BindEnumToComboBox(this.cmbChargeType, typeof(MeterChargeType));
        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 控件载入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MeasureRecordGrid_Load(object sender, EventArgs e)
        {
            this.colPrevious.Visible = this.showPrevious;
            this.colQuantum.Visible = this.showPrevious;
        }
        #endregion //Event

        #region Property
        /// <summary>
        /// 是否显示上期数
        /// </summary>
        [Description("是否显示上期数"), Category("界面"), Browsable(true)]
        public bool ShowPrevious
        {
            get
            {
                return showPrevious;
            }

            set
            {
                showPrevious = value;
            }
        }
        #endregion //Property
    }
}
