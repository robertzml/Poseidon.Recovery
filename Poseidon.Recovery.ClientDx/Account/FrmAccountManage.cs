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
    using Poseidon.Core.BL;
    using Poseidon.Core.DL;
    using Poseidon.Winform.Base;
    using Poseidon.Recovery.Core.BL;
    using Poseidon.Recovery.Core.DL;
    using Poseidon.Recovery.Core.Utility;

    /// <summary>
    /// 回收账户管理窗体
    /// </summary>
    public partial class FrmAccountManage : BaseMdiForm
    {
        #region Constructor
        public FrmAccountManage()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            LoadData();
            base.InitForm();
        }

        /// <summary>
        /// 载入账户数据
        /// </summary>
        private void LoadData()
        {
            this.commerceAccountGrid.DataSource = BusinessFactory<CommerceAccountBusiness>.Instance.FindAll().ToList();
            this.constructionAccountGrid.DataSource = BusinessFactory<ConstructionAccountBusiness>.Instance.FindAll().ToList();
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 新增账户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tabAccount.SelectedTabPage == tabPageCommerce)
            {
                ChildFormManage.ShowDialogForm(typeof(FrmCommerceAccountAdd));
            }
            else if (tabAccount.SelectedTabPage == tabPageConstruction)
            {
                ChildFormManage.ShowDialogForm(typeof(FrmConstructionAccountAdd));
            }

            LoadData();
        }

        /// <summary>
        /// 编辑账户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (tabAccount.SelectedTabPage == tabPageCommerce)
            {
                var select = this.commerceAccountGrid.GetCurrentSelect();
                if (select == null)
                    return;

                ChildFormManage.ShowDialogForm(typeof(FrmCommerceAccountEdit), new object[] { select.Id });
            }
            else if (tabAccount.SelectedTabPage == tabPageConstruction)
            {
                var select = this.constructionAccountGrid.GetCurrentSelect();
                if (select == null)
                    return;

                ChildFormManage.ShowDialogForm(typeof(FrmConstructionAccountEdit), new object[] { select.Id });
            }

            LoadData();
        }

        /// <summary>
        /// 设置表具
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSetMeter_Click(object sender, EventArgs e)
        {
            if (tabAccount.SelectedTabPage == tabPageCommerce)
            {
                var select = this.commerceAccountGrid.GetCurrentSelect();
                if (select == null)
                    return;

                ChildFormManage.ShowDialogForm(typeof(FrmMeterSet), new object[] { select.Id });
            }
            else if (tabAccount.SelectedTabPage == tabPageConstruction)
            {
                var select = this.constructionAccountGrid.GetCurrentSelect();
                if (select == null)
                    return;

                ChildFormManage.ShowDialogForm(typeof(FrmMeterSet), new object[] { select.Id });
            }

            LoadData();
        }
        #endregion //Event
    }
}
