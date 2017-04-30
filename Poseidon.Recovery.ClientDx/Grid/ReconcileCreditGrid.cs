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
    using Poseidon.Common;
    using Poseidon.Winform.Base;
    using Poseidon.Winform.Core.Utility;
    using Poseidon.Recovery.Core.BL;
    using Poseidon.Recovery.Core.DL;
    using Poseidon.Recovery.Core.Utility;

    /// <summary>
    /// 对账贷方表格控件
    /// </summary>
    public partial class ReconcileCreditGrid : WinEntityGrid<ReconcileCredit>
    {
        #region Field
        /// <summary>
        /// 缓存回收信息
        /// </summary>
        private List<Recycle> recycles = new List<Recycle>();
        #endregion //Field

        #region Constructor
        public ReconcileCreditGrid()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="accountId">账户ID</param>
        public void Init(string accountId)
        {
            this.recycles = BusinessFactory<RecycleBusiness>.Instance.FindByAccount(accountId).ToList();
        }
        #endregion //Method

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

            var record = this.bsEntity[rowIndex] as ReconcileCredit;
            if (e.Column.FieldName == "RecycleId")
            {
                if (e.Value != null && !string.IsNullOrEmpty(e.Value.ToString()))
                {
                    var recycle = this.recycles.SingleOrDefault(r => r.Id == e.Value.ToString());
                    if (recycle != null)
                    {
                        e.DisplayText = recycle.RecycleDate.ToDateString();
                    }
                    else
                    {
                        recycle = BusinessFactory<RecycleBusiness>.Instance.FindById(e.Value.ToString());
                        e.DisplayText = recycle.RecycleDate.ToDateString();
                    }
                }
            }
        }

        /// <summary>
        /// 自定义数据显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvEntity_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            int rowIndex = e.ListSourceRowIndex;
            if (rowIndex < 0 || rowIndex >= this.bsEntity.Count)
                return;

            var record = this.bsEntity[rowIndex] as ReconcileCredit;
            if (e.Column.FieldName == "colRecycleAmount" && e.IsGetData)
            {
                var recycle = this.recycles.SingleOrDefault(r => r.Id == record.RecycleId);
                if (recycle != null)
                {
                    e.Value = recycle.TotalAmount;
                }
                else
                {
                    recycle = BusinessFactory<RecycleBusiness>.Instance.FindById(e.Value.ToString());
                    e.Value = recycle.TotalAmount;
                }
            }
        }
        #endregion //Event
    }
}
