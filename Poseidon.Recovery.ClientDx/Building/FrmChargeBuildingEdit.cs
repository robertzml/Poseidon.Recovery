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
    using Poseidon.Base.System;
    using Poseidon.Winform.Base;
    using Poseidon.Recovery.Core.BL;
    using Poseidon.Recovery.Core.DL;

    /// <summary>
    /// 编辑计费建筑窗体
    /// </summary>
    public partial class FrmChargeBuildingEdit : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 当前关联建筑
        /// </summary>
        private ChargeBuilding currentBuilding;
        #endregion //Field

        #region Constructor
        public FrmChargeBuildingEdit(string id)
        {
            InitializeComponent();
            InitData(id);
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 初始化数据
        /// </summary>
        /// <param name="id"></param>
        private void InitData(string id)
        {
            this.currentBuilding = BusinessFactory<ChargeBuildingBusiness>.Instance.FindById(id);
        }
        protected override void InitForm()
        {
            this.bsChargeBuilding.DataSource = BusinessFactory<ChargeBuildingBusiness>.Instance.FindAll().ToList();

            this.txtName.Text = this.currentBuilding.Name;
            this.tluParent.EditValue = this.currentBuilding.ParentId;
            this.txtRemark.Text = this.currentBuilding.Remark;

            base.InitForm();
        }

        /// <summary>
        /// 输入检查
        /// </summary>
        /// <returns></returns>
        private Tuple<bool, string> CheckInput()
        {
            string errorMessage = "";

            if (string.IsNullOrEmpty(this.txtName.Text.Trim()))
            {
                errorMessage = "名称不能为空";
                return new Tuple<bool, string>(false, errorMessage);
            }

            return new Tuple<bool, string>(true, "");
        }

        /// <summary>
        /// 设置实体
        /// </summary>
        /// <param name="entity"></param>
        private void SetEntity(ChargeBuilding entity)
        {
            entity.Name = this.txtName.Text;
            entity.Remark = this.txtRemark.Text;

            if (this.tluParent.EditValue != null)
                entity.ParentId = this.tluParent.EditValue.ToString();
            else
                entity.ParentId = null;
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var input = CheckInput();
            if (!input.Item1)
            {
                MessageUtil.ShowError(input.Item2);
                return;
            }

            try
            {
                ChargeBuilding entity = BusinessFactory<ChargeBuildingBusiness>.Instance.FindById(this.currentBuilding.Id);
                SetEntity(entity);

                BusinessFactory<ChargeBuildingBusiness>.Instance.Update(entity);

                MessageUtil.ShowInfo("保存成功");
                this.Close();
            }
            catch (PoseidonException pe)
            {
                MessageUtil.ShowError(string.Format("保存失败，错误消息:{0}", pe.Message));
            }
        }
        #endregion //Event
    }
}
