namespace WaterSystem_v1
{
    partial class FrmMasterContainer
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
            this.tabMasterContainer = new System.Windows.Forms.TabControl();
            this.tabMeasurement = new System.Windows.Forms.TabPage();
            this.tabItem = new System.Windows.Forms.TabPage();
            this.tabCustomer = new System.Windows.Forms.TabPage();
            this.tabSupplier = new System.Windows.Forms.TabPage();
            this.tabEmployee = new System.Windows.Forms.TabPage();
            this.tabAccount = new System.Windows.Forms.TabPage();
            this.tabSubAccount = new System.Windows.Forms.TabPage();
            this.tabMasterContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMasterContainer
            // 
            this.tabMasterContainer.Controls.Add(this.tabMeasurement);
            this.tabMasterContainer.Controls.Add(this.tabItem);
            this.tabMasterContainer.Controls.Add(this.tabCustomer);
            this.tabMasterContainer.Controls.Add(this.tabSupplier);
            this.tabMasterContainer.Controls.Add(this.tabEmployee);
            this.tabMasterContainer.Controls.Add(this.tabAccount);
            this.tabMasterContainer.Controls.Add(this.tabSubAccount);
            this.tabMasterContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMasterContainer.Location = new System.Drawing.Point(0, 0);
            this.tabMasterContainer.Name = "tabMasterContainer";
            this.tabMasterContainer.Padding = new System.Drawing.Point(15, 10);
            this.tabMasterContainer.SelectedIndex = 0;
            this.tabMasterContainer.Size = new System.Drawing.Size(635, 413);
            this.tabMasterContainer.TabIndex = 0;
            this.tabMasterContainer.Click += new System.EventHandler(this.tabMasterContainer_Click);
            // 
            // tabMeasurement
            // 
            this.tabMeasurement.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabMeasurement.Location = new System.Drawing.Point(4, 36);
            this.tabMeasurement.Name = "tabMeasurement";
            this.tabMeasurement.Padding = new System.Windows.Forms.Padding(3);
            this.tabMeasurement.Size = new System.Drawing.Size(627, 373);
            this.tabMeasurement.TabIndex = 0;
            this.tabMeasurement.Text = "Measurement";
            this.tabMeasurement.UseVisualStyleBackColor = true;
            // 
            // tabItem
            // 
            this.tabItem.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabItem.Location = new System.Drawing.Point(4, 36);
            this.tabItem.Name = "tabItem";
            this.tabItem.Padding = new System.Windows.Forms.Padding(3);
            this.tabItem.Size = new System.Drawing.Size(627, 373);
            this.tabItem.TabIndex = 1;
            this.tabItem.Text = "Item";
            this.tabItem.UseVisualStyleBackColor = true;
            // 
            // tabCustomer
            // 
            this.tabCustomer.Location = new System.Drawing.Point(4, 36);
            this.tabCustomer.Name = "tabCustomer";
            this.tabCustomer.Size = new System.Drawing.Size(627, 373);
            this.tabCustomer.TabIndex = 2;
            this.tabCustomer.Text = "Customer";
            this.tabCustomer.UseVisualStyleBackColor = true;
            // 
            // tabSupplier
            // 
            this.tabSupplier.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabSupplier.Location = new System.Drawing.Point(4, 36);
            this.tabSupplier.Name = "tabSupplier";
            this.tabSupplier.Size = new System.Drawing.Size(627, 373);
            this.tabSupplier.TabIndex = 3;
            this.tabSupplier.Text = "Supplier";
            this.tabSupplier.UseVisualStyleBackColor = true;
            // 
            // tabEmployee
            // 
            this.tabEmployee.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabEmployee.Location = new System.Drawing.Point(4, 36);
            this.tabEmployee.Name = "tabEmployee";
            this.tabEmployee.Size = new System.Drawing.Size(627, 373);
            this.tabEmployee.TabIndex = 4;
            this.tabEmployee.Text = "Employee";
            this.tabEmployee.UseVisualStyleBackColor = true;
            // 
            // tabAccount
            // 
            this.tabAccount.Location = new System.Drawing.Point(4, 36);
            this.tabAccount.Name = "tabAccount";
            this.tabAccount.Size = new System.Drawing.Size(627, 373);
            this.tabAccount.TabIndex = 6;
            this.tabAccount.Text = "Account";
            this.tabAccount.UseVisualStyleBackColor = true;
            // 
            // tabSubAccount
            // 
            this.tabSubAccount.Location = new System.Drawing.Point(4, 36);
            this.tabSubAccount.Name = "tabSubAccount";
            this.tabSubAccount.Size = new System.Drawing.Size(627, 373);
            this.tabSubAccount.TabIndex = 7;
            this.tabSubAccount.Text = "SubAccount";
            this.tabSubAccount.UseVisualStyleBackColor = true;
            // 
            // FrmMasterContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 413);
            this.Controls.Add(this.tabMasterContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMasterContainer";
            this.Text = "FrmMasterContainer";
            this.tabMasterContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMasterContainer;
        private System.Windows.Forms.TabPage tabMeasurement;
        private System.Windows.Forms.TabPage tabItem;
        private System.Windows.Forms.TabPage tabCustomer;
        private System.Windows.Forms.TabPage tabSupplier;
        private System.Windows.Forms.TabPage tabEmployee;
        private System.Windows.Forms.TabPage tabAccount;
        private System.Windows.Forms.TabPage tabSubAccount;
    }
}