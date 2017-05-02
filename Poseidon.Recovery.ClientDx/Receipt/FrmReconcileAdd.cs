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
    /// 新增对账窗体
    /// </summary>
    public partial class FrmReconcileAdd : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 关联账户
        /// </summary>
        private Account currentAccount;
        #endregion //Field

        #region Constructor
        public FrmReconcileAdd(string accountId)
        {
            InitializeComponent();
            InitData(accountId);
        }
        #endregion //Constructor

        #region Function
        private void InitData(string accountId)
        {
            this.currentAccount = BusinessFactory<AccountBusiness>.Instance.FindById(accountId);
        }

        protected override void InitForm()
        {
            this.txtAccountName.Text = this.currentAccount.Name;

            this.bsSettle.DataSource = BusinessFactory<SettleBusiness>.Instance.FindByAccount(this.currentAccount.Id, false, false);
            this.bsRecycle.DataSource = BusinessFactory<RecycleBusiness>.Instance.FindByAccount(this.currentAccount.Id, false);

            this.debitGrid.Init(this.currentAccount.Id);
            this.debitOtherGrid.Init(this.currentAccount.Id);
            this.creditGrid.Init(this.currentAccount.Id);
            this.recycleRecordGrid.Init();

            this.debitGrid.DataSource = new List<ReconcileDebit>();
            this.debitOtherGrid.DataSource = new List<ReconcileDebit>();

            base.InitForm();
        }

        /// <summary>
        /// 设置借方数据
        /// </summary>
        /// <param name="settleIds">费用结算ID</param>
        private void SetDebits(List<string> settleIds)
        {
            List<ReconcileDebit> data = new List<ReconcileDebit>();
            foreach (var item in settleIds)
            {
                ReconcileDebit debt = new ReconcileDebit();
                debt.AccountId = this.currentAccount.Id;
                debt.SettleId = item;

                data.Add(debt);
            }

            this.debitGrid.DataSource = data;
        }

        /// <summary>
        /// 设置贷方数据
        /// </summary>
        /// <param name="recycleId">费用回收ID</param>
        private void SetCredits(string recycleId)
        {
            List<ReconcileCredit> data = new List<ReconcileCredit>();

            ReconcileCredit item = new ReconcileCredit();
            item.AccountId = this.currentAccount.Id;
            item.RecycleId = recycleId;

            data.Add(item);

            this.creditGrid.DataSource = data;
        }

        /// <summary>
        /// 输入检查
        /// </summary>
        /// <returns></returns>
        private Tuple<bool, string> CheckInput()
        {
            string errorMessage = "";

            if (this.dpReconcileDate.EditValue == null)
            {
                errorMessage = "入账日期不能为空";
                return new Tuple<bool, string>(false, errorMessage);
            }
            if (string.IsNullOrEmpty(this.txtCertificateNumber.Text))
            {
                errorMessage = "凭证号不能为空";
                return new Tuple<bool, string>(false, errorMessage);
            }
            if (string.IsNullOrEmpty(this.txtSummary.Text))
            {
                errorMessage = "摘要不能为空";
                return new Tuple<bool, string>(false, errorMessage);
            }

            //if (this.debitGrid.DataSource == null || this.debitGrid.DataSource.Count == 0)
            //{
            //    errorMessage = "无借方数据";
            //    return new Tuple<bool, string>(false, errorMessage);
            //}
            if (this.creditGrid.DataSource == null || this.creditGrid.DataSource.Count == 0)
            {
                errorMessage = "无贷方数据";
                return new Tuple<bool, string>(false, errorMessage);
            }

            foreach (var item in this.debitGrid.DataSource)
            {
                if (item.FeeType == 0)
                {
                    errorMessage = "请选择费用类型";
                    return new Tuple<bool, string>(false, errorMessage);
                }
            }
            foreach (var item in this.debitOtherGrid.DataSource)
            {
                if (item.FeeType == 0)
                {
                    errorMessage = "请选择费用类型";
                    return new Tuple<bool, string>(false, errorMessage);
                }
            }

            var debitAmount = this.debitGrid.DataSource.Sum(r => r.Amount);
            var debitOtherAmount = this.debitOtherGrid.DataSource.Sum(r => r.Amount);
            var creditAmount = this.creditGrid.DataSource.Sum(r => r.Amount);

            if (debitAmount + debitOtherAmount != creditAmount)
            {
                errorMessage = "借贷方金额不等";
                return new Tuple<bool, string>(false, errorMessage);
            }

            if (this.spAmount.Value != creditAmount)
            {
                errorMessage = "入账金额和贷方金额不等";
                return new Tuple<bool, string>(false, errorMessage);
            }

            return new Tuple<bool, string>(true, "");
        }

        /// <summary>
        /// 显示警告信息
        /// </summary>
        /// <returns></returns>
        private bool ShowWarnings()
        {
            string warningMessage = "";

            if (this.spAmount.Value == 0)
            {
                warningMessage = "入账金额为0";
            }

            if (string.IsNullOrEmpty(warningMessage))
                return true;
            else
            {
                if (MessageUtil.ConfirmYesNo(warningMessage + " 是否继续?") == DialogResult.Yes)
                    return true;
                else
                    return false;
            }
        }

        /// <summary>
        /// 设置实体
        /// </summary>
        /// <param name="entity"></param>
        private void SetEntity(Reconcile entity)
        {
            entity.AccountId = this.currentAccount.Id;
            entity.ReconcileDate = this.dpReconcileDate.DateTime.Date;
            entity.CertificateId = "";
            entity.CertificateNumber = this.txtCertificateNumber.Text;
            entity.Amount = this.spAmount.Value;
            entity.Summary = this.txtSummary.Text;
            entity.Remark = this.txtRemark.Text;

            entity.Debits = new List<ReconcileDebit>();
            entity.Debits.AddRange(this.debitGrid.DataSource);
            entity.Debits.AddRange(this.debitOtherGrid.DataSource);

            foreach (var item in entity.Debits)
            {
                item.AccountId = this.currentAccount.Id;
                item.SettleId = item.SettleId ?? "";
                item.Remark = item.Remark ?? "";
            }

            entity.Credits = this.creditGrid.DataSource;
            foreach (var item in entity.Credits)
            {
                item.Remark = item.Remark ?? "";
            }
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 结算信息选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbSettles_EditValueChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.cmbSettles.EditValue.ToString()))
            {
                this.debitGrid.Clear();
                return;
            }

            var select = this.cmbSettles.EditValue.ToString();
            var settles = select.Split(',').ToList();
            settles.ForEach(r => r.Trim());

            SetDebits(settles);
        }

        /// <summary>
        /// 回收信息选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void luRecycles_EditValueChanged(object sender, EventArgs e)
        {
            if (this.luRecycles.EditValue == null)
            {
                this.creditGrid.Clear();
                this.recycleRecordGrid.Clear();
                return;
            }

            var recycle = this.luRecycles.GetSelectedDataRow() as Recycle;
            SetCredits(recycle.Id);

            this.recycleRecordGrid.DataSource = recycle.Records;
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            this.debitGrid.CloseEditor();
            this.debitOtherGrid.CloseEditor();
            this.creditGrid.CloseEditor();

            var input = CheckInput();
            if (!input.Item1)
            {
                MessageUtil.ShowError(input.Item2);
                return;
            }

            if (!ShowWarnings())
                return;

            try
            {
                Reconcile entity = new Reconcile();
                SetEntity(entity);

                BusinessFactory<ReconcileBusiness>.Instance.Create(entity, this.currentUser);

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
