namespace Poseidon.Recovery.ClientDx
{
    partial class SettleRecordGrid
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
            this.colMeterName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMeterNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMeterType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbMeterType = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colMultiple = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrevious = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCalQuantum = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMeterType)).BeginInit();
            this.SuspendLayout();
            // 
            // bsEntity
            // 
            this.bsEntity.DataSource = typeof(Poseidon.Recovery.Core.DL.SettleRecord);
            // 
            // dgcEntity
            // 
            this.dgcEntity.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbMeterType});
            this.dgcEntity.Size = new System.Drawing.Size(568, 378);
            // 
            // dgvEntity
            // 
            this.dgvEntity.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMeterName,
            this.colMeterNumber,
            this.colMeterType,
            this.colMultiple,
            this.colPrevious,
            this.colCurrent,
            this.colCalQuantum,
            this.colQuantum,
            this.colUnitPrice,
            this.colCalAmount,
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
            // colMeterName
            // 
            this.colMeterName.FieldName = "MeterName";
            this.colMeterName.Name = "colMeterName";
            this.colMeterName.Visible = true;
            this.colMeterName.VisibleIndex = 0;
            // 
            // colMeterNumber
            // 
            this.colMeterNumber.FieldName = "MeterNumber";
            this.colMeterNumber.Name = "colMeterNumber";
            this.colMeterNumber.Visible = true;
            this.colMeterNumber.VisibleIndex = 1;
            // 
            // colMeterType
            // 
            this.colMeterType.ColumnEdit = this.cmbMeterType;
            this.colMeterType.FieldName = "MeterType";
            this.colMeterType.Name = "colMeterType";
            this.colMeterType.Visible = true;
            this.colMeterType.VisibleIndex = 2;
            // 
            // cmbMeterType
            // 
            this.cmbMeterType.AutoHeight = false;
            this.cmbMeterType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbMeterType.Name = "cmbMeterType";
            // 
            // colMultiple
            // 
            this.colMultiple.FieldName = "Multiple";
            this.colMultiple.Name = "colMultiple";
            this.colMultiple.Visible = true;
            this.colMultiple.VisibleIndex = 3;
            // 
            // colPrevious
            // 
            this.colPrevious.FieldName = "Previous";
            this.colPrevious.Name = "colPrevious";
            this.colPrevious.Visible = true;
            this.colPrevious.VisibleIndex = 4;
            // 
            // colCurrent
            // 
            this.colCurrent.FieldName = "Current";
            this.colCurrent.Name = "colCurrent";
            this.colCurrent.Visible = true;
            this.colCurrent.VisibleIndex = 5;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 8;
            // 
            // colQuantum
            // 
            this.colQuantum.Caption = "用量(度/吨)";
            this.colQuantum.FieldName = "Quantum";
            this.colQuantum.Name = "colQuantum";
            this.colQuantum.Visible = true;
            this.colQuantum.VisibleIndex = 7;
            // 
            // colAmount
            // 
            this.colAmount.Caption = "金额(元)";
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", "合计={0:0.##}")});
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 10;
            // 
            // colRemark
            // 
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 11;
            // 
            // colCalAmount
            // 
            this.colCalAmount.Caption = "计算金额";
            this.colCalAmount.FieldName = "colCalAmount";
            this.colCalAmount.Name = "colCalAmount";
            this.colCalAmount.OptionsColumn.AllowEdit = false;
            this.colCalAmount.UnboundExpression = "([Current] - [Previous]) * [Multiple] * [UnitPrice]";
            this.colCalAmount.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.colCalAmount.Visible = true;
            this.colCalAmount.VisibleIndex = 9;
            // 
            // colCalQuantum
            // 
            this.colCalQuantum.Caption = "计算用量";
            this.colCalQuantum.FieldName = "colCalQuantum";
            this.colCalQuantum.Name = "colCalQuantum";
            this.colCalQuantum.OptionsColumn.AllowEdit = false;
            this.colCalQuantum.UnboundExpression = "([Current] - [Previous]) * [Multiple]";
            this.colCalQuantum.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colCalQuantum.Visible = true;
            this.colCalQuantum.VisibleIndex = 6;
            // 
            // SettleRecordGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "SettleRecordGrid";
            this.Load += new System.EventHandler(this.SettleRecordGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbMeterType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colMeterName;
        private DevExpress.XtraGrid.Columns.GridColumn colMeterNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colMeterType;
        private DevExpress.XtraGrid.Columns.GridColumn colMultiple;
        private DevExpress.XtraGrid.Columns.GridColumn colPrevious;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrent;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantum;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cmbMeterType;
        private DevExpress.XtraGrid.Columns.GridColumn colCalQuantum;
        private DevExpress.XtraGrid.Columns.GridColumn colCalAmount;
    }
}
