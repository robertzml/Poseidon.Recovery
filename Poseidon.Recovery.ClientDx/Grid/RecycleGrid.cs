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
    using Poseidon.Base.Framework;
    using Poseidon.Winform.Base;
    using Poseidon.Recovery.Core.BL;
    using Poseidon.Recovery.Core.DL;

    /// <summary>
    /// 回收表格控件
    /// </summary>
    public partial class RecycleGrid : WinEntityGrid<Recycle>
    {
        #region Field
        /// <summary>
        /// 是否显示账户
        /// </summary>
        private bool showAccount = false;

        /// <summary>
        /// 缓存账户数据
        /// </summary>
        private List<Account> accounts;
        #endregion //Field

        #region Constructor
        public RecycleGrid()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Method
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="modelType">模型类型</param>
        public void Init(string modelType)
        {
            this.accounts = BusinessFactory<AccountBusiness>.Instance.FindAll(modelType).ToList();
        }

        /// <summary>
        /// 设置是否显示账户
        /// </summary>
        /// <param name="showAccount">是否显示账户</param>
        public void SetShowAccount(bool showAccount)
        {
            this.showAccount = showAccount;
            this.colAccountId.Visible = showAccount;
        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 控件载入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RecycleGrid_Load(object sender, EventArgs e)
        {
            this.colAccountId.Visible = this.showAccount;
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

            if (!this.showAccount)
                return;

            var record = this.bsEntity[rowIndex] as Recycle;
            if (e.Column.FieldName == "AccountId")
            {
                if (e.Value != null && !string.IsNullOrEmpty(e.Value.ToString()))
                {
                    Account account = null;
                    if (this.accounts != null)
                    {
                        account = this.accounts.SingleOrDefault(r => r.Id == e.Value.ToString());
                        if (account != null)
                            e.DisplayText = account.Name;
                    }

                    if (account == null)
                    {
                        account = BusinessFactory<AccountBusiness>.Instance.FindById(e.Value.ToString());
                        if (account != null)
                            e.DisplayText = account.Name;
                    }
                }
            }
        }
        #endregion //Event

        #region Property
        /// <summary>
        /// 是否显示账户
        /// </summary>
        [Description("是否显示账户"), Category("界面"), Browsable(true)]
        public bool ShowAccount
        {
            get
            {
                return showAccount;
            }

            set
            {
                showAccount = value;
            }
        }
        #endregion //Property
    }
}
