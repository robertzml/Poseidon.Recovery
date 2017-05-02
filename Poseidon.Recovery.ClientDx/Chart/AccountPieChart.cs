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
    using DevExpress.XtraCharts;
    using Poseidon.Core.Utility;
    using Poseidon.Recovery.Core.Utility;

    /// <summary>
    /// 账户相关饼图
    /// </summary>
    public partial class AccountPieChart : DevExpress.XtraEditors.XtraUserControl
    {
        #region Constructor
        public AccountPieChart()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 设置图表标题
        /// </summary>
        /// <param name="text"></param>
        public void SetChartTitle(string text)
        {
            this.chartMain.Titles[0].Text = text;
        }

        /// <summary>
        /// 设置系列标签单位
        /// </summary>
        /// <param name="unit">单位</param>
        public void SetSeriesLabel(string unit)
        {
            this.chartMain.Series[0].Label.TextPattern = "{A}-{V}" + unit;
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
        public List<AccountDataModel> DataSource
        {
            get
            {
                return this.bsAccountData.DataSource as List<AccountDataModel>;
            }
            set
            {
                this.bsAccountData.DataSource = value;
            }
        }
        #endregion //Property
    }
}
