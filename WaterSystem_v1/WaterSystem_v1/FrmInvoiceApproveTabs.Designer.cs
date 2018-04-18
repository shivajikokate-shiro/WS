namespace WaterSystem_v1
{
    partial class FrmInvoiceApproveTabs
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
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.tabApproval = new System.Windows.Forms.TabControl();
            this.sales = new System.Windows.Forms.TabPage();
            this.purchase = new System.Windows.Forms.TabPage();
            this.expenses = new System.Windows.Forms.TabPage();
            this.pnlContainer.SuspendLayout();
            this.tabApproval.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.tabApproval);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Padding = new System.Windows.Forms.Padding(2);
            this.pnlContainer.Size = new System.Drawing.Size(731, 424);
            this.pnlContainer.TabIndex = 0;
            // 
            // tabApproval
            // 
            this.tabApproval.Controls.Add(this.sales);
            this.tabApproval.Controls.Add(this.purchase);
            this.tabApproval.Controls.Add(this.expenses);
            this.tabApproval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabApproval.Location = new System.Drawing.Point(2, 2);
            this.tabApproval.Name = "tabApproval";
            this.tabApproval.Padding = new System.Drawing.Point(15, 10);
            this.tabApproval.SelectedIndex = 0;
            this.tabApproval.Size = new System.Drawing.Size(727, 420);
            this.tabApproval.TabIndex = 0;
            this.tabApproval.Click += new System.EventHandler(this.tabApproval_Click);
            // 
            // sales
            // 
            this.sales.Location = new System.Drawing.Point(4, 36);
            this.sales.Name = "sales";
            this.sales.Padding = new System.Windows.Forms.Padding(3);
            this.sales.Size = new System.Drawing.Size(719, 380);
            this.sales.TabIndex = 0;
            this.sales.Text = "Sales";
            this.sales.UseVisualStyleBackColor = true;
            this.sales.Click += new System.EventHandler(this.sales_Click);
            // 
            // purchase
            // 
            this.purchase.Location = new System.Drawing.Point(4, 36);
            this.purchase.Name = "purchase";
            this.purchase.Padding = new System.Windows.Forms.Padding(3);
            this.purchase.Size = new System.Drawing.Size(719, 380);
            this.purchase.TabIndex = 1;
            this.purchase.Text = "Purchase";
            this.purchase.UseVisualStyleBackColor = true;
            // 
            // expenses
            // 
            this.expenses.Location = new System.Drawing.Point(4, 36);
            this.expenses.Name = "expenses";
            this.expenses.Size = new System.Drawing.Size(719, 380);
            this.expenses.TabIndex = 2;
            this.expenses.Text = "Expenses";
            this.expenses.UseVisualStyleBackColor = true;
            // 
            // FrmInvoiceApproveTabs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(731, 424);
            this.Controls.Add(this.pnlContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInvoiceApproveTabs";
            this.Text = "FrmInvoiceApprove";
            this.Load += new System.EventHandler(this.FrmInvoiceApproveTabs_Load);
            this.pnlContainer.ResumeLayout(false);
            this.tabApproval.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.TabControl tabApproval;
        private System.Windows.Forms.TabPage sales;
        private System.Windows.Forms.TabPage purchase;
        private System.Windows.Forms.TabPage expenses;
    }
}