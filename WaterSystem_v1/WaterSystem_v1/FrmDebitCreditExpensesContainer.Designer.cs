namespace WaterSystem_v1
{
    partial class FrmDebitCreditExpensesContainer
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
            this.pnlMainContainer = new System.Windows.Forms.Panel();
            this.pnlInfoContainer = new System.Windows.Forms.Panel();
            this.tblContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblContainer
            // 
            this.tblContainer.ColumnCount = 1;
            this.tblContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblContainer.Controls.Add(this.pnlMainContainer, 0, 1);
            this.tblContainer.Controls.Add(this.pnlInfoContainer, 0, 0);
            this.tblContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblContainer.Location = new System.Drawing.Point(0, 0);
            this.tblContainer.Name = "tblContainer";
            this.tblContainer.RowCount = 2;
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.31915F));
            this.tblContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.68085F));
            this.tblContainer.Size = new System.Drawing.Size(664, 376);
            this.tblContainer.TabIndex = 0;
            // 
            // pnlMainContainer
            // 
            this.pnlMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContainer.Location = new System.Drawing.Point(3, 117);
            this.pnlMainContainer.Name = "pnlMainContainer";
            this.pnlMainContainer.Size = new System.Drawing.Size(658, 256);
            this.pnlMainContainer.TabIndex = 0;
            // 
            // pnlInfoContainer
            // 
            this.pnlInfoContainer.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pnlInfoContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInfoContainer.Location = new System.Drawing.Point(3, 3);
            this.pnlInfoContainer.Name = "pnlInfoContainer";
            this.pnlInfoContainer.Size = new System.Drawing.Size(658, 108);
            this.pnlInfoContainer.TabIndex = 1;
            // 
            // FrmDebitCreditExpensesContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(664, 376);
            this.Controls.Add(this.tblContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDebitCreditExpensesContainer";
            this.Text = "FrmDebitCreditExpensesContainer";
            this.Load += new System.EventHandler(this.FrmDebitCreditExpensesContainer_Load);
            this.tblContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblContainer;
        private System.Windows.Forms.Panel pnlMainContainer;
        private System.Windows.Forms.Panel pnlInfoContainer;
    }
}