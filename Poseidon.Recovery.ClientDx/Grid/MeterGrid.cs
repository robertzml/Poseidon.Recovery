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
    using DevExpress.XtraEditors.Repository;
    using DevExpress.XtraEditors.Controls;
    using Poseidon.Base.Framework;
    using Poseidon.Common;
    using Poseidon.Winform.Base;
    using Poseidon.Winform.Core.Utility;
    using Poseidon.Recovery.Core.BL;
    using Poseidon.Recovery.Core.DL;
    using Poseidon.Recovery.Core.Utility;

    /// <summary>
    /// 表具表格控件
    /// </summary>
    public partial class MeterGrid : WinEntityGrid<Meter>
    {
        #region Constructor
        public MeterGrid()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 初始化
        /// </summary>
        public void Init()
        {
            ControlUtil.BindEnumToComboBox(this.cmbEnergyType, typeof(MeterEnergyType));
            ControlUtil.BindEnumToComboBox(this.cmbChargeType, typeof(MeterChargeType));
        }
        #endregion //Method
    }
}
