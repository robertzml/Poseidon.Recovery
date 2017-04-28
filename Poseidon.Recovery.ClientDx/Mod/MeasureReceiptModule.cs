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
    using Poseidon.Recovery.Core.BL;
    using Poseidon.Recovery.Core.DL;
    using Poseidon.Recovery.Core.Utility;
    using Poseidon.Winform.Base;

    /// <summary>
    /// 抄表登记单据模块
    /// </summary>
    public partial class MeasureReceiptModule : DevExpress.XtraEditors.XtraUserControl
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
        public MeasureReceiptModule()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 载入抄表单据
        /// </summary>
        /// <param name="account"></param>
        private void LoadData(Account account)
        {
            this.bsMeasure.DataSource = BusinessFactory<MeasureBusiness>.Instance.FindByAccount(account.Id);
        }

        /// <summary>
        /// 显示抄表信息
        /// </summary>
        /// <param name="measure"></param>
        private void ShowMeasureInfo(Measure measure)
        {
            this.txtMeasureDate.Text = measure.MeasureDate.ToDateString();
            this.txtRemark.Text = measure.Remark;
            this.txtCreateUser.Text = measure.CreateBy.Name;
            this.txtCreateTime.Text = measure.CreateBy.Time.ToDateTimeString();
            this.txtEditUser.Text = measure.UpdateBy.Name;
            this.txtEditTime.Text = measure.UpdateBy.Time.ToDateTimeString();

            this.measureRecordGrid.DataSource = measure.Records;
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

            this.measureRecordGrid.Init();
            LoadData(account);
        }

        /// <summary>
        /// 清空显示
        /// </summary>
        private void Clear()
        {
            this.txtMeasureDate.Text = "";
            this.txtRemark.Text = "";
            this.txtCreateUser.Text = "";
            this.txtCreateTime.Text = "";
            this.txtEditUser.Text = "";
            this.txtEditTime.Text = "";

            this.measureRecordGrid.Clear();
        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 控件载入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MeasureReceiptModule_Load(object sender, EventArgs e)
        {
            if (!this.editable)
                this.lcgAction.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }

        /// <summary>
        /// 选择单据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbMeasures_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lbMeasures.SelectedValue == null)
            {
                Clear();
                return;
            }

            ShowMeasureInfo(this.lbMeasures.SelectedItem as Measure);
        }

        /// <summary>
        /// 新增抄表登记
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmMeasureAdd), new object[] { this.currentAccount.Id });
            LoadData(this.currentAccount);
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
