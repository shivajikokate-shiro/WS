namespace WaterSystem_v1
{
    partial class FrmInvoiceApprove
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
            this.lblDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pnlDate = new System.Windows.Forms.Panel();
            this.pnlDateContainer = new System.Windows.Forms.Panel();
            this.tblContainer = new System.Windows.Forms.TableLayoutPanel();
            this.ovlApproval = new BrightIdeasSoftware.ObjectListView();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.flpPassButton = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPass = new System.Windows.Forms.Button();
            this.pnlDate.SuspendLayout();
            this.pnlDateContainer.SuspendLayout();
            this.tblContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ovlApproval)).BeginInit();
            this.flpPassButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(121, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(48, 20);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(194, 9);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(107, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // pnlDate
            // 
            this.pnlDate.Controls.Add(this.pnlDateContainer);
            this.pnlDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDate.Location = new System.Drawing.Point(0, 0);
            this.pnlDate.Name = "pnlDate";
            this.pnlDate.Size = new System.Drawing.Size(601, 38);
            this.pnlDate.TabIndex = 0;
            // 
            // pnlDateContainer
            // 
            this.pnlDateContainer.Controls.Add(this.dateTimePicker1);
            this.pnlDateContainer.Controls.Add(this.lblDate);
            this.pnlDateContainer.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDateContainer.Location = new System.Drawing.Point(274, 0);
            this.pnlDateContainer.Name = "pnlDateContainer";
            this.pnlDateContainer.Size = new System.Drawing.Size(327, 38);
            this.pnlDateContainer.TabIndex = 2;
            // 
            // tblContainer
            // 
            this.tblContainer.ColumnCount = 2;
            this.tblContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66667F));
            this.tblContainer.Controls.Add(this.ovlApproval, 0, 1);
            this.tblContainer.Controls.Add(this.btnSelectAll, 0, 0);
            this.tblContainer.Controls.Add(this.flpPassButton, 1, 0);
            this.tblContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblContainer.Location = new System.Drawing.Point(0, 38);
            this.tblContainer.Name = "tblContainer";
            this.tblContainer.RowCount = 2;
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblContainer.Size = new System.Drawing.Size(601, 297);
            this.tblContainer.TabIndex = 2;
            // 
            // ovlApproval
            // 
            this.ovlApproval.CellEditUseWholeCell = false;
            this.tblContainer.SetColumnSpan(this.ovlApproval, 2);
            this.ovlApproval.Cursor = System.Windows.Forms.Cursors.Default;
            this.ovlApproval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ovlApproval.HasCollapsibleGroups = false;
            this.ovlApproval.Location = new System.Drawing.Point(3, 43);
            this.ovlApproval.MenuLabelGroupBy = "";
            this.ovlApproval.MenuLabelLockGroupingOn = "";
            this.ovlApproval.MenuLabelSortAscending = "";
            this.ovlApproval.MenuLabelUnlockGroupingOn = "";
            this.ovlApproval.Name = "ovlApproval";
            this.ovlApproval.Size = new System.Drawing.Size(595, 251);
            this.ovlApproval.TabIndex = 7;
            this.ovlApproval.UseCompatibleStateImageBehavior = false;
            this.ovlApproval.View = System.Windows.Forms.View.Details;
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectAll.Location = new System.Drawing.Point(10, 8);
            this.btnSelectAll.Margin = new System.Windows.Forms.Padding(10, 8, 3, 3);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(75, 23);
            this.btnSelectAll.TabIndex = 8;
            this.btnSelectAll.Text = "Select All";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // flpPassButton
            // 
            this.flpPassButton.Controls.Add(this.btnPass);
            this.flpPassButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpPassButton.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpPassButton.Location = new System.Drawing.Point(203, 3);
            this.flpPassButton.Name = "flpPassButton";
            this.flpPassButton.Size = new System.Drawing.Size(395, 34);
            this.flpPassButton.TabIndex = 9;
            // 
            // btnPass
            // 
            this.btnPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPass.Location = new System.Drawing.Point(276, 3);
            this.btnPass.Margin = new System.Windows.Forms.Padding(3, 3, 15, 3);
            this.btnPass.Name = "btnPass";
            this.btnPass.Size = new System.Drawing.Size(104, 30);
            this.btnPass.TabIndex = 0;
            this.btnPass.Text = "Pass";
            this.btnPass.UseVisualStyleBackColor = true;
            this.btnPass.Click += new System.EventHandler(this.btnPass_Click);
            // 
            // FrmInvoiceApprove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(601, 335);
            this.Controls.Add(this.tblContainer);
            this.Controls.Add(this.pnlDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInvoiceApprove";
            this.Text = "FrmInvoiceApprove";
            this.Load += new System.EventHandler(this.FrmInvoiceApprove_Load);
            this.pnlDate.ResumeLayout(false);
            this.pnlDateContainer.ResumeLayout(false);
            this.pnlDateContainer.PerformLayout();
            this.tblContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ovlApproval)).EndInit();
            this.flpPassButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel pnlDate;
        private System.Windows.Forms.Panel pnlDateContainer;
        private System.Windows.Forms.TableLayoutPanel tblContainer;
        private BrightIdeasSoftware.ObjectListView ovlApproval;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.FlowLayoutPanel flpPassButton;
        private System.Windows.Forms.Button btnPass;
    }
}