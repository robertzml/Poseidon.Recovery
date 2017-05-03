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
            this.accountTree = new Poseidon.Winform.Core.GroupChildrenTree();
            this.accountReceiptMod = new Poseidon.Recovery.ClientDx.AccountReceiptModule();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.accountReceiptMod);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(869, 526);
            this.splitContainerControl1.SplitterPosition = 190;
            this.splitContainerControl1.TabIndex = 0;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // accountTree
            // 
            this.accountTree.CascadeEntity = false;
            this.accountTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountTree.Location = new System.Drawing.Point(2, 21);
            this.accountTree.Name = "accountTree";
            this.accountTree.ShowFindPanel = false;
            this.accountTree.Size = new System.Drawing.Size(186, 503);
            this.accountTree.TabIndex = 0;
            this.accountTree.EntitySelected += new System.EventHandler(this.accountTree_EntitySelected);
            // 
            // accountReceiptMod
            // 
            this.accountReceiptMod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.accountReceiptMod.Location = new System.Drawing.Point(0, 0);
            this.accountReceiptMod.Name = "accountReceiptMod";
            this.accountReceiptMod.Size = new System.Drawing.Size(674, 526);
            this.accountReceiptMod.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.accountTree);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(190, 526);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "账户列表";
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
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private AccountReceiptModule accountReceiptMod;
        private Winform.Core.GroupChildrenTree accountTree;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}