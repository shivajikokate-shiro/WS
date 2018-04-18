namespace WaterSystem_v1
{
    partial class FrmBillingInvoice
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
            this.pnlOuterContainer = new System.Windows.Forms.Panel();
            this.pnlBilling = new System.Windows.Forms.Panel();
            this.grpBilling = new System.Windows.Forms.GroupBox();
            this.txtCreditAmount = new System.Windows.Forms.TextBox();
            this.lblCreditAmount = new System.Windows.Forms.Label();
            this.txtPayAmount = new System.Windows.Forms.TextBox();
            this.pnlPayAmount = new System.Windows.Forms.Label();
            this.txtRound = new System.Windows.Forms.TextBox();
            this.lblRoundFigure = new System.Windows.Forms.Label();
            this.txtGSTAmt = new System.Windows.Forms.TextBox();
            this.lblGstAmount = new System.Windows.Forms.Label();
            this.txtGst = new System.Windows.Forms.TextBox();
            this.lblGst = new System.Windows.Forms.Label();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.pnlButtonsContainer = new System.Windows.Forms.Panel();
            this.pnlButtonsRight = new System.Windows.Forms.Panel();
            this.btnTransport = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpItems = new System.Windows.Forms.GroupBox();
            this.ovlItems = new BrightIdeasSoftware.ObjectListView();
            this.grpAddItem = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.cmbAddItem = new System.Windows.Forms.ComboBox();
            this.lblSelectItem = new System.Windows.Forms.Label();
            this.grpFirmInformation = new System.Windows.Forms.GroupBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtFirmNumber = new System.Windows.Forms.TextBox();
            this.lblFirmNumber = new System.Windows.Forms.Label();
            this.lblPending = new System.Windows.Forms.Label();
            this.cmbFirmName = new System.Windows.Forms.ComboBox();
            this.txtPending = new System.Windows.Forms.TextBox();
            this.lblFirmName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.lblInvoiceNo = new System.Windows.Forms.Label();
            this.txtAddr = new System.Windows.Forms.TextBox();
            this.pnlBillingType = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblPurchase = new System.Windows.Forms.Label();
            this.dtpBillingDate = new System.Windows.Forms.DateTimePicker();
            this.lblSales = new System.Windows.Forms.Label();
            this.toggleBilling = new JCS.ToggleSwitch();
            this.pnlOuterContainer.SuspendLayout();
            this.pnlBilling.SuspendLayout();
            this.grpBilling.SuspendLayout();
            this.pnlButtonsContainer.SuspendLayout();
            this.pnlButtonsRight.SuspendLayout();
            this.grpItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ovlItems)).BeginInit();
            this.grpAddItem.SuspendLayout();
            this.grpFirmInformation.SuspendLayout();
            this.pnlBillingType.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOuterContainer
            // 
            this.pnlOuterContainer.Controls.Add(this.pnlBilling);
            this.pnlOuterContainer.Controls.Add(this.pnlButtonsContainer);
            this.pnlOuterContainer.Controls.Add(this.grpItems);
            this.pnlOuterContainer.Controls.Add(this.grpAddItem);
            this.pnlOuterContainer.Controls.Add(this.grpFirmInformation);
            this.pnlOuterContainer.Controls.Add(this.pnlBillingType);
            this.pnlOuterContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlOuterContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlOuterContainer.Name = "pnlOuterContainer";
            this.pnlOuterContainer.Padding = new System.Windows.Forms.Padding(6);
            this.pnlOuterContainer.Size = new System.Drawing.Size(905, 617);
            this.pnlOuterContainer.TabIndex = 0;
            // 
            // pnlBilling
            // 
            this.pnlBilling.Controls.Add(this.grpBilling);
            this.pnlBilling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBilling.Location = new System.Drawing.Point(6, 392);
            this.pnlBilling.Name = "pnlBilling";
            this.pnlBilling.Size = new System.Drawing.Size(893, 172);
            this.pnlBilling.TabIndex = 4;
            // 
            // grpBilling
            // 
            this.grpBilling.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpBilling.Controls.Add(this.txtCreditAmount);
            this.grpBilling.Controls.Add(this.lblCreditAmount);
            this.grpBilling.Controls.Add(this.txtPayAmount);
            this.grpBilling.Controls.Add(this.pnlPayAmount);
            this.grpBilling.Controls.Add(this.txtRound);
            this.grpBilling.Controls.Add(this.lblRoundFigure);
            this.grpBilling.Controls.Add(this.txtGSTAmt);
            this.grpBilling.Controls.Add(this.lblGstAmount);
            this.grpBilling.Controls.Add(this.txtGst);
            this.grpBilling.Controls.Add(this.lblGst);
            this.grpBilling.Controls.Add(this.txtGrandTotal);
            this.grpBilling.Controls.Add(this.lblGrandTotal);
            this.grpBilling.Controls.Add(this.txtTotal);
            this.grpBilling.Controls.Add(this.lblTotal);
            this.grpBilling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBilling.Location = new System.Drawing.Point(0, 0);
            this.grpBilling.Name = "grpBilling";
            this.grpBilling.Size = new System.Drawing.Size(893, 172);
            this.grpBilling.TabIndex = 0;
            this.grpBilling.TabStop = false;
            this.grpBilling.Text = "Billing";
            // 
            // txtCreditAmount
            // 
            this.txtCreditAmount.Enabled = false;
            this.txtCreditAmount.Location = new System.Drawing.Point(665, 100);
            this.txtCreditAmount.Name = "txtCreditAmount";
            this.txtCreditAmount.Size = new System.Drawing.Size(203, 21);
            this.txtCreditAmount.TabIndex = 18;
            // 
            // lblCreditAmount
            // 
            this.lblCreditAmount.AutoSize = true;
            this.lblCreditAmount.Location = new System.Drawing.Point(661, 81);
            this.lblCreditAmount.Name = "lblCreditAmount";
            this.lblCreditAmount.Size = new System.Drawing.Size(84, 15);
            this.lblCreditAmount.TabIndex = 17;
            this.lblCreditAmount.Text = "Credit Amount";
            // 
            // txtPayAmount
            // 
            this.txtPayAmount.Location = new System.Drawing.Point(299, 100);
            this.txtPayAmount.Name = "txtPayAmount";
            this.txtPayAmount.Size = new System.Drawing.Size(245, 21);
            this.txtPayAmount.TabIndex = 16;
            this.txtPayAmount.TextChanged += new System.EventHandler(this.txtPayAmount_TextChanged);
            // 
            // pnlPayAmount
            // 
            this.pnlPayAmount.AutoSize = true;
            this.pnlPayAmount.Location = new System.Drawing.Point(295, 81);
            this.pnlPayAmount.Name = "pnlPayAmount";
            this.pnlPayAmount.Size = new System.Drawing.Size(72, 15);
            this.pnlPayAmount.TabIndex = 15;
            this.pnlPayAmount.Text = "Pay Amount";
            // 
            // txtRound
            // 
            this.txtRound.Location = new System.Drawing.Point(665, 45);
            this.txtRound.Name = "txtRound";
            this.txtRound.Size = new System.Drawing.Size(203, 21);
            this.txtRound.TabIndex = 14;
            this.txtRound.TextChanged += new System.EventHandler(this.txtRound_TextChanged);
            // 
            // lblRoundFigure
            // 
            this.lblRoundFigure.AutoSize = true;
            this.lblRoundFigure.Location = new System.Drawing.Point(661, 25);
            this.lblRoundFigure.Name = "lblRoundFigure";
            this.lblRoundFigure.Size = new System.Drawing.Size(82, 15);
            this.lblRoundFigure.TabIndex = 13;
            this.lblRoundFigure.Text = "Round Figure";
            // 
            // txtGSTAmt
            // 
            this.txtGSTAmt.Enabled = false;
            this.txtGSTAmt.Location = new System.Drawing.Point(421, 45);
            this.txtGSTAmt.Name = "txtGSTAmt";
            this.txtGSTAmt.Size = new System.Drawing.Size(123, 21);
            this.txtGSTAmt.TabIndex = 12;
            // 
            // lblGstAmount
            // 
            this.lblGstAmount.AutoSize = true;
            this.lblGstAmount.Location = new System.Drawing.Point(418, 27);
            this.lblGstAmount.Name = "lblGstAmount";
            this.lblGstAmount.Size = new System.Drawing.Size(70, 15);
            this.lblGstAmount.TabIndex = 11;
            this.lblGstAmount.Text = "Gst Amount";
            // 
            // txtGst
            // 
            this.txtGst.Enabled = false;
            this.txtGst.Location = new System.Drawing.Point(299, 45);
            this.txtGst.Name = "txtGst";
            this.txtGst.Size = new System.Drawing.Size(90, 21);
            this.txtGst.TabIndex = 10;
            // 
            // lblGst
            // 
            this.lblGst.AutoSize = true;
            this.lblGst.Location = new System.Drawing.Point(295, 27);
            this.lblGst.Name = "lblGst";
            this.lblGst.Size = new System.Drawing.Size(45, 15);
            this.lblGst.TabIndex = 9;
            this.lblGst.Text = "GST %";
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Enabled = false;
            this.txtGrandTotal.Location = new System.Drawing.Point(26, 102);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.Size = new System.Drawing.Size(140, 21);
            this.txtGrandTotal.TabIndex = 8;
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.Location = new System.Drawing.Point(22, 82);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(71, 15);
            this.lblGrandTotal.TabIndex = 7;
            this.lblGrandTotal.Text = "Grand Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(26, 46);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(140, 21);
            this.txtTotal.TabIndex = 6;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(22, 27);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 15);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total";
            // 
            // pnlButtonsContainer
            // 
            this.pnlButtonsContainer.Controls.Add(this.pnlButtonsRight);
            this.pnlButtonsContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtonsContainer.Location = new System.Drawing.Point(6, 564);
            this.pnlButtonsContainer.Name = "pnlButtonsContainer";
            this.pnlButtonsContainer.Size = new System.Drawing.Size(893, 47);
            this.pnlButtonsContainer.TabIndex = 4;
            // 
            // pnlButtonsRight
            // 
            this.pnlButtonsRight.Controls.Add(this.btnTransport);
            this.pnlButtonsRight.Controls.Add(this.btnPayment);
            this.pnlButtonsRight.Controls.Add(this.btnSubmit);
            this.pnlButtonsRight.Controls.Add(this.btnClose);
            this.pnlButtonsRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlButtonsRight.Location = new System.Drawing.Point(421, 0);
            this.pnlButtonsRight.Name = "pnlButtonsRight";
            this.pnlButtonsRight.Size = new System.Drawing.Size(472, 47);
            this.pnlButtonsRight.TabIndex = 0;
            // 
            // btnTransport
            // 
            this.btnTransport.BackColor = System.Drawing.Color.Blue;
            this.btnTransport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTransport.Location = new System.Drawing.Point(18, 9);
            this.btnTransport.Name = "btnTransport";
            this.btnTransport.Size = new System.Drawing.Size(92, 30);
            this.btnTransport.TabIndex = 3;
            this.btnTransport.Text = "Transport";
            this.btnTransport.UseVisualStyleBackColor = false;
            this.btnTransport.Click += new System.EventHandler(this.btnTransport_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPayment.Location = new System.Drawing.Point(131, 9);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(92, 30);
            this.btnPayment.TabIndex = 2;
            this.btnPayment.Text = "Payment";
            this.btnPayment.UseVisualStyleBackColor = false;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.ForestGreen;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmit.Location = new System.Drawing.Point(244, 9);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(92, 30);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(355, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(92, 30);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // grpItems
            // 
            this.grpItems.Controls.Add(this.ovlItems);
            this.grpItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpItems.Location = new System.Drawing.Point(6, 252);
            this.grpItems.Name = "grpItems";
            this.grpItems.Size = new System.Drawing.Size(893, 140);
            this.grpItems.TabIndex = 3;
            this.grpItems.TabStop = false;
            this.grpItems.Text = "Items";
            // 
            // ovlItems
            // 
            this.ovlItems.CellEditUseWholeCell = false;
            this.ovlItems.Cursor = System.Windows.Forms.Cursors.Default;
            this.ovlItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ovlItems.Location = new System.Drawing.Point(3, 17);
            this.ovlItems.Name = "ovlItems";
            this.ovlItems.Size = new System.Drawing.Size(887, 120);
            this.ovlItems.TabIndex = 0;
            this.ovlItems.UseCompatibleStateImageBehavior = false;
            this.ovlItems.View = System.Windows.Forms.View.Details;
            // 
            // grpAddItem
            // 
            this.grpAddItem.Controls.Add(this.btnDelete);
            this.grpAddItem.Controls.Add(this.btnAdd);
            this.grpAddItem.Controls.Add(this.txtAmount);
            this.grpAddItem.Controls.Add(this.lblAmount);
            this.grpAddItem.Controls.Add(this.txtRate);
            this.grpAddItem.Controls.Add(this.lblRate);
            this.grpAddItem.Controls.Add(this.txtQuantity);
            this.grpAddItem.Controls.Add(this.lblQuantity);
            this.grpAddItem.Controls.Add(this.cmbAddItem);
            this.grpAddItem.Controls.Add(this.lblSelectItem);
            this.grpAddItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpAddItem.Location = new System.Drawing.Point(6, 175);
            this.grpAddItem.Name = "grpAddItem";
            this.grpAddItem.Size = new System.Drawing.Size(893, 77);
            this.grpAddItem.TabIndex = 2;
            this.grpAddItem.TabStop = false;
            this.grpAddItem.Text = "Add Item";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(782, 37);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 27);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(164)))), ((int)(((byte)(226)))));
            this.btnAdd.Enabled = false;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAdd.Location = new System.Drawing.Point(675, 37);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 27);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Enabled = false;
            this.txtAmount.Location = new System.Drawing.Point(485, 43);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(123, 21);
            this.txtAmount.TabIndex = 8;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(482, 23);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(49, 15);
            this.lblAmount.TabIndex = 7;
            this.lblAmount.Text = "Amount";
            // 
            // txtRate
            // 
            this.txtRate.Enabled = false;
            this.txtRate.Location = new System.Drawing.Point(363, 42);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(90, 21);
            this.txtRate.TabIndex = 6;
            this.txtRate.TextChanged += new System.EventHandler(this.txtRate_TextChanged);
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(359, 23);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(33, 15);
            this.lblRate.TabIndex = 0;
            this.lblRate.Text = "Rate";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Enabled = false;
            this.txtQuantity.Location = new System.Drawing.Point(199, 42);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(110, 21);
            this.txtQuantity.TabIndex = 5;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(196, 22);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(51, 15);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Quantity";
            // 
            // cmbAddItem
            // 
            this.cmbAddItem.FormattingEnabled = true;
            this.cmbAddItem.Location = new System.Drawing.Point(26, 42);
            this.cmbAddItem.Name = "cmbAddItem";
            this.cmbAddItem.Size = new System.Drawing.Size(140, 23);
            this.cmbAddItem.TabIndex = 1;
            this.cmbAddItem.SelectedIndexChanged += new System.EventHandler(this.cmbAddItem_SelectedIndexChanged);
            // 
            // lblSelectItem
            // 
            this.lblSelectItem.AutoSize = true;
            this.lblSelectItem.Location = new System.Drawing.Point(22, 22);
            this.lblSelectItem.Name = "lblSelectItem";
            this.lblSelectItem.Size = new System.Drawing.Size(68, 15);
            this.lblSelectItem.TabIndex = 0;
            this.lblSelectItem.Text = "Select Item";
            // 
            // grpFirmInformation
            // 
            this.grpFirmInformation.Controls.Add(this.lblContact);
            this.grpFirmInformation.Controls.Add(this.txtContact);
            this.grpFirmInformation.Controls.Add(this.txtFirmNumber);
            this.grpFirmInformation.Controls.Add(this.lblFirmNumber);
            this.grpFirmInformation.Controls.Add(this.lblPending);
            this.grpFirmInformation.Controls.Add(this.cmbFirmName);
            this.grpFirmInformation.Controls.Add(this.txtPending);
            this.grpFirmInformation.Controls.Add(this.lblFirmName);
            this.grpFirmInformation.Controls.Add(this.lblAddress);
            this.grpFirmInformation.Controls.Add(this.txtInvoiceNo);
            this.grpFirmInformation.Controls.Add(this.lblInvoiceNo);
            this.grpFirmInformation.Controls.Add(this.txtAddr);
            this.grpFirmInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpFirmInformation.Location = new System.Drawing.Point(6, 35);
            this.grpFirmInformation.Name = "grpFirmInformation";
            this.grpFirmInformation.Size = new System.Drawing.Size(893, 140);
            this.grpFirmInformation.TabIndex = 1;
            this.grpFirmInformation.TabStop = false;
            this.grpFirmInformation.Text = "Firm Information";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Location = new System.Drawing.Point(160, 84);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(48, 15);
            this.lblContact.TabIndex = 1;
            this.lblContact.Text = "Contact";
            // 
            // txtContact
            // 
            this.txtContact.Enabled = false;
            this.txtContact.Location = new System.Drawing.Point(163, 100);
            this.txtContact.Margin = new System.Windows.Forms.Padding(8);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(126, 21);
            this.txtContact.TabIndex = 5;
            // 
            // txtFirmNumber
            // 
            this.txtFirmNumber.Enabled = false;
            this.txtFirmNumber.Location = new System.Drawing.Point(21, 100);
            this.txtFirmNumber.Name = "txtFirmNumber";
            this.txtFirmNumber.Size = new System.Drawing.Size(119, 21);
            this.txtFirmNumber.TabIndex = 4;
            // 
            // lblFirmNumber
            // 
            this.lblFirmNumber.AutoSize = true;
            this.lblFirmNumber.Location = new System.Drawing.Point(18, 84);
            this.lblFirmNumber.Margin = new System.Windows.Forms.Padding(3);
            this.lblFirmNumber.Name = "lblFirmNumber";
            this.lblFirmNumber.Size = new System.Drawing.Size(80, 15);
            this.lblFirmNumber.TabIndex = 2;
            this.lblFirmNumber.Text = "Firm Number";
            // 
            // lblPending
            // 
            this.lblPending.AutoSize = true;
            this.lblPending.Location = new System.Drawing.Point(328, 84);
            this.lblPending.Margin = new System.Windows.Forms.Padding(3);
            this.lblPending.Name = "lblPending";
            this.lblPending.Size = new System.Drawing.Size(53, 15);
            this.lblPending.TabIndex = 8;
            this.lblPending.Text = "Pending";
            // 
            // cmbFirmName
            // 
            this.cmbFirmName.FormattingEnabled = true;
            this.cmbFirmName.Location = new System.Drawing.Point(21, 49);
            this.cmbFirmName.Margin = new System.Windows.Forms.Padding(8);
            this.cmbFirmName.Name = "cmbFirmName";
            this.cmbFirmName.Size = new System.Drawing.Size(268, 23);
            this.cmbFirmName.TabIndex = 3;
            this.cmbFirmName.SelectedIndexChanged += new System.EventHandler(this.cmbFirmName_SelectedIndexChanged);
            // 
            // txtPending
            // 
            this.txtPending.BackColor = System.Drawing.Color.Pink;
            this.txtPending.Enabled = false;
            this.txtPending.Location = new System.Drawing.Point(328, 100);
            this.txtPending.Margin = new System.Windows.Forms.Padding(8);
            this.txtPending.Name = "txtPending";
            this.txtPending.Size = new System.Drawing.Size(245, 21);
            this.txtPending.TabIndex = 9;
            // 
            // lblFirmName
            // 
            this.lblFirmName.AutoSize = true;
            this.lblFirmName.Location = new System.Drawing.Point(18, 29);
            this.lblFirmName.Margin = new System.Windows.Forms.Padding(3);
            this.lblFirmName.Name = "lblFirmName";
            this.lblFirmName.Size = new System.Drawing.Size(69, 15);
            this.lblFirmName.TabIndex = 0;
            this.lblFirmName.Text = "Firm Name";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(624, 29);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(3);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(51, 15);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "Address";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Enabled = false;
            this.txtInvoiceNo.Location = new System.Drawing.Point(328, 49);
            this.txtInvoiceNo.Margin = new System.Windows.Forms.Padding(8);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(245, 21);
            this.txtInvoiceNo.TabIndex = 7;
            // 
            // lblInvoiceNo
            // 
            this.lblInvoiceNo.AutoSize = true;
            this.lblInvoiceNo.Location = new System.Drawing.Point(328, 29);
            this.lblInvoiceNo.Margin = new System.Windows.Forms.Padding(3);
            this.lblInvoiceNo.Name = "lblInvoiceNo";
            this.lblInvoiceNo.Size = new System.Drawing.Size(67, 15);
            this.lblInvoiceNo.TabIndex = 6;
            this.lblInvoiceNo.Text = "Invoice No.";
            // 
            // txtAddr
            // 
            this.txtAddr.Enabled = false;
            this.txtAddr.Location = new System.Drawing.Point(627, 49);
            this.txtAddr.Margin = new System.Windows.Forms.Padding(10);
            this.txtAddr.Multiline = true;
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.Size = new System.Drawing.Size(245, 72);
            this.txtAddr.TabIndex = 11;
            // 
            // pnlBillingType
            // 
            this.pnlBillingType.Controls.Add(this.lblDate);
            this.pnlBillingType.Controls.Add(this.lblPurchase);
            this.pnlBillingType.Controls.Add(this.dtpBillingDate);
            this.pnlBillingType.Controls.Add(this.lblSales);
            this.pnlBillingType.Controls.Add(this.toggleBilling);
            this.pnlBillingType.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBillingType.Location = new System.Drawing.Point(6, 6);
            this.pnlBillingType.Name = "pnlBillingType";
            this.pnlBillingType.Size = new System.Drawing.Size(893, 29);
            this.pnlBillingType.TabIndex = 0;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(655, 7);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(67, 15);
            this.lblDate.TabIndex = 13;
            this.lblDate.Text = "BillingDate";
            // 
            // lblPurchase
            // 
            this.lblPurchase.AutoSize = true;
            this.lblPurchase.Location = new System.Drawing.Point(443, 6);
            this.lblPurchase.Name = "lblPurchase";
            this.lblPurchase.Size = new System.Drawing.Size(59, 15);
            this.lblPurchase.TabIndex = 2;
            this.lblPurchase.Text = "Purchase";
            // 
            // dtpBillingDate
            // 
            this.dtpBillingDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBillingDate.Location = new System.Drawing.Point(750, 4);
            this.dtpBillingDate.Name = "dtpBillingDate";
            this.dtpBillingDate.Size = new System.Drawing.Size(102, 21);
            this.dtpBillingDate.TabIndex = 12;
            // 
            // lblSales
            // 
            this.lblSales.AutoSize = true;
            this.lblSales.Location = new System.Drawing.Point(340, 5);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(38, 15);
            this.lblSales.TabIndex = 1;
            this.lblSales.Text = "Sales";
            // 
            // toggleBilling
            // 
            this.toggleBilling.Location = new System.Drawing.Point(384, 5);
            this.toggleBilling.Name = "toggleBilling";
            this.toggleBilling.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleBilling.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleBilling.Size = new System.Drawing.Size(50, 19);
            this.toggleBilling.Style = JCS.ToggleSwitch.ToggleSwitchStyle.Iphone;
            this.toggleBilling.TabIndex = 0;
            this.toggleBilling.CheckedChanged += new JCS.ToggleSwitch.CheckedChangedDelegate(this.toggleBilling_CheckedChanged);
            // 
            // FrmBillingInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(905, 617);
            this.Controls.Add(this.pnlOuterContainer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBillingInvoice";
            this.Text = "FrmBillingInvoice";
            this.Load += new System.EventHandler(this.FrmBillingInvoice_Load);
            this.pnlOuterContainer.ResumeLayout(false);
            this.pnlBilling.ResumeLayout(false);
            this.grpBilling.ResumeLayout(false);
            this.grpBilling.PerformLayout();
            this.pnlButtonsContainer.ResumeLayout(false);
            this.pnlButtonsRight.ResumeLayout(false);
            this.grpItems.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ovlItems)).EndInit();
            this.grpAddItem.ResumeLayout(false);
            this.grpAddItem.PerformLayout();
            this.grpFirmInformation.ResumeLayout(false);
            this.grpFirmInformation.PerformLayout();
            this.pnlBillingType.ResumeLayout(false);
            this.pnlBillingType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOuterContainer;
        private System.Windows.Forms.Panel pnlBillingType;
        private System.Windows.Forms.GroupBox grpItems;
        private System.Windows.Forms.GroupBox grpAddItem;
        private System.Windows.Forms.GroupBox grpFirmInformation;
        private System.Windows.Forms.Panel pnlBilling;
        private System.Windows.Forms.TextBox txtFirmNumber;
        private System.Windows.Forms.ComboBox cmbFirmName;
        private System.Windows.Forms.Label lblFirmNumber;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblFirmName;
        private System.Windows.Forms.Label lblPending;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Label lblInvoiceNo;
        private System.Windows.Forms.TextBox txtAddr;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.ComboBox cmbAddItem;
        private System.Windows.Forms.Label lblSelectItem;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private BrightIdeasSoftware.ObjectListView ovlItems;
        private System.Windows.Forms.GroupBox grpBilling;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtGrandTotal;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.TextBox txtPayAmount;
        private System.Windows.Forms.Label pnlPayAmount;
        private System.Windows.Forms.TextBox txtRound;
        private System.Windows.Forms.Label lblRoundFigure;
        private System.Windows.Forms.TextBox txtGSTAmt;
        private System.Windows.Forms.Label lblGstAmount;
        private System.Windows.Forms.TextBox txtGst;
        private System.Windows.Forms.Label lblGst;
        private System.Windows.Forms.TextBox txtCreditAmount;
        private System.Windows.Forms.Label lblCreditAmount;
        private System.Windows.Forms.Panel pnlButtonsContainer;
        private System.Windows.Forms.Panel pnlButtonsRight;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnTransport;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Label lblPurchase;
        private System.Windows.Forms.Label lblSales;
        private JCS.ToggleSwitch toggleBilling;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpBillingDate;
        private System.Windows.Forms.TextBox txtPending;
        private System.Windows.Forms.TextBox txtContact;
    }
}