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
    using Poseidon.Base.Framework;
    using Poseidon.Common;
    using Poseidon.Core.Utility;
    using Poseidon.Recovery.Core.BL;
    using Poseidon.Recovery.Core.DL;
    using Poseidon.Recovery.Core.Utility;
    using Poseidon.Winform.Base;

    /// <summary>
    /// 回收费用类型饼状图
    /// </summary>
    public partial class FeeTypeChart : DevExpress.XtraEditors.XtraUserControl
    {
        #region Constructor
        public FeeTypeChart()
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
        /// 设置数据
        /// </summary>
        /// <param name="data"></param>
        public void SetSeries(List<RecycleRecord> data)
        {
            this.chartMain.Series[0].Points.Clear();

            foreach (var item in data)
            {
                string name =  DictUtility.GetDictValue(item, "FeeType", item.FeeType);
                this.chartMain.Series[0].Points.Add(new SeriesPoint(name, item.Amount));
            }
        }
        #endregion //Method
    }
}
