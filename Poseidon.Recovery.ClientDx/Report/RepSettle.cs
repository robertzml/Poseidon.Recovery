using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using DevExpress.XtraReports.UI;

namespace Poseidon.Recovery.ClientDx.Report
{
    using Poseidon.Base.Framework;
    using Poseidon.Base.System;
    using Poseidon.Common;
    using Poseidon.Recovery.Core.BL;
    using Poseidon.Recovery.Core.DL;

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
        }
        #endregion //Function

        private void RepSettle_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            
        }
    }
}
