namespace WaterSystem_v1
{
    partial class FrmSalesTransport
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
            this.txtDriverMobNumber = new System.Windows.Forms.TextBox();
            this.lblDriverNumber = new System.Windows.Forms.Label();
            this.txtDriverName = new System.Windows.Forms.TextBox();
            this.lblDriverName = new System.Windows.Forms.Label();
            this.pnlButtonsContainer = new System.Windows.Forms.Panel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cmbVehicleNumber = new System.Windows.Forms.ComboBox();
            this.lblVehicleNumber = new System.Windows.Forms.Label();
            this.cmbTransport = new System.Windows.Forms.ComboBox();
            this.lblTransport = new System.Windows.Forms.Label();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlContainer.SuspendLayout();
            this.pnlButtonsContainer.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.txtDriverMobNumber);
            this.pnlContainer.Controls.Add(this.lblDriverNumber);
            this.pnlContainer.Controls.Add(this.txtDriverName);
            this.pnlContainer.Controls.Add(this.lblDriverName);
            this.pnlContainer.Controls.Add(this.pnlButtonsContainer);
            this.pnlContainer.Controls.Add(this.cmbVehicleNumber);
            this.pnlContainer.Controls.Add(this.lblVehicleNumber);
            this.pnlContainer.Controls.Add(this.cmbTransport);
            this.pnlContainer.Controls.Add(this.lblTransport);
            this.pnlContainer.Controls.Add(this.pnlTitle);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(445, 252);
            this.pnlContainer.TabIndex = 0;
            // 
            // txtDriverMobNumber
            // 
            this.txtDriverMobNumber.Location = new System.Drawing.Point(241, 147);
            this.txtDriverMobNumber.Name = "txtDriverMobNumber";
            this.txtDriverMobNumber.Size = new System.Drawing.Size(186, 21);
            this.txtDriverMobNumber.TabIndex = 21;
            // 
            // lblDriverNumber
            // 
            this.lblDriverNumber.AutoSize = true;
            this.lblDriverNumber.Location = new System.Drawing.Point(238, 129);
            this.lblDriverNumber.Name = "lblDriverNumber";
            this.lblDriverNumber.Size = new System.Drawing.Size(118, 15);
            this.lblDriverNumber.TabIndex = 20;
            this.lblDriverNumber.Text = "Driver Mob. Number";
            // 
            // txtDriverName
            // 
            this.txtDriverName.Location = new System.Drawing.Point(19, 147);
            this.txtDriverName.Name = "txtDriverName";
            this.txtDriverName.Size = new System.Drawing.Size(186, 21);
            this.txtDriverName.TabIndex = 19;
            // 
            // lblDriverName
            // 
            this.lblDriverName.AutoSize = true;
            this.lblDriverName.Location = new System.Drawing.Point(16, 129);
            this.lblDriverName.Name = "lblDriverName";
            this.lblDriverName.Size = new System.Drawing.Size(76, 15);
            this.lblDriverName.TabIndex = 18;
            this.lblDriverName.Text = "Driver Name";
            // 
            // pnlButtonsContainer
            // 
            this.pnlButtonsContainer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlButtonsContainer.Controls.Add(this.pnlButtons);
            this.pnlButtonsContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtonsContainer.Location = new System.Drawing.Point(0, 206);
            this.pnlButtonsContainer.Name = "pnlButtonsContainer";
            this.pnlButtonsContainer.Size = new System.Drawing.Size(445, 46);
            this.pnlButtonsContainer.TabIndex = 17;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnSubmit);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlButtons.Location = new System.Drawing.Point(148, 0);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(297, 46);
            this.pnlButtons.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(75, 8);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 29);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Clear/Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSubmit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmit.Location = new System.Drawing.Point(186, 8);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(93, 29);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cmbVehicleNumber
            // 
            this.cmbVehicleNumber.FormattingEnabled = true;
            this.cmbVehicleNumber.Location = new System.Drawing.Point(241, 84);
            this.cmbVehicleNumber.Name = "cmbVehicleNumber";
            this.cmbVehicleNumber.Size = new System.Drawing.Size(187, 23);
            this.cmbVehicleNumber.TabIndex = 16;
            // 
            // lblVehicleNumber
            // 
            this.lblVehicleNumber.AutoSize = true;
            this.lblVehicleNumber.Location = new System.Drawing.Point(238, 63);
            this.lblVehicleNumber.Name = "lblVehicleNumber";
            this.lblVehicleNumber.Size = new System.Drawing.Size(95, 15);
            this.lblVehicleNumber.TabIndex = 15;
            this.lblVehicleNumber.Text = "Vehicle Number";
            // 
            // cmbTransport
            // 
            this.cmbTransport.FormattingEnabled = true;
            this.cmbTransport.Location = new System.Drawing.Point(19, 84);
            this.cmbTransport.Name = "cmbTransport";
            this.cmbTransport.Size = new System.Drawing.Size(186, 23);
            this.cmbTransport.TabIndex = 14;
            this.cmbTransport.SelectedIndexChanged += new System.EventHandler(this.cmbTransport_SelectedIndexChanged);
            // 
            // lblTransport
            // 
            this.lblTransport.AutoSize = true;
            this.lblTransport.Location = new System.Drawing.Point(16, 66);
            this.lblTransport.Name = "lblTransport";
            this.lblTransport.Size = new System.Drawing.Size(59, 15);
            this.lblTransport.TabIndex = 13;
            this.lblTransport.Text = "Transport";
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.MediumBlue;
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(445, 40);
            this.pnlTitle.TabIndex = 12;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(139, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(158, 18);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TRANSPORTATION";
            // 
            // FrmSalesTransport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(445, 252);
            this.Controls.Add(this.pnlContainer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSalesTransport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmSalesTransport";
            this.Load += new System.EventHandler(this.FrmSalesTransport_Load);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.pnlButtonsContainer.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cmbTransport;
        private System.Windows.Forms.Label lblTransport;
        private System.Windows.Forms.ComboBox cmbVehicleNumber;
        private System.Windows.Forms.Label lblVehicleNumber;
        private System.Windows.Forms.Panel pnlButtonsContainer;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtDriverMobNumber;
        private System.Windows.Forms.Label lblDriverNumber;
        private System.Windows.Forms.TextBox txtDriverName;
        private System.Windows.Forms.Label lblDriverName;
    }
}