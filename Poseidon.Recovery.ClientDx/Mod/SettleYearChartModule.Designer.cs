namespace Poseidon.Recovery.ClientDx
{
    partial class SettleYearChartModule
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
            this.settleChart = new Poseidon.Recovery.ClientDx.SettleDataChart();
            this.SuspendLayout();
            // 
            // settleChart
            // 
            this.settleChart.DataSource = null;
            this.settleChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settleChart.Location = new System.Drawing.Point(0, 0);
            this.settleChart.Name = "settleChart";
            this.settleChart.Size = new System.Drawing.Size(625, 385);
            this.settleChart.TabIndex = 0;
            // 
            // SettleYearChartModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.settleChart);
            this.Name = "SettleYearChartModule";
            this.Size = new System.Drawing.Size(625, 385);
            this.ResumeLayout(false);

        }

        #endregion

        private SettleDataChart settleChart;
    }
}
