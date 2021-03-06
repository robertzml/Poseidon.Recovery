﻿using System;
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
    /// 增加回收账户窗体
    /// </summary>
    public partial class FrmCommerceAccountAdd : BaseSingleForm
    {
        #region Constructor
        public FrmCommerceAccountAdd()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        protected override void InitForm()
        {
            this.bsAccount.DataSource = BusinessFactory<CommerceAccountBusiness>.Instance.FindAll();
            this.bsChargeBuilding.DataSource = BusinessFactory<ChargeBuildingBusiness>.Instance.FindAll();

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
        private void SetEntity(CommerceAccount entity)
        {
            entity.Name = this.txtName.Text;
            entity.ShortName = this.txtShortName.Text;
            entity.TicketName = this.txtTicketName.Text;
            entity.Contact = this.txtContact.Text;
            entity.Remark = this.txtRemark.Text;

            if (this.tluParent.EditValue != null)
                entity.ParentId = this.tluParent.EditValue.ToString();
            else
                entity.ParentId = null;

            if (this.tluChargeBuilding.EditValue != null)
                entity.ChargeBuildingId = this.tluChargeBuilding.EditValue.ToString();
            else
                entity.ChargeBuildingId = null;

            entity.OpenYear = Convert.ToInt32(this.spOpenYear.Value);
            if (this.spCloseYear.Value != 0)
                entity.CloseYear = Convert.ToInt32(this.spCloseYear.Value);
            else
                entity.CloseYear = null;

            entity.EnergyType = new List<int>();
            if (chkType1.Checked)
                entity.EnergyType.Add(1);
            if (chkType2.Checked)
                entity.EnergyType.Add(2);
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
                CommerceAccount entity = new CommerceAccount();
                SetEntity(entity);

                BusinessFactory<CommerceAccountBusiness>.Instance.Create(entity);

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
