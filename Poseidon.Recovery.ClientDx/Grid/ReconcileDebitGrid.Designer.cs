namespace Poseidon.Recovery.ClientDx
{
    partial class ReconcileDebitGrid
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
            this.colSettleId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAccountId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSettleAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFeeType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbFeeType = new DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox();
            this.colUnoffAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFeeType)).BeginInit();
            this.SuspendLayout();
            // 
            // bsEntity
            // 
            this.bsEntity.DataSource = typeof(Poseidon.Recovery.Core.DL.ReconcileDebit);
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
            this.colAccountId,
            this.colSettleId,
            this.colSettleAmount,
            this.colUnoffAmount,
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
            this.dgvEntity.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.dgvEntity_CustomUnboundColumnData);
            this.dgvEntity.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.dgvEntity_CustomColumnDisplayText);
            // 
            // colSettleId
            // 
            this.colSettleId.Caption = "结算周期";
            this.colSettleId.FieldName = "SettleId";
            this.colSettleId.Name = "colSettleId";
            this.colSettleId.OptionsColumn.AllowEdit = false;
            this.colSettleId.Visible = true;
            this.colSettleId.VisibleIndex = 0;
            // 
            // colAmount
            // 
            this.colAmount.Caption = "借方金额";
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", "合计={0:0.##}")});
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 4;
            // 
            // colRemark
            // 
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 5;
            // 
            // colAccountId
            // 
            this.colAccountId.Caption = "账户名称";
            this.colAccountId.FieldName = "AccountId";
            this.colAccountId.Name = "colAccountId";
            this.colAccountId.OptionsColumn.AllowEdit = false;
            // 
            // colSettleAmount
            // 
            this.colSettleAmount.Caption = "结算金额";
            this.colSettleAmount.FieldName = "colSettleAmount";
            this.colSettleAmount.Name = "colSettleAmount";
            this.colSettleAmount.OptionsColumn.AllowEdit = false;
            this.colSettleAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "colSettleAmount", "合计={0:0.##}")});
            this.colSettleAmount.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colSettleAmount.Visible = true;
            this.colSettleAmount.VisibleIndex = 1;
            // 
            // colFeeType
            // 
            this.colFeeType.Caption = "费用类型";
            this.colFeeType.ColumnEdit = this.cmbFeeType;
            this.colFeeType.FieldName = "FeeType";
            this.colFeeType.Name = "colFeeType";
            this.colFeeType.Visible = true;
            this.colFeeType.VisibleIndex = 2;
            // 
            // cmbFeeType
            // 
            this.cmbFeeType.AutoHeight = false;
            this.cmbFeeType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbFeeType.Name = "cmbFeeType";
            // 
            // colUnoffAmount
            // 
            this.colUnoffAmount.Caption = "未核销金额";
            this.colUnoffAmount.FieldName = "colUnoffAmount";
            this.colUnoffAmount.Name = "colUnoffAmount";
            this.colUnoffAmount.OptionsColumn.AllowEdit = false;
            this.colUnoffAmount.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colUnoffAmount.Visible = true;
            this.colUnoffAmount.VisibleIndex = 3;
            // 
            // ReconcileDebitGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ReconcileDebitGrid";
            this.Load += new System.EventHandler(this.ReconcileDebitGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbFeeType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colSettleId;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colAccountId;
        private DevExpress.XtraGrid.Columns.GridColumn colSettleAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colFeeType;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox cmbFeeType;
        private DevExpress.XtraGrid.Columns.GridColumn colUnoffAmount;
    }
}
