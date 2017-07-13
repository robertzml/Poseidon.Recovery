namespace Poseidon.Recovery.ClientDx
{
    partial class FrmAccountManage
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.btnSetMeter = new DevExpress.XtraEditors.SimpleButton();
            this.btnEdit = new DevExpress.XtraEditors.SimpleButton();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.tabAccount = new DevExpress.XtraTab.XtraTabControl();
            this.tabPageCommerce = new DevExpress.XtraTab.XtraTabPage();
            this.commerceAccountGrid = new Poseidon.Recovery.ClientDx.CommerceAccountGrid();
            this.tabPageConstruction = new DevExpress.XtraTab.XtraTabPage();
            this.constructionAccountGrid = new Poseidon.Recovery.ClientDx.ConstructionAccountGrid();
            this.btnSetAttachment = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabAccount)).BeginInit();
            this.tabAccount.SuspendLayout();
            this.tabPageCommerce.SuspendLayout();
            this.tabPageConstruction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.groupControl2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(860, 529);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.layoutControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(3, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(854, 134);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "操作";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.btnSetAttachment);
            this.layoutControl1.Controls.Add(this.btnSetMeter);
            this.layoutControl1.Controls.Add(this.btnEdit);
            this.layoutControl1.Controls.Add(this.btnAdd);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 21);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(850, 111);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // btnSetMeter
            // 
            this.btnSetMeter.Location = new System.Drawing.Point(574, 12);
            this.btnSetMeter.Name = "btnSetMeter";
            this.btnSetMeter.Size = new System.Drawing.Size(264, 22);
            this.btnSetMeter.StyleController = this.layoutControl1;
            this.btnSetMeter.TabIndex = 7;
            this.btnSetMeter.Text = "设置表具";
            this.btnSetMeter.Click += new System.EventHandler(this.btnSetMeter_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(303, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(267, 22);
            this.btnEdit.StyleController = this.layoutControl1;
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "编辑账户";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(287, 22);
            this.btnAdd.StyleController = this.layoutControl1;
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "新增账户";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.layoutControlGroup1.Size = new System.Drawing.Size(850, 111);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnAdd;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(291, 26);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnEdit;
            this.layoutControlItem2.Location = new System.Drawing.Point(291, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(271, 91);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnSetMeter;
            this.layoutControlItem3.Location = new System.Drawing.Point(562, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(268, 91);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.tabAccount);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(3, 143);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(854, 383);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "回收账户列表";
            // 
            // tabAccount
            // 
            this.tabAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabAccount.Location = new System.Drawing.Point(2, 21);
            this.tabAccount.Name = "tabAccount";
            this.tabAccount.SelectedTabPage = this.tabPageCommerce;
            this.tabAccount.Size = new System.Drawing.Size(850, 360);
            this.tabAccount.TabIndex = 0;
            this.tabAccount.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPageCommerce,
            this.tabPageConstruction});
            // 
            // tabPageCommerce
            // 
            this.tabPageCommerce.Controls.Add(this.commerceAccountGrid);
            this.tabPageCommerce.Name = "tabPageCommerce";
            this.tabPageCommerce.Size = new System.Drawing.Size(844, 331);
            this.tabPageCommerce.Text = "经营类账户";
            // 
            // commerceAccountGrid
            // 
            this.commerceAccountGrid.AllowFilter = true;
            this.commerceAccountGrid.AllowGroup = false;
            this.commerceAccountGrid.AllowSort = true;
            this.commerceAccountGrid.DataSource = null;
            this.commerceAccountGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commerceAccountGrid.Editable = false;
            this.commerceAccountGrid.EnableMasterView = false;
            this.commerceAccountGrid.EnableMultiSelect = false;
            this.commerceAccountGrid.Location = new System.Drawing.Point(0, 0);
            this.commerceAccountGrid.Name = "commerceAccountGrid";
            this.commerceAccountGrid.ShowAddMenu = false;
            this.commerceAccountGrid.ShowFooter = false;
            this.commerceAccountGrid.ShowLineNumber = true;
            this.commerceAccountGrid.ShowMenu = false;
            this.commerceAccountGrid.ShowNavigator = false;
            this.commerceAccountGrid.Size = new System.Drawing.Size(844, 331);
            this.commerceAccountGrid.TabIndex = 0;
            // 
            // tabPageConstruction
            // 
            this.tabPageConstruction.Controls.Add(this.constructionAccountGrid);
            this.tabPageConstruction.Name = "tabPageConstruction";
            this.tabPageConstruction.Size = new System.Drawing.Size(844, 331);
            this.tabPageConstruction.Text = "工程类账户";
            // 
            // constructionAccountGrid
            // 
            this.constructionAccountGrid.AllowFilter = true;
            this.constructionAccountGrid.AllowGroup = true;
            this.constructionAccountGrid.AllowSort = true;
            this.constructionAccountGrid.DataSource = null;
            this.constructionAccountGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.constructionAccountGrid.Editable = false;
            this.constructionAccountGrid.EnableMasterView = false;
            this.constructionAccountGrid.EnableMultiSelect = false;
            this.constructionAccountGrid.Location = new System.Drawing.Point(0, 0);
            this.constructionAccountGrid.Name = "constructionAccountGrid";
            this.constructionAccountGrid.ShowAddMenu = false;
            this.constructionAccountGrid.ShowFooter = false;
            this.constructionAccountGrid.ShowLineNumber = true;
            this.constructionAccountGrid.ShowMenu = false;
            this.constructionAccountGrid.ShowNavigator = false;
            this.constructionAccountGrid.Size = new System.Drawing.Size(844, 331);
            this.constructionAccountGrid.TabIndex = 0;
            // 
            // btnSetAttachment
            // 
            this.btnSetAttachment.Location = new System.Drawing.Point(12, 38);
            this.btnSetAttachment.Name = "btnSetAttachment";
            this.btnSetAttachment.Size = new System.Drawing.Size(287, 22);
            this.btnSetAttachment.StyleController = this.layoutControl1;
            this.btnSetAttachment.TabIndex = 8;
            this.btnSetAttachment.Text = "设置附件";
            this.btnSetAttachment.Click += new System.EventHandler(this.btnSetAttachment_Click);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnSetAttachment;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(291, 65);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // FrmAccountManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 529);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmAccountManage";
            this.Text = "回收账户管理";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabAccount)).EndInit();
            this.tabAccount.ResumeLayout(false);
            this.tabPageCommerce.ResumeLayout(false);
            this.tabPageConstruction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton btnEdit;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton btnSetMeter;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraTab.XtraTabControl tabAccount;
        private DevExpress.XtraTab.XtraTabPage tabPageCommerce;
        private CommerceAccountGrid commerceAccountGrid;
        private DevExpress.XtraTab.XtraTabPage tabPageConstruction;
        private ConstructionAccountGrid constructionAccountGrid;
        private DevExpress.XtraEditors.SimpleButton btnSetAttachment;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}