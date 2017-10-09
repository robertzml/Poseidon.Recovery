namespace Poseidon.Recovery.ClientDx
{
    partial class SettleGrid
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
            this.colPeriod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSettleDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPreviousDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCurrentDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsFree = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsWriteOff = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOffAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnOffAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).BeginInit();
            this.SuspendLayout();
            // 
            // bsEntity
            // 
            this.bsEntity.DataSource = typeof(Poseidon.Recovery.Core.DL.Settle);
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
            this.colPeriod,
            this.colSettleDate,
            this.colPreviousDate,
            this.colCurrentDate,
            this.colTotalAmount,
            this.colOffAmount,
            this.colUnOffAmount,
            this.colIsFree,
            this.colIsWriteOff,
            this.colRemark,
            this.colStatus});
            this.dgvEntity.IndicatorWidth = 40;
            this.dgvEntity.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvEntity.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.dgvEntity.OptionsBehavior.Editable = false;
            this.dgvEntity.OptionsDetail.EnableMasterViewMode = false;
            this.dgvEntity.OptionsView.EnableAppearanceEvenRow = true;
            this.dgvEntity.OptionsView.EnableAppearanceOddRow = true;
            this.dgvEntity.OptionsView.ShowGroupPanel = false;
            this.dgvEntity.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.dgvEntity_CustomColumnDisplayText);
            // 
            // colAccountId
            // 
            this.colAccountId.Caption = "账户名称";
            this.colAccountId.FieldName = "AccountId";
            this.colAccountId.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.colAccountId.Name = "colAccountId";
            this.colAccountId.Visible = true;
            this.colAccountId.VisibleIndex = 0;
            // 
            // colPeriod
            // 
            this.colPeriod.FieldName = "Period";
            this.colPeriod.Name = "colPeriod";
            this.colPeriod.Visible = true;
            this.colPeriod.VisibleIndex = 1;
            // 
            // colSettleDate
            // 
            this.colSettleDate.FieldName = "SettleDate";
            this.colSettleDate.Name = "colSettleDate";
            this.colSettleDate.Visible = true;
            this.colSettleDate.VisibleIndex = 2;
            // 
            // colPreviousDate
            // 
            this.colPreviousDate.FieldName = "PreviousDate";
            this.colPreviousDate.Name = "colPreviousDate";
            this.colPreviousDate.Visible = true;
            this.colPreviousDate.VisibleIndex = 3;
            // 
            // colCurrentDate
            // 
            this.colCurrentDate.FieldName = "CurrentDate";
            this.colCurrentDate.Name = "colCurrentDate";
            this.colCurrentDate.Visible = true;
            this.colCurrentDate.VisibleIndex = 4;
            // 
            // colTotalAmount
            // 
            this.colTotalAmount.FieldName = "TotalAmount";
            this.colTotalAmount.Name = "colTotalAmount";
            this.colTotalAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalAmount", "合计={0:0.##}")});
            this.colTotalAmount.Visible = true;
            this.colTotalAmount.VisibleIndex = 5;
            // 
            // colIsFree
            // 
            this.colIsFree.FieldName = "IsFree";
            this.colIsFree.Name = "colIsFree";
            this.colIsFree.Visible = true;
            this.colIsFree.VisibleIndex = 8;
            // 
            // colIsWriteOff
            // 
            this.colIsWriteOff.FieldName = "IsWriteOff";
            this.colIsWriteOff.Name = "colIsWriteOff";
            this.colIsWriteOff.Visible = true;
            this.colIsWriteOff.VisibleIndex = 9;
            // 
            // colRemark
            // 
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 10;
            // 
            // colStatus
            // 
            this.colStatus.FieldName = "Status";
            this.colStatus.Name = "colStatus";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colOffAmount
            // 
            this.colOffAmount.Caption = "已核销金额";
            this.colOffAmount.FieldName = "OffAmount";
            this.colOffAmount.Name = "colOffAmount";
            this.colOffAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OffAmount", "合计={0:0.##}")});
            this.colOffAmount.Visible = true;
            this.colOffAmount.VisibleIndex = 6;
            // 
            // colUnOffAmount
            // 
            this.colUnOffAmount.Caption = "未核销金额";
            this.colUnOffAmount.FieldName = "colUnOffAmount";
            this.colUnOffAmount.Name = "colUnOffAmount";
            this.colUnOffAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "colUnOffAmount", "合计={0:0.##}")});
            this.colUnOffAmount.UnboundExpression = "[TotalAmount] - [OffAmount]";
            this.colUnOffAmount.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colUnOffAmount.Visible = true;
            this.colUnOffAmount.VisibleIndex = 7;
            // 
            // SettleGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "SettleGrid";
            this.Load += new System.EventHandler(this.SettleGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colAccountId;
        private DevExpress.XtraGrid.Columns.GridColumn colPeriod;
        private DevExpress.XtraGrid.Columns.GridColumn colSettleDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPreviousDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrentDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colIsFree;
        private DevExpress.XtraGrid.Columns.GridColumn colIsWriteOff;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colOffAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colUnOffAmount;
    }
}
