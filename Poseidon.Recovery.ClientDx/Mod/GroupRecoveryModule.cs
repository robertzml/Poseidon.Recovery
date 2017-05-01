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
        #endregion //Field

        #region Constructor
        public GroupRecoveryModule()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 清空显示
        /// </summary>
        private void ClearDisplay()
        {
            this.txtGroupName.Text = "";
            this.txtGroupRemark.Text = "";

            this.settleYearMod.Clear();
            this.settleYearChartMod.Clear();
            this.recycleYearMod.Clear();
            this.recycleYearChartMod.Clear();
            this.reconcileYearMod.Clear();
        }

        /// <summary>
        /// 显示基本信息
        /// </summary>
        /// <param name="group"></param>
        private void DisplayInfo(Group group)
        {
            this.txtGroupName.Text = group.Name;
            this.txtGroupRemark.Text = group.Remark;
        }

        /// <summary>
        /// 显示摘要
        /// </summary>
        /// <param name="group"></param>
        private async void DisplaySummary(Group group)
        {
            var task = Task.Run(() =>
            {
                var items = BusinessFactory<GroupBusiness>.Instance.FindAllItems(group.Id);

                List<Settle> settles = new List<Settle>();
                List<Recycle> recycles = new List<Recycle>();

                foreach (var item in items)
                {
                    var st = BusinessFactory<SettleBusiness>.Instance.FindByAccount(item.EntityId, false, false);
                    settles.AddRange(st);

                    var rc = BusinessFactory<RecycleBusiness>.Instance.FindByAccount(item.EntityId, false);
                    recycles.AddRange(rc);
                }

                return new { Settles = settles, Recycles = recycles };
            });

            var result = await task;

            this.settleGrid.DataSource = result.Settles;
            this.recycleGrid.DataSource = result.Recycles;
        }

        /// <summary>
        /// 显示年度信息
        /// </summary>
        /// <param name="group"></param>
        private void DisplayYear(Group group)
        {
            this.settleYearMod.SetGroup(group);
            this.settleYearChartMod.SetGroup(group);
            this.recycleYearMod.SetGroup(group);
            this.recycleYearChartMod.SetGroup(group);
            this.reconcileYearMod.SetGroup(group);
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

            ClearDisplay();

            this.groupSummaryMod.SetGroup(currentGroup);
            DisplayInfo(currentGroup);
            DisplaySummary(currentGroup);
            DisplayYear(currentGroup);
        }
        #endregion //Method
    }
}
