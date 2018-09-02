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
    /// 账户附件设置
    /// </summary>
    public partial class FrmAccountAttachmentSet : BaseSingleForm
    {
        #region Field
        /// <summary>
        /// 当前关联账户
        /// </summary>
        private Account currentAccount;
        #endregion //Field

        #region Constructor
        public FrmAccountAttachmentSet(string accountId)
        {
            InitializeComponent();

            InitData(accountId);
        }
        #endregion //Constructor

        #region Function
        private void InitData(string id)
        {
            this.currentAccount = BusinessFactory<AccountBusiness>.Instance.FindById(id);
        }

        protected override void InitForm()
        {
            this.txtName.Text = this.currentAccount.Name;
            this.uploadTool.Init(this.currentAccount.AttachmentIds, RecoveryConstant.ModuleName);

            base.InitForm();
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
            try
            {
                BusinessFactory<AccountBusiness>.Instance.SetAttachments(this.currentAccount.Id, this.uploadTool.AttachmentIds);

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
