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
    using DevExpress.XtraReports.UI;
    using Poseidon.Base.Framework;
    using Poseidon.Common;
    using Poseidon.Recovery.ClientDx.Report;
    using Poseidon.Recovery.Core.BL;
    using Poseidon.Recovery.Core.DL;
    using Poseidon.Recovery.Core.Utility;
    using Poseidon.Winform.Base;

    /// <summary>
    /// 费用结算单据模块
    /// </summary>
    public partial class SettleReceiptModule : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 当前关联账户
        /// </summary>
        private Account currentAccount;

        /// <summary>
        /// 是否能编辑
        /// </summary>
        private bool editable;
        #endregion //Field

        #region Constructor
        public SettleReceiptModule()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 载入结算数据
        /// </summary>
        /// <param name="account"></param>
        private void LoadData(Account account)
        {
            this.bsSettle.DataSource = BusinessFactory<SettleBusiness>.Instance.FindByAccount(account.Id);
        }

        /// <summary>
        /// 显示结算信息
        /// </summary>
        /// <param name="settle"></param>
        private void ShowSettleInfo(Settle settle)
        {
            this.txtPeriod.Text = settle.Period;
            this.txtSettleDate.Text = settle.SettleDate.ToDateString();
            this.txtPreviousDate.Text = settle.PreviousDate.ToDateString();
            this.txtCurrentDate.Text = settle.CurrentDate.ToDateString();
            this.txtTotalAmount.Text = settle.TotalAmount.ToString();
            this.chkIsFree.Checked = settle.IsFree;
            this.chkIsWriteOff.Checked = settle.IsWriteOff;
            this.txtRemark.Text = settle.Remark;
            this.txtCreateUser.Text = settle.CreateBy.Name;
            this.txtCreateTime.Text = settle.CreateBy.Time.ToDateTimeString();
            this.txtEditUser.Text = settle.UpdateBy.Name;
            this.txtEditTime.Text = settle.UpdateBy.Time.ToDateTimeString();

            this.txtElectricQuantum.Text = settle.Records.Where(r => r.MeterType == (int)MeterEnergyType.Electric).Sum(r => r.Quantum).ToString();
            this.txtWaterQuantum.Text = settle.Records.Where(r => r.MeterType == (int)MeterEnergyType.Water).Sum(r => r.Quantum).ToString();

            this.settleRecordGrid.DataSource = settle.Records;
            this.attachmentTool.Init(settle.AttachmentIds);
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 设置账户
        /// </summary>
        /// <param name="account"></param>
        public void SetAccount(Account account)
        {
            this.currentAccount = account;

            this.settleRecordGrid.Init();
            LoadData(account);
        }

        /// <summary>
        /// 清空显示
        /// </summary>
        private void Clear()
        {
            this.txtPeriod.Text = "";
            this.txtSettleDate.Text = "";
            this.txtPreviousDate.Text = "";
            this.txtCurrentDate.Text = "";
            this.txtTotalAmount.Text = "";
            this.txtElectricQuantum.Text = "";
            this.txtWaterQuantum.Text = "";
            this.txtRemark.Text = "";
            this.txtCreateUser.Text = "";
            this.txtCreateTime.Text = "";
            this.txtEditUser.Text = "";
            this.txtEditTime.Text = "";

            this.settleRecordGrid.Clear();
        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 控件载入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SettleReceiptModule_Load(object sender, EventArgs e)
        {
            if (!this.editable)
                this.lcgAction.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }

        /// <summary>
        /// 选择费用结算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbSettles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lbSettles.SelectedValue == null)
            {
                Clear();
                return;
            }

            ShowSettleInfo(this.lbSettles.SelectedItem as Settle);
        }

        /// <summary>
        /// 新增费用结算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.currentAccount == null)
                return;

            ChildFormManage.ShowDialogForm(typeof(FrmSettleAdd), new object[] { this.currentAccount.Id });
            LoadData(this.currentAccount);
        }

        /// <summary>
        /// 编辑费用结算
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.currentAccount == null || this.lbSettles.SelectedValue == null)
                return;

            var settle = this.lbSettles.SelectedItem as Settle;
            if (settle.IsFree == false && settle.IsWriteOff == true)
            {
                MessageUtil.ShowWarning("该结算已经核销，无法编辑");
                return;
            }

            ChildFormManage.ShowDialogForm(typeof(FrmSettleEdit), new object[] { settle.Id, this.currentAccount.Id });
            LoadData(this.currentAccount);
        }

        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData(this.currentAccount);
        }

        /// <summary>
        /// 打印结算单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (this.currentAccount == null || this.lbSettles.SelectedValue == null)
                return;

            var settle = this.lbSettles.SelectedItem as Settle;

            int count = settle.Records.Count;
            if (count < 9)
            {
                for (int i = 0; i < 9 - count; i++)
                {
                    settle.Records.Add(new SettleRecord { MeterType = 0 });
                }
            }

            List<Settle> ds = new List<Settle>();
            ds.Add(settle);

            RepSettle report = new RepSettle(settle);
            report.DataSource = ds;

            ReportPrintTool printTool = new ReportPrintTool(report);

            printTool.ShowRibbonPreview();
        }
        #endregion //Event

        #region Property
        /// <summary>
        /// 是否能编辑
        /// </summary>
        [Description("是否能编辑"), Category("功能"), Browsable(true)]
        public bool Editable
        {
            get
            {
                return this.editable;
            }
            set
            {
                this.editable = value;
            }
        }

        #endregion //Property
    }
}
