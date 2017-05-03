namespace Poseidon.Recovery.ClientDx
{
    partial class ConstructionAccountGrid
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
            this.colConstructionCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colConstructionName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChargeType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShortName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTicketName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOpenYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCloseYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContract = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colParentId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).BeginInit();
            this.SuspendLayout();
            // 
            // bsEntity
            // 
            this.bsEntity.DataSource = typeof(Poseidon.Recovery.Core.DL.ConstructionAccount);
            // 
            // dgcEntity
            // 
            this.dgcEntity.Size = new System.Drawing.Size(568, 378);
            // 
            // dgvEntity
            // 
            this.dgvEntity.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName,
            this.colShortName,
            this.colParentId,
            this.colConstructionCompany,
            this.colConstructionName,
            this.colChargeType,
            this.colTicketName,
            this.colOpenYear,
            this.colCloseYear,
            this.colContract,
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
            // colConstructionCompany
            // 
            this.colConstructionCompany.FieldName = "ConstructionCompany";
            this.colConstructionCompany.Name = "colConstructionCompany";
            this.colConstructionCompany.Visible = true;
            this.colConstructionCompany.VisibleIndex = 3;
            // 
            // colConstructionName
            // 
            this.colConstructionName.FieldName = "ConstructionName";
            this.colConstructionName.Name = "colConstructionName";
            this.colConstructionName.Visible = true;
            this.colConstructionName.VisibleIndex = 4;
            // 
            // colChargeType
            // 
            this.colChargeType.FieldName = "ChargeType";
            this.colChargeType.Name = "colChargeType";
            this.colChargeType.Visible = true;
            this.colChargeType.VisibleIndex = 5;
            // 
            // colShortName
            // 
            this.colShortName.FieldName = "ShortName";
            this.colShortName.Name = "colShortName";
            this.colShortName.Visible = true;
            this.colShortName.VisibleIndex = 1;
            // 
            // colTicketName
            // 
            this.colTicketName.FieldName = "TicketName";
            this.colTicketName.Name = "colTicketName";
            this.colTicketName.Visible = true;
            this.colTicketName.VisibleIndex = 6;
            // 
            // colOpenYear
            // 
            this.colOpenYear.FieldName = "OpenYear";
            this.colOpenYear.Name = "colOpenYear";
            this.colOpenYear.Visible = true;
            this.colOpenYear.VisibleIndex = 7;
            // 
            // colCloseYear
            // 
            this.colCloseYear.FieldName = "CloseYear";
            this.colCloseYear.Name = "colCloseYear";
            this.colCloseYear.Visible = true;
            this.colCloseYear.VisibleIndex = 8;
            // 
            // colContract
            // 
            this.colContract.Caption = "联系方式";
            this.colContract.FieldName = "Contact";
            this.colContract.Name = "colContract";
            this.colContract.Visible = true;
            this.colContract.VisibleIndex = 9;
            // 
            // colParentId
            // 
            this.colParentId.Caption = "父账户";
            this.colParentId.FieldName = "ParentId";
            this.colParentId.Name = "colParentId";
            this.colParentId.Visible = true;
            this.colParentId.VisibleIndex = 2;
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
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
            this.colStatus.Visible = true;
            this.colStatus.VisibleIndex = 11;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // ConstructionAccountGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ConstructionAccountGrid";
            ((System.ComponentModel.ISupportInitialize)(this.bsEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgcEntity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn colConstructionCompany;
        private DevExpress.XtraGrid.Columns.GridColumn colConstructionName;
        private DevExpress.XtraGrid.Columns.GridColumn colChargeType;
        private DevExpress.XtraGrid.Columns.GridColumn colShortName;
        private DevExpress.XtraGrid.Columns.GridColumn colTicketName;
        private DevExpress.XtraGrid.Columns.GridColumn colOpenYear;
        private DevExpress.XtraGrid.Columns.GridColumn colCloseYear;
        private DevExpress.XtraGrid.Columns.GridColumn colContract;
        private DevExpress.XtraGrid.Columns.GridColumn colParentId;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colRemark;
        private DevExpress.XtraGrid.Columns.GridColumn colStatus;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
    }
}
