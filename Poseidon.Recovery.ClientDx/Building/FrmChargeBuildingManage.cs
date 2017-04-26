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

    /// <summary>
    /// 计费建筑管理窗体
    /// </summary>
    public partial class FrmChargeBuildingManage : BaseMdiForm
    {
        #region Field
        /// <summary>
        /// 当前选择账户
        /// </summary>
        private ChargeBuilding currentBuilding;
        #endregion //Field

        #region Constructor
        public FrmChargeBuildingManage()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            LoadBuilding();
            base.InitForm();
        }

        /// <summary>
        /// 载入账户
        /// </summary>
        private void LoadBuilding()
        {
            this.bsChargeBuilding.DataSource = BusinessFactory<ChargeBuildingBusiness>.Instance.FindAll().ToList();
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 选择建筑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbChargeBuildings_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lbChargeBuildings.SelectedItem == null)
                return;

            this.currentBuilding = this.lbChargeBuildings.SelectedItem as ChargeBuilding;
            this.txtName.Text = this.currentBuilding.Name;
            this.txtRemark.Text = this.currentBuilding.Remark;

            if (!string.IsNullOrEmpty(this.currentBuilding.ParentId))
            {
                var parent = BusinessFactory<ChargeBuildingBusiness>.Instance.FindById(this.currentBuilding.ParentId);
                this.txtParent.Text = parent.Name;
            }
        }

        /// <summary>
        /// 新增建筑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            ChildFormManage.ShowDialogForm(typeof(FrmChargeBuildingAdd));
            LoadBuilding();
        }

        /// <summary>
        /// 编辑建筑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.currentBuilding == null)
                return;

            ChildFormManage.ShowDialogForm(typeof(FrmChargeBuildingEdit), new object[] { this.currentBuilding.Id });
            LoadBuilding();
        }
        #endregion //Event
    }
}
