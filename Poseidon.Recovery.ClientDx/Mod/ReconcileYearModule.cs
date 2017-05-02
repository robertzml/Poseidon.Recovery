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
    using Poseidon.Core.DL;
    using Poseidon.Core.BL;
    using Poseidon.Recovery.Core.BL;
    using Poseidon.Recovery.Core.DL;
    using Poseidon.Recovery.Core.Utility;

    /// <summary>
    /// 年度财务对账控件
    /// </summary>
    public partial class ReconcileYearModule : DevExpress.XtraEditors.XtraUserControl
    {
        #region Field
        /// <summary>
        /// 当前关联账户
        /// </summary>
        private Account currentAccount;

        /// <summary>
        /// 当前关联分组
        /// </summary>
        private Group currentGroup;

        private int startYear = 2014;

        private int nowYear;

        /// <summary>
        /// 显示类型  1:部门  2:分组
        /// </summary>
        private int showType;
        #endregion //Field

        #region Constructor
        public ReconcileYearModule()
        {
            InitializeComponent();
        }
        #endregion //Constructor

        #region Function
        /// <summary>
        /// 初始化控件
        /// </summary>
        private void InitControls()
        {
            this.cmbYear.Properties.Items.Clear();

            for (int i = nowYear; i >= startYear; i--)
            {
                this.cmbYear.Properties.Items.Add(i.ToString() + "年");
            }

            this.cmbYear.SelectedIndex = 0;

            if (this.showType == 2)
            {
                this.reconcileGrid.SetShowAccount(true);
                if (currentGroup.ModelTypes.Count > 0)
                {
                    this.reconcileGrid.Init(currentGroup.ModelTypes[0]);
                }
            }
        }

        /// <summary>
        /// 载入数据
        /// </summary>
        /// <param name="account">账户</param>
        /// <param name="year">年度</param>
        private async void LoadAccountData(Account account, int year)
        {
            var task = Task.Run(() =>
            {
                var data = BusinessFactory<ReconcileBusiness>.Instance.FindByAccount(account.Id, year);

                return data.ToList();
            });

            var result = await task;

            this.reconcileGrid.DataSource = result;
        }

        /// <summary>
        /// 载入数据
        /// </summary>
        /// <param name="group"></param>
        /// <param name="year"></param>
        private async void LoadGroupData(Group group, int year)
        {
            var task = Task.Run(() =>
            {
                var items = BusinessFactory<GroupBusiness>.Instance.FindAllItems(group.Id);

                List<Reconcile> data = new List<Reconcile>();
                foreach (var item in items)
                {
                    var reconcile = BusinessFactory<ReconcileBusiness>.Instance.FindByAccount(item.EntityId, year);
                    data.AddRange(reconcile);
                }

                return data;
            });

            var result = await task;
            this.reconcileGrid.DataSource = result;
        }
        #endregion //Function

        #region Method
        /// <summary>
        /// 设置账户
        /// </summary>
        /// <param name="account">回收账户</param>
        public void SetAccount(Account account)
        {
            this.currentAccount = account;
            this.showType = 1;
            this.nowYear = DateTime.Now.Year;

            InitControls();
        }

        /// <summary>
        /// 设置分组
        /// </summary>
        /// <param name="group">分组</param>
        public void SetGroup(Group group)
        {
            this.currentGroup = group;
            this.showType = 2;
            this.nowYear = DateTime.Now.Year;

            InitControls();
        }

        /// <summary>
        /// 清空显示
        /// </summary>
        public void Clear()
        {
            this.cmbYear.EditValue = "";
            this.reconcileGrid.Clear();
        }
        #endregion //Method

        #region Event
        /// <summary>
        /// 年度选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cmbYear.SelectedIndex == -1)
                return;

            int year = Convert.ToInt32(this.cmbYear.SelectedItem.ToString().Substring(0, 4));
            if (this.showType == 1)
                LoadAccountData(this.currentAccount, year);
            else if (this.showType == 2)
                LoadGroupData(this.currentGroup, year);
        }
        #endregion //Event
    }
}
