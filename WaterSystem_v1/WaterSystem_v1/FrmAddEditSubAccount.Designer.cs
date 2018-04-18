namespace WaterSystem_v1
{
    partial class FrmAddEditSubAccount
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
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.pnlActiveContainer = new System.Windows.Forms.Panel();
            this.pnlActive = new System.Windows.Forms.Panel();
            this.toggleActive = new JCS.ToggleSwitch();
            this.lblActive = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.cmbMainAccount = new System.Windows.Forms.ComboBox();
            this.lblMainAccount = new System.Windows.Forms.Label();
            this.cmbAccountType = new System.Windows.Forms.ComboBox();
            this.lblSubAccountType = new System.Windows.Forms.Label();
            this.txtSubAccountType = new System.Windows.Forms.TextBox();
            this.pnlTitle.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.pnlActiveContainer.SuspendLayout();
            this.pnlActive.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.MediumBlue;
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(473, 35);
            this.pnlTitle.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitle.Location = new System.Drawing.Point(223, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(42, 18);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "ADD";
            // 
            // pnlButton
            // 
            this.pnlButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlButton.Controls.Add(this.pnlActiveContainer);
            this.pnlButton.Controls.Add(this.btnCancel);
            this.pnlButton.Controls.Add(this.btnSubmit);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButton.Location = new System.Drawing.Point(0, 172);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(473, 46);
            this.pnlButton.TabIndex = 5;
            // 
            // pnlActiveContainer
            // 
            this.pnlActiveContainer.Controls.Add(this.pnlActive);
            this.pnlActiveContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlActiveContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlActiveContainer.Name = "pnlActiveContainer";
            this.pnlActiveContainer.Size = new System.Drawing.Size(167, 46);
            this.pnlActiveContainer.TabIndex = 2;
            // 
            // pnlActive
            // 
            this.pnlActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(83)))), ((int)(((byte)(91)))));
            this.pnlActive.Controls.Add(this.toggleActive);
            this.pnlActive.Controls.Add(this.lblActive);
            this.pnlActive.Location = new System.Drawing.Point(12, 6);
            this.pnlActive.Name = "pnlActive";
            this.pnlActive.Size = new System.Drawing.Size(144, 33);
            this.pnlActive.TabIndex = 0;
            // 
            // toggleActive
            // 
            this.toggleActive.Location = new System.Drawing.Point(65, 6);
            this.toggleActive.Name = "toggleActive";
            this.toggleActive.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleActive.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleActive.Size = new System.Drawing.Size(50, 19);
            this.toggleActive.TabIndex = 5;
            // 
            // lblActive
            // 
            this.lblActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActive.ForeColor = System.Drawing.Color.White;
            this.lblActive.Location = new System.Drawing.Point(9, 7);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(53, 20);
            this.lblActive.TabIndex = 5;
            this.lblActive.Text = "Active";
            this.lblActive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(286, 11);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 25);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSubmit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmit.Location = new System.Drawing.Point(381, 11);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(80, 25);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccountType.Location = new System.Drawing.Point(258, 54);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(97, 16);
            this.lblAccountType.TabIndex = 11;
            this.lblAccountType.Text = "Account Type :";
            // 
            // cmbMainAccount
            // 
            this.cmbMainAccount.FormattingEnabled = true;
            this.cmbMainAccount.Location = new System.Drawing.Point(53, 74);
            this.cmbMainAccount.Name = "cmbMainAccount";
            this.cmbMainAccount.Size = new System.Drawing.Size(177, 21);
            this.cmbMainAccount.TabIndex = 10;
            this.cmbMainAccount.SelectedIndexChanged += new System.EventHandler(this.cmbMainAccount_SelectedIndexChanged);
            // 
            // lblMainAccount
            // 
            this.lblMainAccount.AutoSize = true;
            this.lblMainAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainAccount.Location = new System.Drawing.Point(50, 54);
            this.lblMainAccount.Name = "lblMainAccount";
            this.lblMainAccount.Size = new System.Drawing.Size(94, 16);
            this.lblMainAccount.TabIndex = 9;
            this.lblMainAccount.Text = "Main Account :";
            // 
            // cmbAccountType
            // 
            this.cmbAccountType.FormattingEnabled = true;
            this.cmbAccountType.Location = new System.Drawing.Point(261, 74);
            this.cmbAccountType.Name = "cmbAccountType";
            this.cmbAccountType.Size = new System.Drawing.Size(177, 21);
            this.cmbAccountType.TabIndex = 12;
            // 
            // lblSubAccountType
            // 
            this.lblSubAccountType.AutoSize = true;
            this.lblSubAccountType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubAccountType.Location = new System.Drawing.Point(50, 110);
            this.lblSubAccountType.Name = "lblSubAccountType";
            this.lblSubAccountType.Size = new System.Drawing.Size(124, 16);
            this.lblSubAccountType.TabIndex = 13;
            this.lblSubAccountType.Text = "Sub Account Type :";
            // 
            // txtSubAccountType
            // 
            this.txtSubAccountType.Location = new System.Drawing.Point(55, 129);
            this.txtSubAccountType.Name = "txtSubAccountType";
            this.txtSubAccountType.Size = new System.Drawing.Size(175, 20);
            this.txtSubAccountType.TabIndex = 14;
            // 
            // FrmAddEditSubAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(473, 218);
            this.Controls.Add(this.txtSubAccountType);
            this.Controls.Add(this.lblSubAccountType);
            this.Controls.Add(this.cmbAccountType);
            this.Controls.Add(this.lblAccountType);
            this.Controls.Add(this.cmbMainAccount);
            this.Controls.Add(this.lblMainAccount);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.pnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddEditSubAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmAddEditSubAccount";
            this.Load += new System.EventHandler(this.FrmAddEditSubAccount_Load);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlButton.ResumeLayout(false);
            this.pnlActiveContainer.ResumeLayout(false);
            this.pnlActive.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Panel pnlActiveContainer;
        private System.Windows.Forms.Panel pnlActive;
        private JCS.ToggleSwitch toggleActive;
        private System.Windows.Forms.Label lblActive;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.ComboBox cmbMainAccount;
        private System.Windows.Forms.Label lblMainAccount;
        private System.Windows.Forms.ComboBox cmbAccountType;
        private System.Windows.Forms.Label lblSubAccountType;
        private System.Windows.Forms.TextBox txtSubAccountType;
    }
}