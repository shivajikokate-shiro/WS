namespace WaterSystem_v1
{
    partial class FrmTransportationContainer
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
            this.pnlTransportationContainer = new System.Windows.Forms.Panel();
            this.tabTrasportationContainer = new System.Windows.Forms.TabControl();
            this.tabTransportation = new System.Windows.Forms.TabPage();
            this.tabVehicle = new System.Windows.Forms.TabPage();
            this.tabRoute = new System.Windows.Forms.TabPage();
            this.pnlTransportationContainer.SuspendLayout();
            this.tabTrasportationContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTransportationContainer
            // 
            this.pnlTransportationContainer.Controls.Add(this.tabTrasportationContainer);
            this.pnlTransportationContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTransportationContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlTransportationContainer.Name = "pnlTransportationContainer";
            this.pnlTransportationContainer.Size = new System.Drawing.Size(668, 425);
            this.pnlTransportationContainer.TabIndex = 0;
            // 
            // tabTrasportationContainer
            // 
            this.tabTrasportationContainer.Controls.Add(this.tabTransportation);
            this.tabTrasportationContainer.Controls.Add(this.tabVehicle);
            this.tabTrasportationContainer.Controls.Add(this.tabRoute);
            this.tabTrasportationContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabTrasportationContainer.Location = new System.Drawing.Point(0, 0);
            this.tabTrasportationContainer.Name = "tabTrasportationContainer";
            this.tabTrasportationContainer.Padding = new System.Drawing.Point(15, 10);
            this.tabTrasportationContainer.SelectedIndex = 0;
            this.tabTrasportationContainer.Size = new System.Drawing.Size(668, 425);
            this.tabTrasportationContainer.TabIndex = 0;
            this.tabTrasportationContainer.Click += new System.EventHandler(this.tabTrasportationContainer_Click);
            // 
            // tabTransportation
            // 
            this.tabTransportation.Location = new System.Drawing.Point(4, 36);
            this.tabTransportation.Name = "tabTransportation";
            this.tabTransportation.Padding = new System.Windows.Forms.Padding(3);
            this.tabTransportation.Size = new System.Drawing.Size(660, 385);
            this.tabTransportation.TabIndex = 0;
            this.tabTransportation.Text = "Transportation";
            this.tabTransportation.UseVisualStyleBackColor = true;
            // 
            // tabVehicle
            // 
            this.tabVehicle.Location = new System.Drawing.Point(4, 36);
            this.tabVehicle.Name = "tabVehicle";
            this.tabVehicle.Padding = new System.Windows.Forms.Padding(3);
            this.tabVehicle.Size = new System.Drawing.Size(660, 385);
            this.tabVehicle.TabIndex = 1;
            this.tabVehicle.Text = "Vehicle";
            this.tabVehicle.UseVisualStyleBackColor = true;
            // 
            // tabRoute
            // 
            this.tabRoute.Location = new System.Drawing.Point(4, 36);
            this.tabRoute.Name = "tabRoute";
            this.tabRoute.Size = new System.Drawing.Size(660, 385);
            this.tabRoute.TabIndex = 2;
            this.tabRoute.Text = "Route";
            this.tabRoute.UseVisualStyleBackColor = true;
            // 
            // FrmTransportationContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(668, 425);
            this.Controls.Add(this.pnlTransportationContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTransportationContainer";
            this.Text = "TransportationContainer";
            this.Load += new System.EventHandler(this.FrmTransportationContainer_Load);
            this.pnlTransportationContainer.ResumeLayout(false);
            this.tabTrasportationContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTransportationContainer;
        private System.Windows.Forms.TabControl tabTrasportationContainer;
        private System.Windows.Forms.TabPage tabTransportation;
        private System.Windows.Forms.TabPage tabVehicle;
        private System.Windows.Forms.TabPage tabRoute;
    }
}