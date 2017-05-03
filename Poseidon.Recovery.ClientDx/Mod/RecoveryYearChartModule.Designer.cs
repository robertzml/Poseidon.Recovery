namespace Poseidon.Recovery.ClientDx
{
    partial class RecoveryYearChartModule
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
            this.recoveryChart = new Poseidon.Recovery.ClientDx.RecoveryDataChart();
            this.SuspendLayout();
            // 
            // recoveryChart
            // 
            this.recoveryChart.DataSource = null;
            this.recoveryChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recoveryChart.Location = new System.Drawing.Point(0, 0);
            this.recoveryChart.Name = "recoveryChart";
            this.recoveryChart.Size = new System.Drawing.Size(546, 405);
            this.recoveryChart.TabIndex = 0;
            // 
            // ReconcileYearChartModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.recoveryChart);
            this.Name = "ReconcileYearChartModule";
            this.Size = new System.Drawing.Size(546, 405);
            this.ResumeLayout(false);

        }

        #endregion

        private RecoveryDataChart recoveryChart;
    }
}
