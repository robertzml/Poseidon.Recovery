namespace Poseidon.Recovery.ClientDx
{
    partial class RecoveryDataChart
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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView1 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SideBySideBarSeriesView sideBySideBarSeriesView2 = new DevExpress.XtraCharts.SideBySideBarSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.chartMain = new DevExpress.XtraCharts.ChartControl();
            this.bsRecovery = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRecovery)).BeginInit();
            this.SuspendLayout();
            // 
            // chartMain
            // 
            this.chartMain.DataSource = this.bsRecovery;
            xyDiagram1.AxisX.Label.TextPattern = "{A}";
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartMain.Diagram = xyDiagram1;
            this.chartMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartMain.Location = new System.Drawing.Point(0, 0);
            this.chartMain.Name = "chartMain";
            series1.ArgumentDataMember = "BelongDate";
            series1.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            series1.Name = "应收费用(元)";
            series1.ValueDataMembersSerializable = "DueFee";
            sideBySideBarSeriesView1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(80)))), ((int)(((byte)(77)))));
            series1.View = sideBySideBarSeriesView1;
            series2.ArgumentDataMember = "BelongDate";
            series2.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative;
            series2.Name = "已收费用(元)";
            series2.ValueDataMembersSerializable = "PaidFee";
            sideBySideBarSeriesView2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(146)))), ((int)(((byte)(60)))));
            series2.View = sideBySideBarSeriesView2;
            this.chartMain.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1,
        series2};
            this.chartMain.Size = new System.Drawing.Size(628, 406);
            this.chartMain.TabIndex = 0;
            chartTitle1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartTitle1.Visibility = DevExpress.Utils.DefaultBoolean.False;
            this.chartMain.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // bsRecovery
            // 
            this.bsRecovery.DataSource = typeof(Poseidon.Recovery.Core.Utility.RecoveryDataModel);
            // 
            // RecoveryDataChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartMain);
            this.Name = "RecoveryDataChart";
            this.Size = new System.Drawing.Size(628, 406);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(sideBySideBarSeriesView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRecovery)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartMain;
        private System.Windows.Forms.BindingSource bsRecovery;
    }
}
