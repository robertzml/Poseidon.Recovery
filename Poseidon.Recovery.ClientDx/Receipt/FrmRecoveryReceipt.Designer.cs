namespace Poseidon.Recovery.ClientDx
{
    partial class FrmRecoveryReceipt
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.tabAccount = new DevExpress.XtraTab.XtraTabControl();
            this.tabPageCommerce = new DevExpress.XtraTab.XtraTabPage();
            this.commerceAccountTree = new Poseidon.Winform.Core.GroupChildrenTree();
            this.tabPageConstruction = new DevExpress.XtraTab.XtraTabPage();
            this.accountReceiptMod = new Poseidon.Recovery.ClientDx.AccountReceiptModule();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabAccount)).BeginInit();
            this.tabAccount.SuspendLayout();
            this.tabPageCommerce.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.tabAccount);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.accountReceiptMod);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(869, 526);
            this.splitContainerControl1.SplitterPosition = 190;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // tabAccount
            // 
            this.tabAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabAccount.Location = new System.Drawing.Point(0, 0);
            this.tabAccount.Name = "tabAccount";
            this.tabAccount.SelectedTabPage = this.tabPageCommerce;
            this.tabAccount.Size = new System.Drawing.Size(190, 526);
            this.tabAccount.TabIndex = 1;
            this.tabAccount.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tabPageCommerce,
            this.tabPageConstruction});
            // 
            // tabPageCommerce
            // 
            this.tabPageCommerce.Controls.Add(this.commerceAccountTree);
            this.tabPageCommerce.Name = "tabPageCommerce";
            this.tabPageCommerce.Size = new System.Drawing.Size(184, 497);
            this.tabPageCommerce.Text = "经营类账户";
            // 
            // commerceAccountTree
            // 
            this.commerceAccountTree.CascadeEntity = false;
            this.commerceAccountTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commerceAccountTree.Location = new System.Drawing.Point(0, 0);
            this.commerceAccountTree.Name = "commerceAccountTree";
            this.commerceAccountTree.ShowFindPanel = false;
            this.commerceAccountTree.Size = new System.Drawing.Size(184, 497);
            this.commerceAccountTree.TabIndex = 0;
            this.commerceAccountTree.EntitySelected += new System.EventHandler(this.commerceAccountTree_EntitySelected);
            // 
            // tabPageConstruction
            // 
            this.tabPageConstruction.Name = "tabPageConstruction";
            this.tabPageConstruction.Size = new System.Drawing.Size(184, 497);
            this.tabPageConstruction.Text = "工程类账户";
            // 
            // accountReceiptMod
            // 
            this.accountReceiptMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountReceiptMod.Location = new System.Drawing.Point(0, 0);
            this.accountReceiptMod.Name = "accountReceiptMod";
            this.accountReceiptMod.Size = new System.Drawing.Size(674, 526);
            this.accountReceiptMod.TabIndex = 0;
            // 
            // FrmRecoveryReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 526);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FrmRecoveryReceipt";
            this.Text = "回收管理";
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabAccount)).EndInit();
            this.tabAccount.ResumeLayout(false);
            this.tabPageCommerce.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private Winform.Core.GroupChildrenTree commerceAccountTree;
        private DevExpress.XtraTab.XtraTabControl tabAccount;
        private DevExpress.XtraTab.XtraTabPage tabPageCommerce;
        private DevExpress.XtraTab.XtraTabPage tabPageConstruction;
        private AccountReceiptModule accountReceiptMod;
    }
}