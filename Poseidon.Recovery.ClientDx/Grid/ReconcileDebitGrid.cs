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
    /// 对账借方表格控件
    /// </summary>
    public partial class ReconcileDebitGrid : WinEntityGrid<ReconcileDebit>
    {
        #region Field
        /// <summary>
        /// 缓存结算信息
        /// </summary>
        private List<Settle> settles = new List<Settle>();

        /// <summary>
        /// 借方为结算数据
        /// </summary>
        private bool isSettle = true;
        #endregion //Field

        #region Constructor
        public ReconcileDebitGrid()
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
            this.settles = BusinessFactory<SettleBusiness>.Instance.FindByAccount(accountId).ToList();
            ControlUtil.BindDictToComboBox(this.cmbFeeType, typeof(ReconcileDebit), "FeeType");
        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 控件载入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReconcileDebitGrid_Load(object sender, EventArgs e)
        {
            this.colSettleId.Visible = this.isSettle;
            this.colSettleAmount.Visible = this.isSettle;
        }

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

            var record = this.bsEntity[rowIndex] as ReconcileDebit;
            if (e.Column.FieldName == "SettleId")
            {
                if (e.Value != null && !string.IsNullOrEmpty(e.Value.ToString()))
                {
                    var settle = this.settles.SingleOrDefault(r => r.Id == e.Value.ToString());
                    if (settle != null)
                    {
                        e.DisplayText = settle.Period;
                    }
                    else
                    {
                        settle = BusinessFactory<SettleBusiness>.Instance.FindById(e.Value.ToString());
                        e.DisplayText = settle.Period;
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

            var record = this.bsEntity[rowIndex] as ReconcileDebit;
            if (e.Column.FieldName == "colSettleAmount" && e.IsGetData)
            {
                if (string.IsNullOrEmpty(record.SettleId))
                    return;
                var settle = this.settles.SingleOrDefault(r => r.Id == record.SettleId);
                if (settle != null)
                {
                    e.Value = settle.TotalAmount;
                }
                else
                {
                    settle = BusinessFactory<SettleBusiness>.Instance.FindById(record.SettleId);
                    e.Value = settle.TotalAmount;
                }
            }
        }
        #endregion //Event

        #region Property
        /// <summary>
        /// 借方为结算数据
        /// </summary>
        [Description("借方为结算数据"), Category("功能"), Browsable(true)]
        public bool IsSettle
        {
            get
            {
                return isSettle;
            }

            set
            {
                isSettle = value;
            }
        }
        #endregion //Property
    }
}
