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
    using Poseidon.Recovery.Core.BL;
    using Poseidon.Recovery.Core.DL;

    /// <summary>
    /// 结算表格控件
    /// </summary>
    public partial class SettleGrid : WinEntityGrid<Settle>
    {
        #region Field
        /// <summary>
        /// 是否显示起止时间
        /// </summary>
        private bool showBeginEnd = true;
        #endregion //Field

        #region Constructor
        public SettleGrid()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Event
        /// <summary>
        /// 控件载入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SettleGrid_Load(object sender, EventArgs e)
        {
            this.colPreviousDate.Visible = this.showBeginEnd;
            this.colCurrentDate.Visible = this.showBeginEnd;
        }
        #endregion //Event

        #region Property
        /// <summary>
        /// 是否显示起止时间
        /// </summary>
        [Description("是否显示起止时间"), Category("界面"), Browsable(true)]
        public bool ShowBeginEnd
        {
            get
            {
                return showBeginEnd;
            }

            set
            {
                showBeginEnd = value;
            }
        }
        #endregion //Property
    }
}
