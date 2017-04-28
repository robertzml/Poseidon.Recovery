namespace Poseidon.Recovery.ClientDx
{
    partial class MeasureRecordGrid
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
            this.cmbEnergyType = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colChargeType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbChargeType = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colMultiple = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIndication = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrevious = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantum = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEnergyType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbChargeType)).BeginInit();
            this.SuspendLayout();
            // 
            // bsEntity
            // 
            this.bsEntity.DataSource = typeof(Poseidon.Recovery.Core.DL.MeasureRecord);
            // 
            // dgcEntity
            // 
            this.dgcEntity.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbEnergyType,
            this.cmbChargeType});
            this.dgcEntity.Size = new System.Drawing.Size(568, 378);
            // 
            // dgvEntity
            // 
            this.dgvEntity.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colMeterName,
            this.colMeterNumber,
            this.colMeterType,
            this.colChargeType,
            this.colMultiple,
            this.colPrevious,
            this.colIndication,
            this.colQuantum,
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
            this.colMeterType.ColumnEdit = this.cmbEnergyType;
            this.colMeterType.FieldName = "MeterType";
            this.colMeterType.Name = "colMeterType";
            this.colMeterType.Visible = true;
            this.colMeterType.VisibleIndex = 2;
            // 
            // cmbEnergyType
            // 
            this.cmbEnergyType.AutoHeight = false;
            this.cmbEnergyType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbEnergyType.Name = "cmbEnergyType";
            // 
            // colChargeType
            // 
            this.colChargeType.ColumnEdit = this.cmbChargeType;
            this.colChargeType.FieldName = "ChargeType";
            this.colChargeType.Name = "colChargeType";
            this.colChargeType.Visible = true;
            this.colChargeType.VisibleIndex = 3;
            // 
            // cmbChargeType
            // 
            this.cmbChargeType.AutoHeight = false;
            this.cmbChargeType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbChargeType.Name = "cmbChargeType";
            // 
            // colMultiple
            // 
            this.colMultiple.FieldName = "Multiple";
            this.colMultiple.Name = "colMultiple";
            this.colMultiple.Visible = true;
            this.colMultiple.VisibleIndex = 4;
            // 
            // colIndication
            // 
            this.colIndication.Caption = "本期数";
            this.colIndication.FieldName = "Indication";
            this.colIndication.Name = "colIndication";
            this.colIndication.Visible = true;
            this.colIndication.VisibleIndex = 6;
            // 
            // colRemark
            // 
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 8;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colPrevious
            // 
            this.colPrevious.Caption = "上期数";
            this.colPrevious.FieldName = "colPrevious";
            this.colPrevious.Name = "colPrevious";
            this.colPrevious.OptionsColumn.AllowEdit = false;
            this.colPrevious.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colPrevious.Visible = true;
            this.colPrevious.VisibleIndex = 5;
            // 
            // colQuantum
            // 
            this.colQuantum.Caption = "用量(度/吨)";
            this.colQuantum.FieldName = "colQuantum";
            this.colQuantum.Name = "colQuantum";
            this.colQuantum.OptionsColumn.AllowEdit = false;
            this.colQuantum.UnboundExpression = "([Indication] - [colPrevious]) * [Multiple]";
            this.colQuantum.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colQuantum.Visible = true;
            this.colQuantum.VisibleIndex = 7;
            // 
            // MeasureRecordGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "MeasureRecordGrid";
            this.Load += new System.EventHandler(this.MeasureRecordGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbEnergyType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbChargeType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colMeterName;
        private DevExpress.XtraGrid.Columns.GridColumn colMeterNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colMeterType;
        private DevExpress.XtraGrid.Columns.GridColumn colChargeType;
        private DevExpress.XtraGrid.Columns.GridColumn colMultiple;
        private DevExpress.XtraGrid.Columns.GridColumn colPrevious;
        private DevExpress.XtraGrid.Columns.GridColumn colIndication;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantum;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cmbEnergyType;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cmbChargeType;
    }
}
