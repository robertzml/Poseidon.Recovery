﻿namespace Poseidon.Recovery.ClientDx
{
    partial class AccountPieChart
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
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.PieSeriesView pieSeriesView1 = new DevExpress.XtraCharts.PieSeriesView();
            DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
            this.chartMain = new DevExpress.XtraCharts.ChartControl();
            this.bsAccountData = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAccountData)).BeginInit();
            this.SuspendLayout();
            // 
            // chartMain
            // 
            this.chartMain.DataSource = this.bsAccountData;
            this.chartMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartMain.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center;
            this.chartMain.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside;
            this.chartMain.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
            this.chartMain.Location = new System.Drawing.Point(0, 0);
            this.chartMain.Name = "chartMain";
            series1.ArgumentDataMember = "AccountName";
            series1.LegendTextPattern = "{A}{VP:0.00%}";
            series1.Name = "Series 1";
            series1.ValueDataMembersSerializable = "Amount";
            series1.View = pieSeriesView1;
            this.chartMain.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartMain.Size = new System.Drawing.Size(546, 393);
            this.chartMain.TabIndex = 0;
            chartTitle1.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartMain.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle1});
            // 
            // bsAccountData
            // 
            this.bsAccountData.DataSource = typeof(Poseidon.Recovery.Core.Utility.AccountDataModel);
            // 
            // AccountPieChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartMain);
            this.Name = "AccountPieChart";
            this.Size = new System.Drawing.Size(546, 393);
            ((System.ComponentModel.ISupportInitialize)(pieSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAccountData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartMain;
        private System.Windows.Forms.BindingSource bsAccountData;
    }
}
