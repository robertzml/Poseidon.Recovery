namespace Poseidon.Recovery.ClientDx
{
    partial class ReconcileGrid
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
            this.colAccountId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReconcileDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCertificateId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCertificateNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSummary = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).BeginInit();
            this.SuspendLayout();
            // 
            // bsEntity
            // 
            this.bsEntity.DataSource = typeof(Poseidon.Recovery.Core.DL.Reconcile);
            // 
            // dgcEntity
            // 
            this.dgcEntity.Size = new System.Drawing.Size(568, 378);
            // 
            // dgvEntity
            // 
            this.dgvEntity.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colAccountId,
            this.colReconcileDate,
            this.colCertificateId,
            this.colCertificateNumber,
            this.colSummary,
            this.colAmount,
            this.colRemark});
            this.dgvEntity.IndicatorWidth = 40;
            this.dgvEntity.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvEntity.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvEntity.OptionsBehavior.Editable = false;
            this.dgvEntity.OptionsDetail.EnableMasterViewMode = false;
            this.dgvEntity.OptionsView.EnableAppearanceEvenRow = true;
            this.dgvEntity.OptionsView.EnableAppearanceOddRow = true;
            this.dgvEntity.OptionsView.ShowGroupPanel = false;
            // 
            // colAccountId
            // 
            this.colAccountId.FieldName = "AccountId";
            this.colAccountId.Name = "colAccountId";
            // 
            // colReconcileDate
            // 
            this.colReconcileDate.FieldName = "ReconcileDate";
            this.colReconcileDate.Name = "colReconcileDate";
            this.colReconcileDate.Visible = true;
            this.colReconcileDate.VisibleIndex = 0;
            // 
            // colCertificateId
            // 
            this.colCertificateId.FieldName = "CertificateId";
            this.colCertificateId.Name = "colCertificateId";
            // 
            // colCertificateNumber
            // 
            this.colCertificateNumber.FieldName = "CertificateNumber";
            this.colCertificateNumber.Name = "colCertificateNumber";
            this.colCertificateNumber.Visible = true;
            this.colCertificateNumber.VisibleIndex = 1;
            // 
            // colSummary
            // 
            this.colSummary.FieldName = "Summary";
            this.colSummary.Name = "colSummary";
            this.colSummary.Visible = true;
            this.colSummary.VisibleIndex = 2;
            // 
            // colAmount
            // 
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 3;
            // 
            // colRemark
            // 
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 4;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // ReconcileGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ReconcileGrid";
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountId;
        private DevExpress.XtraGrid.Columns.GridColumn colReconcileDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCertificateId;
        private DevExpress.XtraGrid.Columns.GridColumn colCertificateNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colSummary;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
    }
}
