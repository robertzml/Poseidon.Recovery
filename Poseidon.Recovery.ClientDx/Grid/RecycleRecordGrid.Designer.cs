namespace Poseidon.Recovery.ClientDx
{
    partial class RecycleRecordGrid
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
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFeeType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbFeeType = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFeeType)).BeginInit();
            this.SuspendLayout();
            // 
            // bsEntity
            // 
            this.bsEntity.DataSource = typeof(Poseidon.Recovery.Core.DL.RecycleRecord);
            // 
            // dgcEntity
            // 
            this.dgcEntity.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbFeeType});
            this.dgcEntity.Size = new System.Drawing.Size(568, 378);
            // 
            // dgvEntity
            // 
            this.dgvEntity.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colFeeType,
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
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colFeeType
            // 
            this.colFeeType.ColumnEdit = this.cmbFeeType;
            this.colFeeType.FieldName = "FeeType";
            this.colFeeType.Name = "colFeeType";
            this.colFeeType.Visible = true;
            this.colFeeType.VisibleIndex = 1;
            // 
            // cmbFeeType
            // 
            this.cmbFeeType.AutoHeight = false;
            this.cmbFeeType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbFeeType.Name = "cmbFeeType";
            // 
            // colAmount
            // 
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", "合计={0:0.##}")});
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 2;
            // 
            // colRemark
            // 
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 3;
            // 
            // RecycleRecordGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "RecycleRecordGrid";
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFeeType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colFeeType;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cmbFeeType;
    }
}
