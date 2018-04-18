namespace WaterSystem_v1
{
    partial class FrmExpenses
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
            this.tblExpenses = new System.Windows.Forms.TableLayoutPanel();
            this.lblDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.flpDate = new System.Windows.Forms.FlowLayoutPanel();
            this.flpPayee = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPayee = new System.Windows.Forms.Label();
            this.cmbPayee = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPayer = new System.Windows.Forms.Label();
            this.cmbPayer = new System.Windows.Forms.ComboBox();
            this.flpPaymentMethod = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.flpAmount = new System.Windows.Forms.FlowLayoutPanel();
            this.lblAmount = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tblExpenses.SuspendLayout();
            this.flpDate.SuspendLayout();
            this.flpPayee.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flpPaymentMethod.SuspendLayout();
            this.flpAmount.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblExpenses
            // 
            this.tblExpenses.ColumnCount = 2;
            this.tblExpenses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblExpenses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblExpenses.Controls.Add(this.flpPayee, 1, 1);
            this.tblExpenses.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tblExpenses.Controls.Add(this.flpPaymentMethod, 0, 2);
            this.tblExpenses.Controls.Add(this.flpDate, 0, 0);
            this.tblExpenses.Controls.Add(this.flpAmount, 1, 0);
            this.tblExpenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblExpenses.Location = new System.Drawing.Point(0, 0);
            this.tblExpenses.Name = "tblExpenses";
            this.tblExpenses.RowCount = 5;
            this.tblExpenses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblExpenses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblExpenses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblExpenses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblExpenses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tblExpenses.Size = new System.Drawing.Size(676, 355);
            this.tblExpenses.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(6, 7);
            this.lblDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(36, 15);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 24);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(133, 21);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // flpDate
            // 
            this.flpDate.Controls.Add(this.lblDate);
            this.flpDate.Controls.Add(this.dateTimePicker1);
            this.flpDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpDate.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpDate.Location = new System.Drawing.Point(3, 3);
            this.flpDate.Name = "flpDate";
            this.flpDate.Padding = new System.Windows.Forms.Padding(3);
            this.flpDate.Size = new System.Drawing.Size(329, 54);
            this.flpDate.TabIndex = 1;
            // 
            // flpPayee
            // 
            this.flpPayee.Controls.Add(this.lblPayee);
            this.flpPayee.Controls.Add(this.cmbPayee);
            this.flpPayee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpPayee.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpPayee.Location = new System.Drawing.Point(338, 63);
            this.flpPayee.Name = "flpPayee";
            this.flpPayee.Size = new System.Drawing.Size(330, 52);
            this.flpPayee.TabIndex = 2;
            // 
            // lblPayee
            // 
            this.lblPayee.AutoSize = true;
            this.lblPayee.Location = new System.Drawing.Point(3, 4);
            this.lblPayee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.lblPayee.Name = "lblPayee";
            this.lblPayee.Size = new System.Drawing.Size(90, 15);
            this.lblPayee.TabIndex = 1;
            this.lblPayee.Text = "Payee Account:";
            // 
            // cmbPayee
            // 
            this.cmbPayee.FormattingEnabled = true;
            this.cmbPayee.Location = new System.Drawing.Point(3, 22);
            this.cmbPayee.Name = "cmbPayee";
            this.cmbPayee.Size = new System.Drawing.Size(242, 23);
            this.cmbPayee.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.lblPayer);
            this.flowLayoutPanel1.Controls.Add(this.cmbPayer);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 63);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(329, 52);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // lblPayer
            // 
            this.lblPayer.AutoSize = true;
            this.lblPayer.Location = new System.Drawing.Point(3, 4);
            this.lblPayer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 0);
            this.lblPayer.Name = "lblPayer";
            this.lblPayer.Size = new System.Drawing.Size(87, 15);
            this.lblPayer.TabIndex = 1;
            this.lblPayer.Text = "Payer Account:";
            // 
            // cmbPayer
            // 
            this.cmbPayer.FormattingEnabled = true;
            this.cmbPayer.Location = new System.Drawing.Point(3, 22);
            this.cmbPayer.Name = "cmbPayer";
            this.cmbPayer.Size = new System.Drawing.Size(244, 23);
            this.cmbPayer.TabIndex = 2;
            // 
            // flpPaymentMethod
            // 
            this.flpPaymentMethod.Controls.Add(this.label1);
            this.flpPaymentMethod.Controls.Add(this.comboBox1);
            this.flpPaymentMethod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpPaymentMethod.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpPaymentMethod.Location = new System.Drawing.Point(3, 121);
            this.flpPaymentMethod.Name = "flpPaymentMethod";
            this.flpPaymentMethod.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.flpPaymentMethod.Size = new System.Drawing.Size(329, 59);
            this.flpPaymentMethod.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment Method:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(244, 23);
            this.comboBox1.TabIndex = 1;
            // 
            // flpAmount
            // 
            this.flpAmount.Controls.Add(this.lblAmount);
            this.flpAmount.Controls.Add(this.textBox1);
            this.flpAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpAmount.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpAmount.Location = new System.Drawing.Point(3, 186);
            this.flpAmount.Name = "flpAmount";
            this.flpAmount.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.flpAmount.Size = new System.Drawing.Size(329, 67);
            this.flpAmount.TabIndex = 5;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(3, 3);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(49, 15);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Amount";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 21);
            this.textBox1.TabIndex = 1;
            // 
            // FrmExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(676, 355);
            this.Controls.Add(this.tblExpenses);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FrmExpenses";
            this.Text = "FrmExpenses";
            this.tblExpenses.ResumeLayout(false);
            this.flpDate.ResumeLayout(false);
            this.flpDate.PerformLayout();
            this.flpPayee.ResumeLayout(false);
            this.flpPayee.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flpPaymentMethod.ResumeLayout(false);
            this.flpPaymentMethod.PerformLayout();
            this.flpAmount.ResumeLayout(false);
            this.flpAmount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblExpenses;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.FlowLayoutPanel flpDate;
        private System.Windows.Forms.FlowLayoutPanel flpPayee;
        private System.Windows.Forms.Label lblPayee;
        private System.Windows.Forms.ComboBox cmbPayee;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lblPayer;
        private System.Windows.Forms.ComboBox cmbPayer;
        private System.Windows.Forms.FlowLayoutPanel flpPaymentMethod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.FlowLayoutPanel flpAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox textBox1;
    }
}