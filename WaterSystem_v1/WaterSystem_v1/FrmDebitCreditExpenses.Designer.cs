namespace WaterSystem_v1
{
    partial class FrmDebitCreditExpenses
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
            this.tblDate = new System.Windows.Forms.TableLayoutPanel();
            this.lblToken = new System.Windows.Forms.Label();
            this.lblPaymentMethode = new System.Windows.Forms.Label();
            this.lblTokenValue = new System.Windows.Forms.Label();
            this.cmbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.tblPayer = new System.Windows.Forms.TableLayoutPanel();
            this.cmbPayer = new System.Windows.Forms.ComboBox();
            this.lblPayer = new System.Windows.Forms.Label();
            this.tblPayee = new System.Windows.Forms.TableLayoutPanel();
            this.lblPayee = new System.Windows.Forms.Label();
            this.cmbPayee = new System.Windows.Forms.ComboBox();
            this.tlpAmount = new System.Windows.Forms.TableLayoutPanel();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.tlpPaymentMethod = new System.Windows.Forms.TableLayoutPanel();
            this.dtpTransaction = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.tlpGst = new System.Windows.Forms.TableLayoutPanel();
            this.lblGST = new System.Windows.Forms.Label();
            this.txtGST = new System.Windows.Forms.TextBox();
            this.tlpDescription = new System.Windows.Forms.TableLayoutPanel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.flpButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tblExpenses.SuspendLayout();
            this.tblDate.SuspendLayout();
            this.tblPayer.SuspendLayout();
            this.tblPayee.SuspendLayout();
            this.tlpAmount.SuspendLayout();
            this.tlpPaymentMethod.SuspendLayout();
            this.tlpGst.SuspendLayout();
            this.tlpDescription.SuspendLayout();
            this.flpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblExpenses
            // 
            this.tblExpenses.ColumnCount = 2;
            this.tblExpenses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblExpenses.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblExpenses.Controls.Add(this.tblDate, 0, 0);
            this.tblExpenses.Controls.Add(this.tblPayer, 0, 1);
            this.tblExpenses.Controls.Add(this.tblPayee, 1, 1);
            this.tblExpenses.Controls.Add(this.tlpAmount, 0, 2);
            this.tblExpenses.Controls.Add(this.tlpPaymentMethod, 1, 0);
            this.tblExpenses.Controls.Add(this.tlpGst, 1, 2);
            this.tblExpenses.Controls.Add(this.tlpDescription, 0, 3);
            this.tblExpenses.Controls.Add(this.flpButtons, 1, 4);
            this.tblExpenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblExpenses.Location = new System.Drawing.Point(10, 10);
            this.tblExpenses.Name = "tblExpenses";
            this.tblExpenses.RowCount = 5;
            this.tblExpenses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblExpenses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblExpenses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblExpenses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblExpenses.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tblExpenses.Size = new System.Drawing.Size(692, 324);
            this.tblExpenses.TabIndex = 0;
            // 
            // tblDate
            // 
            this.tblDate.ColumnCount = 2;
            this.tblDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblDate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblDate.Controls.Add(this.lblToken, 1, 0);
            this.tblDate.Controls.Add(this.lblPaymentMethode, 0, 0);
            this.tblDate.Controls.Add(this.lblTokenValue, 1, 1);
            this.tblDate.Controls.Add(this.cmbPaymentMethod, 0, 1);
            this.tblDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblDate.Location = new System.Drawing.Point(3, 3);
            this.tblDate.Name = "tblDate";
            this.tblDate.RowCount = 2;
            this.tblDate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDate.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDate.Size = new System.Drawing.Size(340, 48);
            this.tblDate.TabIndex = 0;
            this.tblDate.Paint += new System.Windows.Forms.PaintEventHandler(this.tblDate_Paint);
            // 
            // lblToken
            // 
            this.lblToken.AutoSize = true;
            this.lblToken.Location = new System.Drawing.Point(209, 7);
            this.lblToken.Margin = new System.Windows.Forms.Padding(5, 7, 3, 0);
            this.lblToken.Name = "lblToken";
            this.lblToken.Size = new System.Drawing.Size(38, 13);
            this.lblToken.TabIndex = 3;
            this.lblToken.Text = "Token";
            // 
            // lblPaymentMethode
            // 
            this.lblPaymentMethode.AutoSize = true;
            this.lblPaymentMethode.Location = new System.Drawing.Point(5, 7);
            this.lblPaymentMethode.Margin = new System.Windows.Forms.Padding(5, 7, 3, 0);
            this.lblPaymentMethode.Name = "lblPaymentMethode";
            this.lblPaymentMethode.Size = new System.Drawing.Size(90, 13);
            this.lblPaymentMethode.TabIndex = 1;
            this.lblPaymentMethode.Text = "Payment Method:";
            // 
            // lblTokenValue
            // 
            this.lblTokenValue.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblTokenValue.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTokenValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTokenValue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTokenValue.Location = new System.Drawing.Point(209, 29);
            this.lblTokenValue.Margin = new System.Windows.Forms.Padding(5, 5, 3, 0);
            this.lblTokenValue.Name = "lblTokenValue";
            this.lblTokenValue.Size = new System.Drawing.Size(60, 19);
            this.lblTokenValue.TabIndex = 4;
            this.lblTokenValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbPaymentMethod
            // 
            this.cmbPaymentMethod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbPaymentMethod.FormattingEnabled = true;
            this.cmbPaymentMethod.Location = new System.Drawing.Point(3, 27);
            this.cmbPaymentMethod.Name = "cmbPaymentMethod";
            this.cmbPaymentMethod.Size = new System.Drawing.Size(198, 21);
            this.cmbPaymentMethod.TabIndex = 0;
            this.cmbPaymentMethod.SelectedIndexChanged += new System.EventHandler(this.cmbPaymentMethod_SelectedIndexChanged);
            // 
            // tblPayer
            // 
            this.tblPayer.ColumnCount = 2;
            this.tblPayer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.28571F));
            this.tblPayer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.71428F));
            this.tblPayer.Controls.Add(this.cmbPayer, 0, 1);
            this.tblPayer.Controls.Add(this.lblPayer, 0, 0);
            this.tblPayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPayer.Location = new System.Drawing.Point(3, 57);
            this.tblPayer.Name = "tblPayer";
            this.tblPayer.RowCount = 2;
            this.tblPayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPayer.Size = new System.Drawing.Size(340, 48);
            this.tblPayer.TabIndex = 1;
            // 
            // cmbPayer
            // 
            this.cmbPayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbPayer.FormattingEnabled = true;
            this.cmbPayer.Location = new System.Drawing.Point(3, 27);
            this.cmbPayer.Name = "cmbPayer";
            this.cmbPayer.Size = new System.Drawing.Size(266, 21);
            this.cmbPayer.TabIndex = 0;
            // 
            // lblPayer
            // 
            this.lblPayer.AutoSize = true;
            this.lblPayer.Location = new System.Drawing.Point(5, 7);
            this.lblPayer.Margin = new System.Windows.Forms.Padding(5, 7, 3, 0);
            this.lblPayer.Name = "lblPayer";
            this.lblPayer.Size = new System.Drawing.Size(37, 13);
            this.lblPayer.TabIndex = 1;
            this.lblPayer.Text = "Payer:";
            // 
            // tblPayee
            // 
            this.tblPayee.ColumnCount = 2;
            this.tblPayee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tblPayee.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblPayee.Controls.Add(this.lblPayee, 0, 0);
            this.tblPayee.Controls.Add(this.cmbPayee, 0, 1);
            this.tblPayee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPayee.Location = new System.Drawing.Point(349, 57);
            this.tblPayee.Name = "tblPayee";
            this.tblPayee.RowCount = 2;
            this.tblPayee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPayee.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPayee.Size = new System.Drawing.Size(340, 48);
            this.tblPayee.TabIndex = 2;
            // 
            // lblPayee
            // 
            this.lblPayee.AutoSize = true;
            this.lblPayee.Location = new System.Drawing.Point(5, 7);
            this.lblPayee.Margin = new System.Windows.Forms.Padding(5, 7, 3, 0);
            this.lblPayee.Name = "lblPayee";
            this.lblPayee.Size = new System.Drawing.Size(40, 13);
            this.lblPayee.TabIndex = 0;
            this.lblPayee.Text = "Payee:";
            // 
            // cmbPayee
            // 
            this.cmbPayee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbPayee.FormattingEnabled = true;
            this.cmbPayee.Location = new System.Drawing.Point(3, 27);
            this.cmbPayee.Name = "cmbPayee";
            this.cmbPayee.Size = new System.Drawing.Size(266, 21);
            this.cmbPayee.TabIndex = 1;
            // 
            // tlpAmount
            // 
            this.tlpAmount.ColumnCount = 2;
            this.tlpAmount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpAmount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpAmount.Controls.Add(this.lblAmount, 0, 0);
            this.tlpAmount.Controls.Add(this.txtAmount, 0, 1);
            this.tlpAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpAmount.Location = new System.Drawing.Point(3, 111);
            this.tlpAmount.Name = "tlpAmount";
            this.tlpAmount.RowCount = 2;
            this.tlpAmount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAmount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpAmount.Size = new System.Drawing.Size(340, 48);
            this.tlpAmount.TabIndex = 3;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(5, 7);
            this.lblAmount.Margin = new System.Windows.Forms.Padding(5, 7, 3, 0);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAmount.Location = new System.Drawing.Point(3, 27);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(266, 20);
            this.txtAmount.TabIndex = 1;
            // 
            // tlpPaymentMethod
            // 
            this.tlpPaymentMethod.ColumnCount = 2;
            this.tlpPaymentMethod.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpPaymentMethod.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpPaymentMethod.Controls.Add(this.dtpTransaction, 0, 1);
            this.tlpPaymentMethod.Controls.Add(this.lblDate, 0, 0);
            this.tlpPaymentMethod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPaymentMethod.Location = new System.Drawing.Point(349, 3);
            this.tlpPaymentMethod.Name = "tlpPaymentMethod";
            this.tlpPaymentMethod.RowCount = 2;
            this.tlpPaymentMethod.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPaymentMethod.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPaymentMethod.Size = new System.Drawing.Size(340, 48);
            this.tlpPaymentMethod.TabIndex = 4;
            // 
            // dtpTransaction
            // 
            this.dtpTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpTransaction.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTransaction.Location = new System.Drawing.Point(3, 27);
            this.dtpTransaction.Name = "dtpTransaction";
            this.dtpTransaction.Size = new System.Drawing.Size(198, 20);
            this.dtpTransaction.TabIndex = 2;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(5, 7);
            this.lblDate.Margin = new System.Windows.Forms.Padding(5, 7, 3, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date:";
            // 
            // tlpGst
            // 
            this.tlpGst.ColumnCount = 2;
            this.tlpGst.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpGst.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpGst.Controls.Add(this.lblGST, 0, 0);
            this.tlpGst.Controls.Add(this.txtGST, 0, 1);
            this.tlpGst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGst.Location = new System.Drawing.Point(349, 111);
            this.tlpGst.Name = "tlpGst";
            this.tlpGst.RowCount = 2;
            this.tlpGst.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGst.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGst.Size = new System.Drawing.Size(340, 48);
            this.tlpGst.TabIndex = 5;
            // 
            // lblGST
            // 
            this.lblGST.AutoSize = true;
            this.lblGST.Location = new System.Drawing.Point(5, 7);
            this.lblGST.Margin = new System.Windows.Forms.Padding(5, 7, 3, 0);
            this.lblGST.Name = "lblGST";
            this.lblGST.Size = new System.Drawing.Size(43, 13);
            this.lblGST.TabIndex = 0;
            this.lblGST.Text = "GST %:";
            // 
            // txtGST
            // 
            this.txtGST.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtGST.Location = new System.Drawing.Point(3, 27);
            this.txtGST.Name = "txtGST";
            this.txtGST.Size = new System.Drawing.Size(266, 20);
            this.txtGST.TabIndex = 1;
            // 
            // tlpDescription
            // 
            this.tlpDescription.ColumnCount = 1;
            this.tblExpenses.SetColumnSpan(this.tlpDescription, 2);
            this.tlpDescription.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpDescription.Controls.Add(this.lblDescription, 0, 0);
            this.tlpDescription.Controls.Add(this.txtDescription, 0, 1);
            this.tlpDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDescription.Location = new System.Drawing.Point(3, 165);
            this.tlpDescription.Name = "tlpDescription";
            this.tlpDescription.RowCount = 2;
            this.tlpDescription.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tlpDescription.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tlpDescription.Size = new System.Drawing.Size(686, 101);
            this.tlpDescription.TabIndex = 6;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(5, 6);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(5, 6, 3, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Descriptoin:";
            // 
            // txtDescription
            // 
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescription.Location = new System.Drawing.Point(3, 33);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(680, 65);
            this.txtDescription.TabIndex = 1;
            // 
            // flpButtons
            // 
            this.flpButtons.Controls.Add(this.btnSubmit);
            this.flpButtons.Controls.Add(this.btnCancel);
            this.flpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpButtons.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flpButtons.Location = new System.Drawing.Point(349, 272);
            this.flpButtons.Name = "flpButtons";
            this.flpButtons.Size = new System.Drawing.Size(340, 49);
            this.flpButtons.TabIndex = 7;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmit.Location = new System.Drawing.Point(262, 3);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 27);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(181, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 27);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // FrmDebitCreditExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(712, 344);
            this.Controls.Add(this.tblExpenses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDebitCreditExpenses";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "FrmDebitCreditExpenses";
            this.Load += new System.EventHandler(this.FrmDebitCreditExpenses_Load);
            this.tblExpenses.ResumeLayout(false);
            this.tblDate.ResumeLayout(false);
            this.tblDate.PerformLayout();
            this.tblPayer.ResumeLayout(false);
            this.tblPayer.PerformLayout();
            this.tblPayee.ResumeLayout(false);
            this.tblPayee.PerformLayout();
            this.tlpAmount.ResumeLayout(false);
            this.tlpAmount.PerformLayout();
            this.tlpPaymentMethod.ResumeLayout(false);
            this.tlpPaymentMethod.PerformLayout();
            this.tlpGst.ResumeLayout(false);
            this.tlpGst.PerformLayout();
            this.tlpDescription.ResumeLayout(false);
            this.tlpDescription.PerformLayout();
            this.flpButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblExpenses;
        private System.Windows.Forms.TableLayoutPanel tblDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpTransaction;
        private System.Windows.Forms.TableLayoutPanel tblPayer;
        private System.Windows.Forms.ComboBox cmbPayer;
        private System.Windows.Forms.Label lblPayer;
        private System.Windows.Forms.TableLayoutPanel tblPayee;
        private System.Windows.Forms.Label lblPayee;
        private System.Windows.Forms.ComboBox cmbPayee;
        private System.Windows.Forms.TableLayoutPanel tlpAmount;
        private System.Windows.Forms.TableLayoutPanel tlpPaymentMethod;
        private System.Windows.Forms.ComboBox cmbPaymentMethod;
        private System.Windows.Forms.Label lblPaymentMethode;
        private System.Windows.Forms.TableLayoutPanel tlpGst;
        private System.Windows.Forms.TableLayoutPanel tlpDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.FlowLayoutPanel flpButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblGST;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtGST;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblToken;
        private System.Windows.Forms.Label lblTokenValue;
    }
}