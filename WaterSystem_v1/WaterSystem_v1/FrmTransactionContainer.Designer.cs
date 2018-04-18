namespace WaterSystem_v1
{
    partial class FrmTransactionContainer
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
            this.pnlOuterContainer = new System.Windows.Forms.Panel();
            this.tabTransactionContainer = new System.Windows.Forms.TabControl();
            this.tabBillingInvoice = new System.Windows.Forms.TabPage();
            this.tabDebitCredit = new System.Windows.Forms.TabPage();
            this.tabInvoiceApproval = new System.Windows.Forms.TabPage();
            this.tabInvoiceUpdate = new System.Windows.Forms.TabPage();
            this.tabRoot = new System.Windows.Forms.TabPage();
            this.pnlOuterContainer.SuspendLayout();
            this.tabTransactionContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOuterContainer
            // 
            this.pnlOuterContainer.Controls.Add(this.tabTransactionContainer);
            this.pnlOuterContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOuterContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlOuterContainer.Name = "pnlOuterContainer";
            this.pnlOuterContainer.Size = new System.Drawing.Size(765, 510);
            this.pnlOuterContainer.TabIndex = 0;
            // 
            // tabTransactionContainer
            // 
            this.tabTransactionContainer.Controls.Add(this.tabBillingInvoice);
            this.tabTransactionContainer.Controls.Add(this.tabDebitCredit);
            this.tabTransactionContainer.Controls.Add(this.tabInvoiceApproval);
            this.tabTransactionContainer.Controls.Add(this.tabInvoiceUpdate);
            this.tabTransactionContainer.Controls.Add(this.tabRoot);
            this.tabTransactionContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabTransactionContainer.Location = new System.Drawing.Point(0, 0);
            this.tabTransactionContainer.Name = "tabTransactionContainer";
            this.tabTransactionContainer.Padding = new System.Drawing.Point(15, 10);
            this.tabTransactionContainer.SelectedIndex = 0;
            this.tabTransactionContainer.Size = new System.Drawing.Size(765, 510);
            this.tabTransactionContainer.TabIndex = 0;
            this.tabTransactionContainer.Click += new System.EventHandler(this.tabTransactionContainer_Click);
            // 
            // tabBillingInvoice
            // 
            this.tabBillingInvoice.Location = new System.Drawing.Point(4, 36);
            this.tabBillingInvoice.Name = "tabBillingInvoice";
            this.tabBillingInvoice.Padding = new System.Windows.Forms.Padding(3);
            this.tabBillingInvoice.Size = new System.Drawing.Size(757, 470);
            this.tabBillingInvoice.TabIndex = 0;
            this.tabBillingInvoice.Text = "Billing Invoice";
            this.tabBillingInvoice.UseVisualStyleBackColor = true;
            // 
            // tabDebitCredit
            // 
            this.tabDebitCredit.Location = new System.Drawing.Point(4, 36);
            this.tabDebitCredit.Name = "tabDebitCredit";
            this.tabDebitCredit.Padding = new System.Windows.Forms.Padding(3);
            this.tabDebitCredit.Size = new System.Drawing.Size(757, 470);
            this.tabDebitCredit.TabIndex = 1;
            this.tabDebitCredit.Text = "Debit / Credit";
            this.tabDebitCredit.UseVisualStyleBackColor = true;
            // 
            // tabInvoiceApproval
            // 
            this.tabInvoiceApproval.Location = new System.Drawing.Point(4, 36);
            this.tabInvoiceApproval.Name = "tabInvoiceApproval";
            this.tabInvoiceApproval.Size = new System.Drawing.Size(757, 470);
            this.tabInvoiceApproval.TabIndex = 2;
            this.tabInvoiceApproval.Text = "Invoice Approval";
            this.tabInvoiceApproval.UseVisualStyleBackColor = true;
            // 
            // tabInvoiceUpdate
            // 
            this.tabInvoiceUpdate.Location = new System.Drawing.Point(4, 36);
            this.tabInvoiceUpdate.Name = "tabInvoiceUpdate";
            this.tabInvoiceUpdate.Size = new System.Drawing.Size(757, 470);
            this.tabInvoiceUpdate.TabIndex = 3;
            this.tabInvoiceUpdate.Text = "Invoice Update";
            this.tabInvoiceUpdate.UseVisualStyleBackColor = true;
            // 
            // tabRoot
            // 
            this.tabRoot.Location = new System.Drawing.Point(4, 36);
            this.tabRoot.Name = "tabRoot";
            this.tabRoot.Size = new System.Drawing.Size(757, 470);
            this.tabRoot.TabIndex = 4;
            this.tabRoot.Text = "Root";
            this.tabRoot.UseVisualStyleBackColor = true;
            // 
            // FrmTransactionContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(765, 510);
            this.Controls.Add(this.pnlOuterContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTransactionContainer";
            this.Text = "FrmTransactionContainer";
            this.Load += new System.EventHandler(this.FrmTransactionContainer_Load);
            this.pnlOuterContainer.ResumeLayout(false);
            this.tabTransactionContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOuterContainer;
        private System.Windows.Forms.TabControl tabTransactionContainer;
        private System.Windows.Forms.TabPage tabBillingInvoice;
        private System.Windows.Forms.TabPage tabDebitCredit;
        private System.Windows.Forms.TabPage tabInvoiceApproval;
        private System.Windows.Forms.TabPage tabInvoiceUpdate;
        private System.Windows.Forms.TabPage tabRoot;
    }
}