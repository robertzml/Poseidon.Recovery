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
    using Poseidon.Common;
    using Poseidon.Core.BL;
    using Poseidon.Core.DL;
    using Poseidon.Recovery.Core.BL;
    using Poseidon.Recovery.Core.DL;
    using Poseidon.Recovery.Core.Utility;

    /// <summary>
    /// 分组回收总览模块
    /// </summary>
    public partial class GroupRecoveryModule : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 当前关联分组
        /// </summary>
        private Group currentGroup;

        /// <summary>
        /// 今年
        /// </summary>
        private int year;
        #endregion //Field

        #region Constructor
        public GroupRecoveryModule()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 显示基本信息
        /// </summary>
        /// <param name="group"></param>
        private void DisplayInfo(Group group)
        {
            this.txtGroupName.Text = group.Name;
            this.txtGroupRemark.Text = group.Remark;
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 设置分组
        /// </summary>
        /// <param name="id">分组ID</param>
        public void SetGroup(string id)
        {
            this.currentGroup = BusinessFactory<GroupBusiness>.Instance.FindById(id);
            this.year = DateTime.Now.Year;
        }
        #endregion //Method
    }
}
