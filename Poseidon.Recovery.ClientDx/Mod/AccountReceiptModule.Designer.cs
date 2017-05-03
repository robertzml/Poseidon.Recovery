namespace Poseidon.Recovery.ClientDx
{
    partial class AccountReceiptModule
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabInfo = new DevExpress.XtraTab.XtraTabControl();
            this.tabPageBaseInfo = new DevExpress.XtraTab.XtraTabPage();
            this.navFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.commerceAccountMod = new Poseidon.Recovery.ClientDx.CommerceAccountInfo();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.tabPageMeters = new DevExpress.XtraTab.XtraTabPage();
            this.meterGrid = new Poseidon.Recovery.ClientDx.MeterGrid();
            this.tabBusiness = new DevExpress.XtraTab.XtraTabControl();
            this.tabPageSettlement = new DevExpress.XtraTab.XtraTabPage();
            this.settleMod = new Poseidon.Recovery.ClientDx.SettleReceiptModule();
            this.tabPageRecycle = new DevExpress.XtraTab.XtraTabPage();
            this.recycleMod = new Poseidon.Recovery.ClientDx.RecycleReceiptModule();
            this.tabPageMeasure = new DevExpress.XtraTab.XtraTabPage();
            this.measureMod = new Poseidon.Recovery.ClientDx.MeasureReceiptModule();
            this.tabPageReconcile = new DevExpress.XtraTab.XtraTabPage();
            this.reconcileMod = new Poseidon.Recovery.ClientDx.ReconcileReceiptModule();
            this.constructionAccountMod = new Poseidon.Recovery.ClientDx.ConstructionAccountInfo();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabInfo)).BeginInit();
            this.tabInfo.SuspendLayout();
            this.tabPageBaseInfo.SuspendLayout();
            this.navFrame.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            this.navigationPage2.SuspendLayout();
            this.tabPageMeters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabBusiness)).BeginInit();
            this.tabBusiness.SuspendLayout();
            this.tabPageSettlement.SuspendLayout();
            this.tabPageRecycle.SuspendLayout();
            this.tabPageMeasure.SuspendLayout();
            this.tabPageReconcile.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tabInfo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabBusiness, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(919, 645);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabInfo
            // 
            this.tabInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabInfo.Location = new System.Drawing.Point(3, 3);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.SelectedTabPage = this.tabPageBaseInfo;
            this.tabInfo.Size = new System.Drawing.Size(913, 194);
            this.tabInfo.TabIndex = 4;
            this.tabInfo.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPageBaseInfo,
            this.tabPageMeters});
            // 
            // tabPageBaseInfo
            // 
            this.tabPageBaseInfo.Controls.Add(this.navFrame);
            this.tabPageBaseInfo.Name = "tabPageBaseInfo";
            this.tabPageBaseInfo.Size = new System.Drawing.Size(907, 165);
            this.tabPageBaseInfo.Text = "基本信息";
            // 
            // navFrame
            // 
            this.navFrame.AllowTransitionAnimation = DevExpress.Utils.DefaultBoolean.False;
            this.navFrame.Controls.Add(this.navigationPage1);
            this.navFrame.Controls.Add(this.navigationPage2);
            this.navFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navFrame.Location = new System.Drawing.Point(0, 0);
            this.navFrame.Name = "navFrame";
            this.navFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPage[] {
            this.navigationPage1,
            this.navigationPage2});
            this.navFrame.SelectedPage = this.navigationPage2;
            this.navFrame.SelectedPageIndex = 1;
            this.navFrame.Size = new System.Drawing.Size(907, 165);
            this.navFrame.TabIndex = 0;
            this.navFrame.Text = "navigationFrame1";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "navigationPage1";
            this.navigationPage1.Controls.Add(this.commerceAccountMod);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(907, 165);
            // 
            // commerceAccountMod
            // 
            this.commerceAccountMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commerceAccountMod.Location = new System.Drawing.Point(0, 0);
            this.commerceAccountMod.Name = "commerceAccountMod";
            this.commerceAccountMod.Size = new System.Drawing.Size(907, 165);
            this.commerceAccountMod.TabIndex = 0;
            // 
            // navigationPage2
            // 
            this.navigationPage2.Controls.Add(this.constructionAccountMod);
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(907, 165);
            // 
            // tabPageMeters
            // 
            this.tabPageMeters.Controls.Add(this.meterGrid);
            this.tabPageMeters.Name = "tabPageMeters";
            this.tabPageMeters.Size = new System.Drawing.Size(907, 165);
            this.tabPageMeters.Text = "包含表具";
            // 
            // meterGrid
            // 
            this.meterGrid.AllowFilter = false;
            this.meterGrid.AllowGroup = false;
            this.meterGrid.AllowSort = true;
            this.meterGrid.DataSource = null;
            this.meterGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.meterGrid.Editable = false;
            this.meterGrid.EnableMasterView = false;
            this.meterGrid.Location = new System.Drawing.Point(0, 0);
            this.meterGrid.Name = "meterGrid";
            this.meterGrid.ShowAddMenu = false;
            this.meterGrid.ShowFooter = false;
            this.meterGrid.ShowLineNumber = true;
            this.meterGrid.ShowMenu = false;
            this.meterGrid.ShowNavigator = false;
            this.meterGrid.Size = new System.Drawing.Size(907, 165);
            this.meterGrid.TabIndex = 0;
            // 
            // tabBusiness
            // 
            this.tabBusiness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabBusiness.Location = new System.Drawing.Point(3, 203);
            this.tabBusiness.Name = "tabBusiness";
            this.tabBusiness.SelectedTabPage = this.tabPageSettlement;
            this.tabBusiness.Size = new System.Drawing.Size(913, 439);
            this.tabBusiness.TabIndex = 3;
            this.tabBusiness.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPageSettlement,
            this.tabPageRecycle,
            this.tabPageMeasure,
            this.tabPageReconcile});
            // 
            // tabPageSettlement
            // 
            this.tabPageSettlement.Controls.Add(this.settleMod);
            this.tabPageSettlement.Name = "tabPageSettlement";
            this.tabPageSettlement.Size = new System.Drawing.Size(907, 410);
            this.tabPageSettlement.Text = "费用结算";
            // 
            // settleMod
            // 
            this.settleMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settleMod.Editable = true;
            this.settleMod.Location = new System.Drawing.Point(0, 0);
            this.settleMod.Name = "settleMod";
            this.settleMod.Size = new System.Drawing.Size(907, 410);
            this.settleMod.TabIndex = 0;
            // 
            // tabPageRecycle
            // 
            this.tabPageRecycle.Controls.Add(this.recycleMod);
            this.tabPageRecycle.Name = "tabPageRecycle";
            this.tabPageRecycle.Size = new System.Drawing.Size(907, 410);
            this.tabPageRecycle.Text = "费用回收";
            // 
            // recycleMod
            // 
            this.recycleMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recycleMod.Editable = true;
            this.recycleMod.Location = new System.Drawing.Point(0, 0);
            this.recycleMod.Name = "recycleMod";
            this.recycleMod.Size = new System.Drawing.Size(907, 410);
            this.recycleMod.TabIndex = 0;
            // 
            // tabPageMeasure
            // 
            this.tabPageMeasure.Controls.Add(this.measureMod);
            this.tabPageMeasure.Name = "tabPageMeasure";
            this.tabPageMeasure.Size = new System.Drawing.Size(907, 410);
            this.tabPageMeasure.Text = "抄表记录";
            // 
            // measureMod
            // 
            this.measureMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.measureMod.Editable = true;
            this.measureMod.Location = new System.Drawing.Point(0, 0);
            this.measureMod.Name = "measureMod";
            this.measureMod.Size = new System.Drawing.Size(907, 410);
            this.measureMod.TabIndex = 0;
            // 
            // tabPageReconcile
            // 
            this.tabPageReconcile.Controls.Add(this.reconcileMod);
            this.tabPageReconcile.Name = "tabPageReconcile";
            this.tabPageReconcile.Size = new System.Drawing.Size(907, 410);
            this.tabPageReconcile.Text = "财务对账";
            // 
            // reconcileMod
            // 
            this.reconcileMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reconcileMod.Editable = true;
            this.reconcileMod.Location = new System.Drawing.Point(0, 0);
            this.reconcileMod.Name = "reconcileMod";
            this.reconcileMod.Size = new System.Drawing.Size(907, 410);
            this.reconcileMod.TabIndex = 0;
            // 
            // constructionAccountMod
            // 
            this.constructionAccountMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.constructionAccountMod.Location = new System.Drawing.Point(0, 0);
            this.constructionAccountMod.Name = "constructionAccountMod";
            this.constructionAccountMod.Size = new System.Drawing.Size(907, 165);
            this.constructionAccountMod.TabIndex = 0;
            // 
            // AccountReceiptModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AccountReceiptModule";
            this.Size = new System.Drawing.Size(919, 645);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabInfo)).EndInit();
            this.tabInfo.ResumeLayout(false);
            this.tabPageBaseInfo.ResumeLayout(false);
            this.navFrame.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            this.navigationPage2.ResumeLayout(false);
            this.tabPageMeters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabBusiness)).EndInit();
            this.tabBusiness.ResumeLayout(false);
            this.tabPageSettlement.ResumeLayout(false);
            this.tabPageRecycle.ResumeLayout(false);
            this.tabPageMeasure.ResumeLayout(false);
            this.tabPageReconcile.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraTab.XtraTabControl tabBusiness;
        private DevExpress.XtraTab.XtraTabPage tabPageSettlement;
        private DevExpress.XtraTab.XtraTabPage tabPageMeasure;
        private DevExpress.XtraTab.XtraTabPage tabPageRecycle;
        private MeasureReceiptModule measureMod;
        private SettleReceiptModule settleMod;
        private DevExpress.XtraTab.XtraTabControl tabInfo;
        private DevExpress.XtraTab.XtraTabPage tabPageBaseInfo;
        private DevExpress.XtraBars.Navigation.NavigationFrame navFrame;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private DevExpress.XtraTab.XtraTabPage tabPageMeters;
        private MeterGrid meterGrid;
        private CommerceAccountInfo commerceAccountMod;
        private RecycleReceiptModule recycleMod;
        private DevExpress.XtraTab.XtraTabPage tabPageReconcile;
        private ReconcileReceiptModule reconcileMod;
        private ConstructionAccountInfo constructionAccountMod;
    }
}
