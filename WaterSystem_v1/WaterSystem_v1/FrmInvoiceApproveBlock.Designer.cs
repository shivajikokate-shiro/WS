namespace WaterSystem_v1
{
    partial class FrmInvoiceApproveBlock
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
            this.tblContainer = new System.Windows.Forms.TableLayoutPanel();
            this.pnlApproveComponent = new System.Windows.Forms.Panel();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.tblContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblContainer
            // 
            this.tblContainer.ColumnCount = 2;
            this.tblContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblContainer.Controls.Add(this.pnlApproveComponent, 0, 1);
            this.tblContainer.Controls.Add(this.pnlDetails, 0, 0);
            this.tblContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblContainer.Location = new System.Drawing.Point(0, 0);
            this.tblContainer.Margin = new System.Windows.Forms.Padding(0);
            this.tblContainer.Name = "tblContainer";
            this.tblContainer.RowCount = 2;
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.93868F));
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.06132F));
            this.tblContainer.Size = new System.Drawing.Size(624, 334);
            this.tblContainer.TabIndex = 0;
            // 
            // pnlApproveComponent
            // 
            this.tblContainer.SetColumnSpan(this.pnlApproveComponent, 2);
            this.pnlApproveComponent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlApproveComponent.Location = new System.Drawing.Point(0, 79);
            this.pnlApproveComponent.Margin = new System.Windows.Forms.Padding(0);
            this.pnlApproveComponent.Name = "pnlApproveComponent";
            this.pnlApproveComponent.Size = new System.Drawing.Size(624, 255);
            this.pnlApproveComponent.TabIndex = 0;
            // 
            // pnlDetails
            // 
            this.pnlDetails.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tblContainer.SetColumnSpan(this.pnlDetails, 2);
            this.pnlDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetails.Location = new System.Drawing.Point(0, 0);
            this.pnlDetails.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(624, 79);
            this.pnlDetails.TabIndex = 1;
            // 
            // FrmInvoiceApproveBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(624, 334);
            this.Controls.Add(this.tblContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInvoiceApproveBlock";
            this.Text = "FrmInvoiceApproveBlock";
            this.Load += new System.EventHandler(this.FrmInvoiceApproveBlock_Load);
            this.tblContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblContainer;
        private System.Windows.Forms.Panel pnlApproveComponent;
        private System.Windows.Forms.Panel pnlDetails;
    }
}