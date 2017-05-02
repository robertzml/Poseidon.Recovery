using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using DevExpress.XtraReports.UI;

namespace Poseidon.Recovery.ClientDx.Report
{
    using Poseidon.Base.Framework;
    using Poseidon.Base.System;
    using Poseidon.Common;
    using Poseidon.Recovery.Core.BL;
    using Poseidon.Recovery.Core.DL;
    using System.Drawing;

    /// <summary>
    /// 结算单报表
    /// </summary>
    public partial class RepSettle : DevExpress.XtraReports.UI.XtraReport
    {
        #region Constructor
        public RepSettle(Settle settle)
        {
            InitializeComponent();
            InitData(settle);
        }
        #endregion //Constructor

        #region Function
        private void InitData(Settle settle)
        {
            this.Term.Value = $"{settle.PreviousDate.ToDateString()}  至  {settle.CurrentDate.ToDateString()}";

            var account = BusinessFactory<AccountBusiness>.Instance.FindById(settle.AccountId);
            this.AccountName.Value = account.Name;
            this.AmountChn.Value = ConvertUtility.ChnMoney(settle.TotalAmount.ToString());
        }
        #endregion //Function

        #region Event
        private void tableCellMeterType_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var cell = sender as XRTableCell;
            if (string.IsNullOrEmpty(cell.Text))
                return;
            var type = Convert.ToInt32(cell.Text);
            if (type == 1)
                this.tableCellMeterType.Text = "电表";
            else if (type == 2)
                this.tableCellMeterType.Text = "水表";
        }

        /// <summary>
        /// 处理空行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tableRowDetail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            var row = sender as XRTableRow;

            if (row.Cells[2].Text == "0")
            {
                row.Cells[2].Text = "";
                row.Cells[3].Text = "";
                row.Cells[4].Text = "";
                row.Cells[5].Text = "";
                row.Cells[6].Text = "";
                row.Cells[7].Text = "";
                row.Cells[8].Text = "";
            }
        }
        #endregion //Event
    }
}
