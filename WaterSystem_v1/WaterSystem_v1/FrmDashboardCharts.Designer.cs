namespace WaterSystem_v1
{
    partial class FrmDashboardCharts
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
            this.tlpMainContainer = new System.Windows.Forms.TableLayoutPanel();
            this.pnlRightContainer = new System.Windows.Forms.Panel();
            this.tlpDetailsContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tlpExpenses = new System.Windows.Forms.TableLayoutPanel();
            this.lblExpenses = new System.Windows.Forms.Label();
            this.pieChartExpenses = new LiveCharts.WinForms.PieChart();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.solidGauge1 = new LiveCharts.WinForms.SolidGauge();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.tlpSalesApprovals = new System.Windows.Forms.TableLayoutPanel();
            this.lblPendingApprovals = new System.Windows.Forms.Label();
            this.solidGauge2 = new LiveCharts.WinForms.SolidGauge();
            this.tlpMainContainer.SuspendLayout();
            this.tlpDetailsContainer.SuspendLayout();
            this.tlpExpenses.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpSalesApprovals.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMainContainer
            // 
            this.tlpMainContainer.BackColor = System.Drawing.Color.Lavender;
            this.tlpMainContainer.ColumnCount = 2;
            this.tlpMainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMainContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 178F));
            this.tlpMainContainer.Controls.Add(this.pnlRightContainer, 1, 0);
            this.tlpMainContainer.Controls.Add(this.tlpDetailsContainer, 0, 0);
            this.tlpMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainContainer.Location = new System.Drawing.Point(0, 0);
            this.tlpMainContainer.Margin = new System.Windows.Forms.Padding(0);
            this.tlpMainContainer.Name = "tlpMainContainer";
            this.tlpMainContainer.RowCount = 1;
            this.tlpMainContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMainContainer.Size = new System.Drawing.Size(679, 402);
            this.tlpMainContainer.TabIndex = 0;
            // 
            // pnlRightContainer
            // 
            this.pnlRightContainer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlRightContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRightContainer.Location = new System.Drawing.Point(501, 6);
            this.pnlRightContainer.Margin = new System.Windows.Forms.Padding(0, 6, 6, 6);
            this.pnlRightContainer.Name = "pnlRightContainer";
            this.pnlRightContainer.Size = new System.Drawing.Size(172, 390);
            this.pnlRightContainer.TabIndex = 0;
            // 
            // tlpDetailsContainer
            // 
            this.tlpDetailsContainer.BackColor = System.Drawing.Color.Lavender;
            this.tlpDetailsContainer.ColumnCount = 3;
            this.tlpDetailsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpDetailsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpDetailsContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpDetailsContainer.Controls.Add(this.tlpExpenses, 2, 0);
            this.tlpDetailsContainer.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tlpDetailsContainer.Controls.Add(this.cartesianChart1, 0, 1);
            this.tlpDetailsContainer.Controls.Add(this.tlpSalesApprovals, 1, 0);
            this.tlpDetailsContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDetailsContainer.Location = new System.Drawing.Point(3, 3);
            this.tlpDetailsContainer.Name = "tlpDetailsContainer";
            this.tlpDetailsContainer.RowCount = 2;
            this.tlpDetailsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDetailsContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpDetailsContainer.Size = new System.Drawing.Size(495, 396);
            this.tlpDetailsContainer.TabIndex = 1;
            // 
            // tlpExpenses
            // 
            this.tlpExpenses.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tlpExpenses.ColumnCount = 1;
            this.tlpExpenses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpExpenses.Controls.Add(this.lblExpenses, 0, 0);
            this.tlpExpenses.Controls.Add(this.pieChartExpenses, 0, 1);
            this.tlpExpenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpExpenses.Location = new System.Drawing.Point(335, 5);
            this.tlpExpenses.Margin = new System.Windows.Forms.Padding(5);
            this.tlpExpenses.Name = "tlpExpenses";
            this.tlpExpenses.Padding = new System.Windows.Forms.Padding(3);
            this.tlpExpenses.RowCount = 2;
            this.tlpExpenses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.16931F));
            this.tlpExpenses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.83069F));
            this.tlpExpenses.Size = new System.Drawing.Size(155, 188);
            this.tlpExpenses.TabIndex = 0;
            // 
            // lblExpenses
            // 
            this.lblExpenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpenses.Location = new System.Drawing.Point(6, 4);
            this.lblExpenses.Margin = new System.Windows.Forms.Padding(3, 1, 3, 0);
            this.lblExpenses.Name = "lblExpenses";
            this.lblExpenses.Padding = new System.Windows.Forms.Padding(2);
            this.lblExpenses.Size = new System.Drawing.Size(143, 21);
            this.lblExpenses.TabIndex = 0;
            this.lblExpenses.Text = "Expenses";
            this.lblExpenses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pieChartExpenses
            // 
            this.pieChartExpenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pieChartExpenses.Location = new System.Drawing.Point(6, 28);
            this.pieChartExpenses.Name = "pieChartExpenses";
            this.pieChartExpenses.Padding = new System.Windows.Forms.Padding(5);
            this.pieChartExpenses.Size = new System.Drawing.Size(143, 154);
            this.pieChartExpenses.TabIndex = 1;
            this.pieChartExpenses.Text = "pieChart1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.solidGauge1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.45833F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.54166F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(155, 188);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales Recovery";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // solidGauge1
            // 
            this.solidGauge1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.solidGauge1.Location = new System.Drawing.Point(6, 26);
            this.solidGauge1.Name = "solidGauge1";
            this.solidGauge1.Size = new System.Drawing.Size(143, 156);
            this.solidGauge1.TabIndex = 1;
            this.solidGauge1.Text = "solidGauge1";
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tlpDetailsContainer.SetColumnSpan(this.cartesianChart1, 3);
            this.cartesianChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartesianChart1.Location = new System.Drawing.Point(5, 203);
            this.cartesianChart1.Margin = new System.Windows.Forms.Padding(5);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Padding = new System.Windows.Forms.Padding(2);
            this.cartesianChart1.Size = new System.Drawing.Size(485, 188);
            this.cartesianChart1.TabIndex = 2;
            this.cartesianChart1.Text = "Sales Monthly Progress";
            // 
            // tlpSalesApprovals
            // 
            this.tlpSalesApprovals.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tlpSalesApprovals.ColumnCount = 1;
            this.tlpSalesApprovals.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSalesApprovals.Controls.Add(this.lblPendingApprovals, 0, 0);
            this.tlpSalesApprovals.Controls.Add(this.solidGauge2, 0, 1);
            this.tlpSalesApprovals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSalesApprovals.Location = new System.Drawing.Point(170, 5);
            this.tlpSalesApprovals.Margin = new System.Windows.Forms.Padding(5);
            this.tlpSalesApprovals.Name = "tlpSalesApprovals";
            this.tlpSalesApprovals.Padding = new System.Windows.Forms.Padding(3);
            this.tlpSalesApprovals.RowCount = 2;
            this.tlpSalesApprovals.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.54167F));
            this.tlpSalesApprovals.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.45834F));
            this.tlpSalesApprovals.Size = new System.Drawing.Size(155, 188);
            this.tlpSalesApprovals.TabIndex = 3;
            // 
            // lblPendingApprovals
            // 
            this.lblPendingApprovals.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPendingApprovals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPendingApprovals.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingApprovals.Location = new System.Drawing.Point(3, 3);
            this.lblPendingApprovals.Margin = new System.Windows.Forms.Padding(0);
            this.lblPendingApprovals.Name = "lblPendingApprovals";
            this.lblPendingApprovals.Size = new System.Drawing.Size(149, 24);
            this.lblPendingApprovals.TabIndex = 0;
            this.lblPendingApprovals.Text = "Pending Approvals";
            this.lblPendingApprovals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // solidGauge2
            // 
            this.solidGauge2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.solidGauge2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.solidGauge2.Location = new System.Drawing.Point(6, 30);
            this.solidGauge2.Name = "solidGauge2";
            this.solidGauge2.Padding = new System.Windows.Forms.Padding(5);
            this.solidGauge2.Size = new System.Drawing.Size(143, 152);
            this.solidGauge2.TabIndex = 1;
            this.solidGauge2.Text = "solidGauge2";
            // 
            // FrmDashboardCharts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 402);
            this.Controls.Add(this.tlpMainContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDashboardCharts";
            this.Text = "FrmDashboardCharts";
            this.Load += new System.EventHandler(this.FrmDashboard_Load);
            this.tlpMainContainer.ResumeLayout(false);
            this.tlpDetailsContainer.ResumeLayout(false);
            this.tlpExpenses.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tlpSalesApprovals.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMainContainer;
        private System.Windows.Forms.Panel pnlRightContainer;
        private System.Windows.Forms.TableLayoutPanel tlpExpenses;
        private System.Windows.Forms.Label lblExpenses;
        private LiveCharts.WinForms.PieChart pieChartExpenses;
        private System.Windows.Forms.TableLayoutPanel tlpDetailsContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private LiveCharts.WinForms.SolidGauge solidGauge1;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.TableLayoutPanel tlpSalesApprovals;
        private System.Windows.Forms.Label lblPendingApprovals;
        private LiveCharts.WinForms.SolidGauge solidGauge2;
    }
}

