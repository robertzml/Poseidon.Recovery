using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
    /// 编辑费用结算窗体
    /// </summary>
    public partial class FrmSettleEdit : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 关联账户
        /// </summary>
        private Account currentAccount;

        /// <summary>
        /// 当前关联费用结算
        /// </summary>
        private Settle currentSettle;
        #endregion //Field

        #region Constructor
        public FrmSettleEdit(string id, string accountId)
        {
            InitializeComponent();
            InitData(id, accountId);
        }
        #endregion //Constructor

        #region Function
        private void InitData(string id, string accountId)
        {
            this.currentAccount = BusinessFactory<AccountBusiness>.Instance.FindById(accountId);
            this.currentSettle = BusinessFactory<SettleBusiness>.Instance.FindById(id);
        }

        protected override void InitForm()
        {
            this.settleRecordGrid.Init();

            this.txtAccountName.Text = this.currentAccount.Name;
            this.bsMeasure.DataSource = BusinessFactory<MeasureBusiness>.Instance.FindByAccount(this.currentAccount.Id);

            this.txtPeriod.Text = this.currentSettle.Period;
            this.dpSettleDate.DateTime = this.currentSettle.SettleDate;
            this.dpPreviousDate.DateTime = this.currentSettle.PreviousDate;
            this.dpCurrentDate.DateTime = this.currentSettle.CurrentDate;
            this.spTotalAmount.Value = this.currentSettle.TotalAmount;
            this.chkIsFree.Checked = this.currentSettle.IsFree;
            this.txtRemark.Text = this.currentSettle.Remark;

            this.settleRecordGrid.DataSource = this.currentSettle.Records;

            base.InitForm();
        }


        /// <summary>
        /// 使用抄表数
        /// </summary>
        /// <param name="records">抄表记录</param>
        /// <param name="type">1:上期数 2:本期数</param>
        private void UseMeasure(List<MeasureRecord> records, int type)
        {
            foreach (var item in this.settleRecordGrid.DataSource)
            {
                var find = records.FirstOrDefault(r => r.MeterName == item.MeterName && r.MeterNumber == item.MeterNumber);
                if (find != null)
                {
                    if (type == 1)
                        item.Previous = find.Indication;
                    else if (type == 2)
                        item.Current = find.Indication;
                }
            }

            this.settleRecordGrid.UpdateBindingData();
        }

        /// <summary>
        /// 输入检查
        /// </summary>
        /// <returns></returns>
        private Tuple<bool, string> CheckInput()
        {
            string errorMessage = "";

            if (string.IsNullOrEmpty(this.txtPeriod.Text))
            {
                errorMessage = "用能周期不能为空";
                return new Tuple<bool, string>(false, errorMessage);
            }
            if (this.dpSettleDate.EditValue == null)
            {
                errorMessage = "结算日期不能为空";
                return new Tuple<bool, string>(false, errorMessage);
            }
            if (this.dpPreviousDate.EditValue == null)
            {
                errorMessage = "上期日期不能为空";
                return new Tuple<bool, string>(false, errorMessage);
            }
            if (this.dpCurrentDate.EditValue == null)
            {
                errorMessage = "本期日期不能为空";
                return new Tuple<bool, string>(false, errorMessage);
            }

            foreach (var item in this.settleRecordGrid.DataSource)
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
            }

            return new Tuple<bool, string>(true, "");
        }

        /// <summary>
        /// 设置实体
        /// </summary>
        /// <param name="entity"></param>
        private void SetEntity(Settle entity)
        {
            entity.AccountId = this.currentAccount.Id;
            entity.Period = this.txtPeriod.Text;
            entity.SettleDate = this.dpSettleDate.DateTime.Date;
            entity.PreviousDate = this.dpPreviousDate.DateTime.Date;
            entity.CurrentDate = this.dpCurrentDate.DateTime.Date;
            entity.TotalAmount = this.spTotalAmount.Value;
            entity.IsFree = this.chkIsFree.Checked;
            entity.Remark = this.txtRemark.Text;

            entity.Records = this.settleRecordGrid.DataSource;
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
        /// 选择上期抄表记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void luPreviousMeasure_EditValueChanged(object sender, EventArgs e)
        {
            if (this.luPreviousMeasure.EditValue == null)
                return;

            var measure = this.luPreviousMeasure.GetSelectedDataRow() as Measure;
            UseMeasure(measure.Records, 1);
        }

        /// <summary>
        /// 选择本期抄表记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void luCurrentMeasure_EditValueChanged(object sender, EventArgs e)
        {
            if (this.luCurrentMeasure.EditValue == null)
                return;

            var measure = this.luCurrentMeasure.GetSelectedDataRow() as Measure;
            UseMeasure(measure.Records, 2);
        }

        /// <summary>
        /// 金额求和
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalc_Click(object sender, EventArgs e)
        {
            this.settleRecordGrid.CloseEditor();

            decimal totalAmount = 0;

            foreach (var item in this.settleRecordGrid.DataSource)
            {
                totalAmount += item.Amount;

            }

            this.spTotalAmount.Value = totalAmount;
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.settleRecordGrid.CloseEditor();

            var input = CheckInput();
            if (!input.Item1)
            {
                MessageUtil.ShowError(input.Item2);
                return;
            }

            try
            {
                Settle entity = BusinessFactory<SettleBusiness>.Instance.FindById(this.currentSettle.Id);
                SetEntity(entity);

                BusinessFactory<SettleBusiness>.Instance.Update(entity, this.currentUser);

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
