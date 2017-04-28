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
    /// 经营类账户表格控件
    /// </summary>
    public partial class CommerceAccountGrid : WinEntityGrid<CommerceAccount>
    {
        #region Constructor
        public CommerceAccountGrid()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Event
        /// <summary>
        /// 格式化数据显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvEntity_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            int rowIndex = e.ListSourceRowIndex;
            if (rowIndex < 0 || rowIndex >= this.bsEntity.Count)
                return;

            var record = this.bsEntity[rowIndex] as CommerceAccount;

            if (e.Column.FieldName == "ParentId")
            {
                if (e.Value != null && !string.IsNullOrEmpty(e.Value.ToString()))
                {
                    var parent = BusinessFactory<AccountBusiness>.Instance.FindById(e.Value.ToString());
                    e.DisplayText = parent.Name;
                }
            }
            if (e.Column.FieldName == "ChargeBuildingId")
            {
                if (e.Value != null && !string.IsNullOrEmpty(e.Value.ToString()))
                {
                    var building = BusinessFactory<ChargeBuildingBusiness>.Instance.FindById(e.Value.ToString());
                    e.DisplayText = building.Name;
                }
            }
            if (e.Column.FieldName == "CloseYear")
            {
                if (e.Value == null)
                    e.DisplayText = "";
            }
        }
        #endregion //Event
    }
}
