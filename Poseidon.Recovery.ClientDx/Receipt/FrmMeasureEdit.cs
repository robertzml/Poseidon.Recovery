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
    using Poseidon.Recovery.Core.Utility;

    /// <summary>
    /// 编辑抄表计量
    /// </summary>
    public partial class FrmMeasureEdit : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 关联账户
        /// </summary>
        private Account currentAccount;

        /// <summary>
        /// 当前关联抄表计量
        /// </summary>
        private Measure currentMeasure;
        #endregion //Field

        #region Constructor
        public FrmMeasureEdit(string id, string accountId)
        {
            InitializeComponent();
            InitData(id, accountId);
        }
        #endregion //Constructor

        #region Function
        private void InitData(string id, string accountId)
        {
            this.currentAccount = BusinessFactory<AccountBusiness>.Instance.FindById(accountId);
            this.currentMeasure = BusinessFactory<MeasureBusiness>.Instance.FindById(id);
        }

        protected override void InitForm()
        {
            this.measureRecordGrid.Init();

            this.txtAccountName.Text = this.currentAccount.Name;
            this.bsMeasure.DataSource = BusinessFactory<MeasureBusiness>.Instance.FindByAccount(this.currentAccount.Id);

            this.dpMeasureDate.DateTime = this.currentMeasure.MeasureDate;
            this.txtRemark.Text = this.currentMeasure.Remark;
            this.measureRecordGrid.DataSource = this.currentMeasure.Records;

            base.InitForm();
        }

        /// <summary>
        /// 输入检查
        /// </summary>
        /// <returns></returns>
        private Tuple<bool, string> CheckInput()
        {
            string errorMessage = "";

            if (this.dpMeasureDate.EditValue == null)
            {
                errorMessage = "抄表日期不能为空";
                return new Tuple<bool, string>(false, errorMessage);
            }

            foreach (var item in this.measureRecordGrid.DataSource)
            {
                if (string.IsNullOrEmpty(item.MeterName))
                {
                    errorMessage = "表名称不能为空";
                    return new Tuple<bool, string>(false, errorMessage);
                }
                if (string.IsNullOrEmpty(item.MeterNumber))
                {
                    errorMessage = "表号不能为空";
                    return new Tuple<bool, string>(false, errorMessage);
                }
                if (item.MeterType == 0)
                {
                    errorMessage = "请选择表类型";
                    return new Tuple<bool, string>(false, errorMessage);
                }
                if (item.ChargeType == 0)
                {
                    errorMessage = "请选择计费方式";
                    return new Tuple<bool, string>(false, errorMessage);
                }
            }

            return new Tuple<bool, string>(true, "");
        }

        /// <summary>
        /// 设置实体
        /// </summary>
        /// <param name="entity"></param>
        private void SetEntity(Measure entity)
        {
            entity.AccountId = this.currentAccount.Id;
            entity.MeasureDate = this.dpMeasureDate.DateTime.Date;
            entity.Remark = this.txtRemark.Text;

            entity.Records = this.measureRecordGrid.DataSource;
            foreach (var item in entity.Records)
            {
                item.MeterNumber = item.MeterNumber ?? "";
                item.MeterName = item.MeterName ?? "";
                item.Remark = item.Remark ?? "";
            }
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 上期选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void luPrevious_EditValueChanged(object sender, EventArgs e)
        {
            if (this.luPrevious.EditValue == null)
                return;

            var previous = this.luPrevious.GetSelectedDataRow() as Measure;
            this.measureRecordGrid.SetPrevious(previous.Records);
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.measureRecordGrid.CloseEditor();

            var input = CheckInput();
            if (!input.Item1)
            {
                MessageUtil.ShowError(input.Item2);
                return;
            }

            try
            {
                Measure entity = BusinessFactory<MeasureBusiness>.Instance.FindById(this.currentMeasure.Id);
                SetEntity(entity);

                BusinessFactory<MeasureBusiness>.Instance.Update(entity, this.currentUser);

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
