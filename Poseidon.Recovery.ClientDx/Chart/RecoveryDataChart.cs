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
    using DevExpress.XtraCharts;
    using Poseidon.Recovery.Core.BL;
    using Poseidon.Recovery.Core.DL;
    using Poseidon.Recovery.Core.Utility;

    /// <summary>
    /// 回收数据图表控件
    /// </summary>
    public partial class RecoveryDataChart : DevExpress.XtraEditors.XtraUserControl
    {
        #region Constructor
        public RecoveryDataChart()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 设置图表标题
        /// </summary>
        /// <param name="text">标题</param>
        public void SetChartTitle(string text)
        {
            this.chartMain.Titles[0].Text = text;
            this.chartMain.Titles[0].Visibility = DevExpress.Utils.DefaultBoolean.True;
        }

        /// <summary>
        /// 设置图例标题
        /// </summary>
        /// <param name="index">序号</param>
        /// <param name="text">标题</param>
        public void SetSeriesLengedText(int index, string text)
        {
            this.chartMain.Series[index].LegendText = text;
        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 打印
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuPrint_Click(object sender, EventArgs e)
        {
            this.chartMain.ShowRibbonPrintPreview();
        }
        #endregion //Event

        #region Property
        /// <summary>
        /// 数据源
        /// </summary>
        [Description("数据源")]
        public List<RecoveryDataModel> DataSource
        {
            get
            {
                return this.bsRecovery.DataSource as List<RecoveryDataModel>;
            }
            set
            {
                this.bsRecovery.DataSource = value;
            }
        }
        #endregion //Property
    }
}
