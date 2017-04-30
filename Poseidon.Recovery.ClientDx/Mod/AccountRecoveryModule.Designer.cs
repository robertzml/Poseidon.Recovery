﻿namespace Poseidon.Recovery.ClientDx
{
    partial class AccountRecoveryModule
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
            this.tabInfo = new DevExpress.XtraTab.XtraTabControl();
            this.tabPageBaseInfo = new DevExpress.XtraTab.XtraTabPage();
            this.navFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.commerceAccountMod = new Poseidon.Recovery.ClientDx.CommerceAccountInfo();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.tabPageMeters = new DevExpress.XtraTab.XtraTabPage();
            this.meterGrid = new Poseidon.Recovery.ClientDx.MeterGrid();
            this.tabMain = new DevExpress.XtraTab.XtraTabControl();
            this.tabPageSummary = new DevExpress.XtraTab.XtraTabPage();
            this.tabPageReceipt = new DevExpress.XtraTab.XtraTabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabBusiness = new DevExpress.XtraTab.XtraTabControl();
            this.tabPageSettle = new DevExpress.XtraTab.XtraTabPage();
            this.tabPageRecycle = new DevExpress.XtraTab.XtraTabPage();
            this.tabPageMeasure = new DevExpress.XtraTab.XtraTabPage();
            this.tabOverview = new DevExpress.XtraTab.XtraTabControl();
            this.tabPageOverview = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.settleReceiptMod = new Poseidon.Recovery.ClientDx.SettleReceiptModule();
            this.recycleReceiptMod = new Poseidon.Recovery.ClientDx.RecycleReceiptModule();
            this.measureReceiptMod = new Poseidon.Recovery.ClientDx.MeasureReceiptModule();
            ((System.ComponentModel.ISupportInitialize)(this.tabInfo)).BeginInit();
            this.tabInfo.SuspendLayout();
            this.tabPageBaseInfo.SuspendLayout();
            this.navFrame.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            this.tabPageMeters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).BeginInit();
            this.tabMain.SuspendLayout();
            this.tabPageSummary.SuspendLayout();
            this.tabPageReceipt.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabBusiness)).BeginInit();
            this.tabBusiness.SuspendLayout();
            this.tabPageSettle.SuspendLayout();
            this.tabPageRecycle.SuspendLayout();
            this.tabPageMeasure.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabOverview)).BeginInit();
            this.tabOverview.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabInfo
            // 
            this.tabInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabInfo.Location = new System.Drawing.Point(3, 3);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.SelectedTabPage = this.tabPageBaseInfo;
            this.tabInfo.Size = new System.Drawing.Size(830, 194);
            this.tabInfo.TabIndex = 5;
            this.tabInfo.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPageBaseInfo,
            this.tabPageMeters});
            // 
            // tabPageBaseInfo
            // 
            this.tabPageBaseInfo.Controls.Add(this.navFrame);
            this.tabPageBaseInfo.Name = "tabPageBaseInfo";
            this.tabPageBaseInfo.Size = new System.Drawing.Size(824, 165);
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
            this.navFrame.SelectedPageIndex = 0;
            this.navFrame.Size = new System.Drawing.Size(824, 165);
            this.navFrame.TabIndex = 0;
            this.navFrame.Text = "navigationFrame1";
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "navigationPage1";
            this.navigationPage1.Controls.Add(this.commerceAccountMod);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(824, 165);
            // 
            // commerceAccountMod
            // 
            this.commerceAccountMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commerceAccountMod.Location = new System.Drawing.Point(0, 0);
            this.commerceAccountMod.Name = "commerceAccountMod";
            this.commerceAccountMod.Size = new System.Drawing.Size(824, 165);
            this.commerceAccountMod.TabIndex = 0;
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "navigationPage2";
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(824, 165);
            // 
            // tabPageMeters
            // 
            this.tabPageMeters.Controls.Add(this.meterGrid);
            this.tabPageMeters.Name = "tabPageMeters";
            this.tabPageMeters.Size = new System.Drawing.Size(830, 165);
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
            this.meterGrid.Size = new System.Drawing.Size(830, 165);
            this.meterGrid.TabIndex = 0;
            // 
            // tabMain
            // 
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedTabPage = this.tabPageSummary;
            this.tabMain.Size = new System.Drawing.Size(842, 570);
            this.tabMain.TabIndex = 6;
            this.tabMain.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPageSummary,
            this.tabPageReceipt});
            // 
            // tabPageSummary
            // 
            this.tabPageSummary.Controls.Add(this.tableLayoutPanel1);
            this.tabPageSummary.Name = "tabPageSummary";
            this.tabPageSummary.Size = new System.Drawing.Size(836, 541);
            this.tabPageSummary.Text = "摘要";
            // 
            // tabPageReceipt
            // 
            this.tabPageReceipt.Controls.Add(this.tabBusiness);
            this.tabPageReceipt.Name = "tabPageReceipt";
            this.tabPageReceipt.Size = new System.Drawing.Size(836, 541);
            this.tabPageReceipt.Text = "单据信息";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tabInfo, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabOverview, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(836, 541);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabBusiness
            // 
            this.tabBusiness.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabBusiness.Location = new System.Drawing.Point(0, 0);
            this.tabBusiness.Name = "tabBusiness";
            this.tabBusiness.SelectedTabPage = this.tabPageSettle;
            this.tabBusiness.Size = new System.Drawing.Size(836, 541);
            this.tabBusiness.TabIndex = 0;
            this.tabBusiness.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPageSettle,
            this.tabPageRecycle,
            this.tabPageMeasure});
            // 
            // tabPageSettle
            // 
            this.tabPageSettle.Controls.Add(this.settleReceiptMod);
            this.tabPageSettle.Name = "tabPageSettle";
            this.tabPageSettle.Size = new System.Drawing.Size(830, 512);
            this.tabPageSettle.Text = "费用结算";
            // 
            // tabPageRecycle
            // 
            this.tabPageRecycle.Controls.Add(this.recycleReceiptMod);
            this.tabPageRecycle.Name = "tabPageRecycle";
            this.tabPageRecycle.Size = new System.Drawing.Size(830, 512);
            this.tabPageRecycle.Text = "费用回收";
            // 
            // tabPageMeasure
            // 
            this.tabPageMeasure.Controls.Add(this.measureReceiptMod);
            this.tabPageMeasure.Name = "tabPageMeasure";
            this.tabPageMeasure.Size = new System.Drawing.Size(830, 512);
            this.tabPageMeasure.Text = "抄表计量";
            // 
            // tabOverview
            // 
            this.tabOverview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabOverview.Location = new System.Drawing.Point(3, 203);
            this.tabOverview.Name = "tabOverview";
            this.tabOverview.SelectedTabPage = this.tabPageOverview;
            this.tabOverview.Size = new System.Drawing.Size(830, 335);
            this.tabOverview.TabIndex = 6;
            this.tabOverview.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPageOverview,
            this.xtraTabPage2});
            // 
            // tabPageOverview
            // 
            this.tabPageOverview.Name = "tabPageOverview";
            this.tabPageOverview.Size = new System.Drawing.Size(824, 306);
            this.tabPageOverview.Text = "账目总览";
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(294, 271);
            this.xtraTabPage2.Text = "xtraTabPage2";
            // 
            // settleReceiptMod
            // 
            this.settleReceiptMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settleReceiptMod.Editable = false;
            this.settleReceiptMod.Location = new System.Drawing.Point(0, 0);
            this.settleReceiptMod.Name = "settleReceiptMod";
            this.settleReceiptMod.Size = new System.Drawing.Size(830, 512);
            this.settleReceiptMod.TabIndex = 0;
            // 
            // recycleReceiptMod
            // 
            this.recycleReceiptMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recycleReceiptMod.Editable = false;
            this.recycleReceiptMod.Location = new System.Drawing.Point(0, 0);
            this.recycleReceiptMod.Name = "recycleReceiptMod";
            this.recycleReceiptMod.Size = new System.Drawing.Size(830, 512);
            this.recycleReceiptMod.TabIndex = 0;
            // 
            // measureReceiptMod
            // 
            this.measureReceiptMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.measureReceiptMod.Editable = false;
            this.measureReceiptMod.Location = new System.Drawing.Point(0, 0);
            this.measureReceiptMod.Name = "measureReceiptMod";
            this.measureReceiptMod.Size = new System.Drawing.Size(830, 512);
            this.measureReceiptMod.TabIndex = 0;
            // 
            // AccountRecoveryModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabMain);
            this.Name = "AccountRecoveryModule";
            this.Size = new System.Drawing.Size(842, 570);
            ((System.ComponentModel.ISupportInitialize)(this.tabInfo)).EndInit();
            this.tabInfo.ResumeLayout(false);
            this.tabPageBaseInfo.ResumeLayout(false);
            this.navFrame.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            this.tabPageMeters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabMain)).EndInit();
            this.tabMain.ResumeLayout(false);
            this.tabPageSummary.ResumeLayout(false);
            this.tabPageReceipt.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabBusiness)).EndInit();
            this.tabBusiness.ResumeLayout(false);
            this.tabPageSettle.ResumeLayout(false);
            this.tabPageRecycle.ResumeLayout(false);
            this.tabPageMeasure.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabOverview)).EndInit();
            this.tabOverview.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTab.XtraTabControl tabInfo;
        private DevExpress.XtraTab.XtraTabPage tabPageBaseInfo;
        private DevExpress.XtraBars.Navigation.NavigationFrame navFrame;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private CommerceAccountInfo commerceAccountMod;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private DevExpress.XtraTab.XtraTabPage tabPageMeters;
        private MeterGrid meterGrid;
        private DevExpress.XtraTab.XtraTabControl tabMain;
        private DevExpress.XtraTab.XtraTabPage tabPageSummary;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraTab.XtraTabControl tabOverview;
        private DevExpress.XtraTab.XtraTabPage tabPageOverview;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage tabPageReceipt;
        private DevExpress.XtraTab.XtraTabControl tabBusiness;
        private DevExpress.XtraTab.XtraTabPage tabPageSettle;
        private SettleReceiptModule settleReceiptMod;
        private DevExpress.XtraTab.XtraTabPage tabPageRecycle;
        private RecycleReceiptModule recycleReceiptMod;
        private DevExpress.XtraTab.XtraTabPage tabPageMeasure;
        private MeasureReceiptModule measureReceiptMod;
    }
}