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
    /// 新增费用回收
    /// </summary>
    public partial class FrmRecycleAdd : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 关联账户
        /// </summary>
        private Account currentAccount;
        #endregion //Field

        #region Constructor
        public FrmRecycleAdd(string accountId)
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
            this.dpRecycleDate.DateTime = DateTime.Now.Date;

            this.recycleRecordGrid.Init();
            this.recycleRecordGrid.DataSource = new List<RecycleRecord>();

            base.InitForm();
        }

        /// <summary>
        /// 输入检查
        /// </summary>
        /// <returns></returns>
        private Tuple<bool, string> CheckInput()
        {
            string errorMessage = "";

            if (this.dpRecycleDate.EditValue == null)
            {
                errorMessage = "回收日期不能为空";
                return new Tuple<bool, string>(false, errorMessage);
            }

            foreach (var item in this.recycleRecordGrid.DataSource)
            {
                if (string.IsNullOrEmpty(item.Name))
                {
                    errorMessage = "名称不能为空";
                    return new Tuple<bool, string>(false, errorMessage);
                }
                if (item.FeeType == 0)
                {
                    errorMessage = "请选择费用类型";
                    return new Tuple<bool, string>(false, errorMessage);
                }
            }

            return new Tuple<bool, string>(true, "");
        }

        /// <summary>
        /// 设置实体
        /// </summary>
        /// <param name="entity"></param>
        private void SetEntity(Recycle entity)
        {
            entity.AccountId = this.currentAccount.Id;
            entity.RecycleDate = this.dpRecycleDate.DateTime.Date;
            entity.TotalAmount = this.spTotalAmount.Value;
            entity.Remark = this.txtRemark.Text;

            entity.Records = this.recycleRecordGrid.DataSource;
            foreach (var item in entity.Records)
            {
                item.Name = item.Name ?? "";
                item.Remark = item.Remark ?? "";
            }
        }
        #endregion //Function

        #region Event
        /// <summary>
        /// 计算金额
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalc_Click(object sender, EventArgs e)
        {
            this.recycleRecordGrid.CloseEditor();

            decimal totalAmount = 0;

            foreach (var item in this.recycleRecordGrid.DataSource)
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
            this.recycleRecordGrid.CloseEditor();

            var input = CheckInput();
            if (!input.Item1)
            {
                MessageUtil.ShowError(input.Item2);
                return;
            }

            try
            {
                Recycle entity = new Recycle();
                SetEntity(entity);

                BusinessFactory<RecycleBusiness>.Instance.Create(entity, this.currentUser);

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
