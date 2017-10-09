namespace Poseidon.Recovery.ClientDx
{
    partial class ReconcileCreditGrid
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
            this.colRecycleId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRecycleAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnpostAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).BeginInit();
            this.SuspendLayout();
            // 
            // bsEntity
            // 
            this.bsEntity.DataSource = typeof(Poseidon.Recovery.Core.DL.ReconcileCredit);
            // 
            // dgcEntity
            // 
            this.dgcEntity.Size = new System.Drawing.Size(568, 378);
            // 
            // dgvEntity
            // 
            this.dgvEntity.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAccountId,
            this.colRecycleId,
            this.colRecycleAmount,
            this.colUnpostAmount,
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
            // colAccountId
            // 
            this.colAccountId.FieldName = "AccountId";
            this.colAccountId.Name = "colAccountId";
            this.colAccountId.OptionsColumn.AllowEdit = false;
            // 
            // colRecycleId
            // 
            this.colRecycleId.Caption = "回收日期";
            this.colRecycleId.FieldName = "RecycleId";
            this.colRecycleId.Name = "colRecycleId";
            this.colRecycleId.OptionsColumn.AllowEdit = false;
            this.colRecycleId.Visible = true;
            this.colRecycleId.VisibleIndex = 0;
            // 
            // colAmount
            // 
            this.colAmount.Caption = "贷方金额";
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", "合计={0:0.##}")});
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
            // colRecycleAmount
            // 
            this.colRecycleAmount.Caption = "回收金额";
            this.colRecycleAmount.FieldName = "colRecycleAmount";
            this.colRecycleAmount.Name = "colRecycleAmount";
            this.colRecycleAmount.OptionsColumn.AllowEdit = false;
            this.colRecycleAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "colRecycleAmount", "合计={0:0.##}")});
            this.colRecycleAmount.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colRecycleAmount.Visible = true;
            this.colRecycleAmount.VisibleIndex = 1;
            // 
            // colUnpostAmount
            // 
            this.colUnpostAmount.Caption = "未入账金额";
            this.colUnpostAmount.FieldName = "colUnpostAmount";
            this.colUnpostAmount.Name = "colUnpostAmount";
            this.colUnpostAmount.OptionsColumn.AllowEdit = false;
            this.colUnpostAmount.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colUnpostAmount.Visible = true;
            this.colUnpostAmount.VisibleIndex = 2;
            // 
            // ReconcileCreditGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ReconcileCreditGrid";
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colAccountId;
        private DevExpress.XtraGrid.Columns.GridColumn colRecycleId;
        private DevExpress.XtraGrid.Columns.GridColumn colRecycleAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colUnpostAmount;
    }
}
