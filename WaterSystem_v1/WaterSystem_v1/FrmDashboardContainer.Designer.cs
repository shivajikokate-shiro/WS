namespace WaterSystem_v1
{
    partial class FrmDashboardContainer
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
            this.tplMainContainer = new System.Windows.Forms.TableLayoutPanel();
            this.pnlDashboardHeader = new System.Windows.Forms.Panel();
            this.pnlChartsContainer = new System.Windows.Forms.Panel();
            this.tlpDashboardHeader = new System.Windows.Forms.TableLayoutPanel();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.tplMainContainer.SuspendLayout();
            this.pnlDashboardHeader.SuspendLayout();
            this.tlpDashboardHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // tplMainContainer
            // 
            this.tplMainContainer.ColumnCount = 1;
            this.tplMainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tplMainContainer.Controls.Add(this.pnlDashboardHeader, 0, 0);
            this.tplMainContainer.Controls.Add(this.pnlChartsContainer, 0, 1);
            this.tplMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tplMainContainer.Location = new System.Drawing.Point(0, 0);
            this.tplMainContainer.Name = "tplMainContainer";
            this.tplMainContainer.RowCount = 2;
            this.tplMainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tplMainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tplMainContainer.Size = new System.Drawing.Size(566, 311);
            this.tplMainContainer.TabIndex = 0;
            // 
            // pnlDashboardHeader
            // 
            this.pnlDashboardHeader.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlDashboardHeader.Controls.Add(this.tlpDashboardHeader);
            this.pnlDashboardHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashboardHeader.Location = new System.Drawing.Point(7, 6);
            this.pnlDashboardHeader.Margin = new System.Windows.Forms.Padding(7, 6, 6, 0);
            this.pnlDashboardHeader.Name = "pnlDashboardHeader";
            this.pnlDashboardHeader.Size = new System.Drawing.Size(553, 56);
            this.pnlDashboardHeader.TabIndex = 0;
            // 
            // pnlChartsContainer
            // 
            this.pnlChartsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChartsContainer.Location = new System.Drawing.Point(0, 62);
            this.pnlChartsContainer.Margin = new System.Windows.Forms.Padding(0);
            this.pnlChartsContainer.Name = "pnlChartsContainer";
            this.pnlChartsContainer.Size = new System.Drawing.Size(566, 249);
            this.pnlChartsContainer.TabIndex = 1;
            // 
            // tlpDashboardHeader
            // 
            this.tlpDashboardHeader.ColumnCount = 2;
            this.tlpDashboardHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDashboardHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDashboardHeader.Controls.Add(this.lblDashboard, 0, 0);
            this.tlpDashboardHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDashboardHeader.Location = new System.Drawing.Point(0, 0);
            this.tlpDashboardHeader.Name = "tlpDashboardHeader";
            this.tlpDashboardHeader.RowCount = 1;
            this.tlpDashboardHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDashboardHeader.Size = new System.Drawing.Size(553, 56);
            this.tlpDashboardHeader.TabIndex = 0;
            // 
            // lblDashboard
            // 
            this.lblDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDashboard.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.Location = new System.Drawing.Point(3, 0);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(270, 56);
            this.lblDashboard.TabIndex = 0;
            this.lblDashboard.Text = "Dashboard";
            this.lblDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmDashboardContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(566, 311);
            this.Controls.Add(this.tplMainContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDashboardContainer";
            this.Text = "FrmDashboardContainer";
            this.Load += new System.EventHandler(this.FrmDashboardContainer_Load);
            this.tplMainContainer.ResumeLayout(false);
            this.pnlDashboardHeader.ResumeLayout(false);
            this.tlpDashboardHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tplMainContainer;
        private System.Windows.Forms.Panel pnlDashboardHeader;
        private System.Windows.Forms.Panel pnlChartsContainer;
        private System.Windows.Forms.TableLayoutPanel tlpDashboardHeader;
        private System.Windows.Forms.Label lblDashboard;
    }
}