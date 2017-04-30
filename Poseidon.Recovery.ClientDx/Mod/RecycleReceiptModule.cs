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
    /// 费用回收单据模块
    /// </summary>
    public partial class RecycleReceiptModule : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 当前关联账户
        /// </summary>
        /// 
        private Account currentAccount;

        /// <summary>
        /// 是否能编辑
        /// </summary>
        private bool editable;
        #endregion //Field

        #region Constructor
        public RecycleReceiptModule()
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
            this.bsRecycle.DataSource = BusinessFactory<RecycleBusiness>.Instance.FindByAccount(account.Id);
        }

        /// <summary>
        /// 显示回收信息
        /// </summary>
        /// <param name="recycle"></param>
        private void ShowRecycleInfo(Recycle recycle)
        {
            this.txtRecycleDate.Text = recycle.RecycleDate.ToDateString();
            this.txtTotalAmount.Text = recycle.TotalAmount.ToString();
            this.chkIsPost.Checked = recycle.IsPost;
            this.txtRemark.Text = recycle.Remark;
            this.txtCreateUser.Text = recycle.CreateBy.Name;
            this.txtCreateTime.Text = recycle.CreateBy.Time.ToDateTimeString();
            this.txtEditUser.Text = recycle.UpdateBy.Name;
            this.txtEditTime.Text = recycle.UpdateBy.Time.ToDateTimeString();

            this.recycleRecordGrid.DataSource = recycle.Records;
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

            this.recycleRecordGrid.Init();
            LoadData(account);
        }

        /// <summary>
        /// 清空显示
        /// </summary>
        private void Clear()
        {
            this.txtRecycleDate.Text = "";
            this.txtTotalAmount.Text = "";
            this.txtRemark.Text = "";
            this.txtCreateUser.Text = "";
            this.txtCreateTime.Text = "";
            this.txtEditUser.Text = "";
            this.txtEditTime.Text = "";

            this.recycleRecordGrid.Clear();
        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 控件载入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RecycleReceiptModule_Load(object sender, EventArgs e)
        {
            if (!this.editable)
                this.lcgAction.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }

        /// <summary>
        /// 选择费用回收
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbRecycles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lbRecycles.SelectedValue == null)
            {
                Clear();
                return;
            }

            ShowRecycleInfo(this.lbRecycles.SelectedItem as Recycle);
        }

        /// <summary>
        /// 新增费用回收
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.currentAccount == null)
                return;

            ChildFormManage.ShowDialogForm(typeof(FrmRecycleAdd), new object[] { this.currentAccount.Id });
            LoadData(this.currentAccount);
        }

        /// <summary>
        /// 编辑费用回收
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.currentAccount == null || this.lbRecycles.SelectedValue == null)
                return;

            var recycle = this.lbRecycles.SelectedItem as Recycle;
            ChildFormManage.ShowDialogForm(typeof(FrmRecycleEdit), new object[] { recycle.Id, this.currentAccount.Id });
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
