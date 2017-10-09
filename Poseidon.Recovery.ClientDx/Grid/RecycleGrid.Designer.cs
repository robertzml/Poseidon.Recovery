namespace Poseidon.Recovery.ClientDx
{
    partial class RecycleGrid
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
            this.colRecycleDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsPost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPostAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnPostAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).BeginInit();
            this.SuspendLayout();
            // 
            // bsEntity
            // 
            this.bsEntity.DataSource = typeof(Poseidon.Recovery.Core.DL.Recycle);
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
            this.colRecycleDate,
            this.colTotalAmount,
            this.colPostAmount,
            this.colUnPostAmount,
            this.colIsPost,
            this.colRemark});
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
            // colRecycleDate
            // 
            this.colRecycleDate.FieldName = "RecycleDate";
            this.colRecycleDate.Name = "colRecycleDate";
            this.colRecycleDate.Visible = true;
            this.colRecycleDate.VisibleIndex = 1;
            // 
            // colTotalAmount
            // 
            this.colTotalAmount.FieldName = "TotalAmount";
            this.colTotalAmount.Name = "colTotalAmount";
            this.colTotalAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "TotalAmount", "合计={0:0.##}")});
            this.colTotalAmount.Visible = true;
            this.colTotalAmount.VisibleIndex = 2;
            // 
            // colIsPost
            // 
            this.colIsPost.FieldName = "IsPost";
            this.colIsPost.Name = "colIsPost";
            this.colIsPost.Visible = true;
            this.colIsPost.VisibleIndex = 5;
            // 
            // colRemark
            // 
            this.colRemark.FieldName = "Remark";
            this.colRemark.Name = "colRemark";
            this.colRemark.Visible = true;
            this.colRemark.VisibleIndex = 6;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colPostAmount
            // 
            this.colPostAmount.Caption = "已入账金额";
            this.colPostAmount.FieldName = "PostAmount";
            this.colPostAmount.Name = "colPostAmount";
            this.colPostAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "PostAmount", "合计={0:0.##}")});
            this.colPostAmount.Visible = true;
            this.colPostAmount.VisibleIndex = 3;
            // 
            // colUnPostAmount
            // 
            this.colUnPostAmount.Caption = "未入账金额";
            this.colUnPostAmount.FieldName = "colUnPostAmount";
            this.colUnPostAmount.Name = "colUnPostAmount";
            this.colUnPostAmount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "colUnPostAmount", "合计={0:0.##}")});
            this.colUnPostAmount.UnboundExpression = "[TotalAmount] - [PostAmount]";
            this.colUnPostAmount.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.colUnPostAmount.Visible = true;
            this.colUnPostAmount.VisibleIndex = 4;
            // 
            // RecycleGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "RecycleGrid";
            this.Load += new System.EventHandler(this.RecycleGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colAccountId;
        private DevExpress.XtraGrid.Columns.GridColumn colRecycleDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colIsPost;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colPostAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colUnPostAmount;
    }
}
