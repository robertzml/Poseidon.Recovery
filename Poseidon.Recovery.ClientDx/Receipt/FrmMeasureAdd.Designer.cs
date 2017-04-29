namespace Poseidon.Recovery.ClientDx
{
    partial class FrmMeasureAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.luPrevious = new DevExpress.XtraEditors.LookUpEdit();
            this.bsMeasure = new System.Windows.Forms.BindingSource(this.components);
            this.txtRemark = new DevExpress.XtraEditors.MemoEdit();
            this.dpMeasureDate = new DevExpress.XtraEditors.DateEdit();
            this.txtAccountName = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.measureRecordGrid = new Poseidon.Recovery.ClientDx.MeasureRecordGrid();
            ((System.ComponentModel.ISupportInitialize)(this.plFill)).BeginInit();
            this.plFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plBottom)).BeginInit();
            this.plBottom.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luPrevious.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMeasure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpMeasureDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpMeasureDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(687, 15);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(578, 15);
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // plFill
            // 
            this.plFill.Appearance.BackColor = System.Drawing.Color.White;
            this.plFill.Appearance.Options.UseBackColor = true;
            this.plFill.Controls.Add(this.tableLayoutPanel1);
            this.plFill.Size = new System.Drawing.Size(784, 481);
            // 
            // plBottom
            // 
            this.plBottom.Appearance.BackColor = System.Drawing.Color.White;
            this.plBottom.Appearance.Options.UseBackColor = true;
            this.plBottom.Location = new System.Drawing.Point(0, 481);
            this.plBottom.Size = new System.Drawing.Size(784, 60);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 481);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(778, 154);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "抄表信息";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.luPrevious);
            this.layoutControl1.Controls.Add(this.txtRemark);
            this.layoutControl1.Controls.Add(this.dpMeasureDate);
            this.layoutControl1.Controls.Add(this.txtAccountName);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 21);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(774, 131);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // luPrevious
            // 
            this.luPrevious.Location = new System.Drawing.Point(63, 99);
            this.luPrevious.Name = "luPrevious";
            this.luPrevious.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luPrevious.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 21, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MeasureDate", "抄表日期", 85, DevExpress.Utils.FormatType.DateTime, "yyyy/M/d", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Remark", "备注", 51, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.luPrevious.Properties.DataSource = this.bsMeasure;
            this.luPrevious.Properties.DisplayFormat.FormatString = "d";
            this.luPrevious.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.luPrevious.Properties.DisplayMember = "MeasureDate";
            this.luPrevious.Properties.NullText = "请选择";
            this.luPrevious.Properties.ValueMember = "Id";
            this.luPrevious.Size = new System.Drawing.Size(699, 20);
            this.luPrevious.StyleController = this.layoutControl1;
            this.luPrevious.TabIndex = 7;
            this.luPrevious.EditValueChanged += new System.EventHandler(this.luPrevious_EditValueChanged);
            // 
            // bsMeasure
            // 
            this.bsMeasure.DataSource = typeof(Poseidon.Recovery.Core.DL.Measure);
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(63, 36);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(699, 59);
            this.txtRemark.StyleController = this.layoutControl1;
            this.txtRemark.TabIndex = 6;
            // 
            // dpMeasureDate
            // 
            this.dpMeasureDate.EditValue = null;
            this.dpMeasureDate.Location = new System.Drawing.Point(439, 12);
            this.dpMeasureDate.Name = "dpMeasureDate";
            this.dpMeasureDate.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dpMeasureDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dpMeasureDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dpMeasureDate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dpMeasureDate.Size = new System.Drawing.Size(323, 20);
            this.dpMeasureDate.StyleController = this.layoutControl1;
            this.dpMeasureDate.TabIndex = 5;
            // 
            // txtAccountName
            // 
            this.txtAccountName.Location = new System.Drawing.Point(63, 12);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Properties.Appearance.BackColor = System.Drawing.Color.Lavender;
            this.txtAccountName.Properties.Appearance.Options.UseBackColor = true;
            this.txtAccountName.Properties.ReadOnly = true;
            this.txtAccountName.Size = new System.Drawing.Size(321, 20);
            this.txtAccountName.StyleController = this.layoutControl1;
            this.txtAccountName.TabIndex = 4;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(774, 131);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtAccountName;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(376, 24);
            this.layoutControlItem1.Text = "账户名称";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.dpMeasureDate;
            this.layoutControlItem2.Location = new System.Drawing.Point(376, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(378, 24);
            this.layoutControlItem2.Text = "抄表日期";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtRemark;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(754, 63);
            this.layoutControlItem3.Text = "备注";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(48, 14);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.luPrevious;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 87);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(754, 24);
            this.layoutControlItem4.Text = "上期记录";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(48, 14);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.measureRecordGrid);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(3, 163);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(778, 315);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "抄表记录";
            // 
            // measureRecordGrid
            // 
            this.measureRecordGrid.AllowFilter = false;
            this.measureRecordGrid.AllowGroup = false;
            this.measureRecordGrid.AllowSort = false;
            this.measureRecordGrid.DataSource = null;
            this.measureRecordGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.measureRecordGrid.Editable = true;
            this.measureRecordGrid.EnableMasterView = false;
            this.measureRecordGrid.Location = new System.Drawing.Point(2, 21);
            this.measureRecordGrid.Name = "measureRecordGrid";
            this.measureRecordGrid.ShowAddMenu = false;
            this.measureRecordGrid.ShowFooter = false;
            this.measureRecordGrid.ShowLineNumber = true;
            this.measureRecordGrid.ShowMenu = false;
            this.measureRecordGrid.ShowNavigator = true;
            this.measureRecordGrid.ShowPrevious = true;
            this.measureRecordGrid.Size = new System.Drawing.Size(774, 292);
            this.measureRecordGrid.TabIndex = 0;
            // 
            // FrmMeasureAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 541);
            this.Name = "FrmMeasureAdd";
            this.Text = "抄表登记";
            ((System.ComponentModel.ISupportInitialize)(this.plFill)).EndInit();
            this.plFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plBottom)).EndInit();
            this.plBottom.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.luPrevious.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMeasure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpMeasureDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dpMeasureDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.DateEdit dpMeasureDate;
        private DevExpress.XtraEditors.TextEdit txtAccountName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.MemoEdit txtRemark;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private MeasureRecordGrid measureRecordGrid;
        private DevExpress.XtraEditors.LookUpEdit luPrevious;
        private System.Windows.Forms.BindingSource bsMeasure;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}