using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaterSystem_Manager.Receiver;
using WaterSystem_Model;
using WaterSystem_v1.Helpers;
using WaterSystem_v1.Logs;

namespace WaterSystem_v1
{
    public partial class FrmBillingInvoice : Form
    {
        SalesInvoiceReciever salesReciever = null;
        PurchaseInvoiceReciever purchaseReciever = null;
        ReportReciever reportReciever = null;
        IEnumerable<CustomerModel> customers = null;
        IEnumerable<SupplierModel> suppliers = null;
        PaymentTransactionModel paymentTransactionModel = null;
        SalesTransportModel transportationModel = null;
        static int salesType = 1;
        static int purchaseType = 2;
        public FrmBillingInvoice()
        {
            InitializeComponent();
        }

        private void FrmBillingInvoice_Load(object sender, EventArgs e)
        {
            Logger.Info("Loading BillingInvoice");
            reportReciever = new ReportReciever();
            txtGst.Text = Math.Round(Convert.ToDouble(CalculationHelper._gstPercent), 2).ToString();
            LoadBasics();
            ConfigureItems();
            Logger.Info("Loading BillingInvoice success");
        }

        private void LoadBasics()
        {
            try
            {
                if (toggleBilling.Checked)
                {
                    Logger.Info("Loading purchase details.");
                    LoadPurchase();
                    ResetFirmInformation();
                    ControlConfiguration(false);
                    Logger.Info("Loading purchase details success.");
                }
                else
                {
                    Logger.Info("Loading sales details.");
                    LoadSales();
                    ResetFirmInformation();
                    ControlConfiguration(true);
                    Logger.Info("Loading sales details success.");
                }

                ResetItem();
                ResetItemList();
                ResetFirmInformation();
                ResetBillingInformation();
            }
            catch (Exception ex)
            {
                Logger.Error("Error in billing invoice load basics.", ex);
            }
        }

        private void ControlConfiguration(bool salesBilling)
        {
            if (salesBilling)
            {
                btnPayment.Visible = true;
                btnTransport.Visible = true;
                lblRoundFigure.Visible = true;
                txtRound.Visible = true;
                btnTransport.Visible = true;
                txtInvoiceNo.Enabled = false;
            }
            else
            {
                btnTransport.Visible = false;
                txtInvoiceNo.Enabled = true;
                txtInvoiceNo.Text = string.Empty;
                lblRoundFigure.Visible = false;
                txtRound.Visible = false;
                btnTransport.Visible = false;
            }
        }

        private void LoadSales()
        {
            Helpers.DataHelper helper = new Helpers.DataHelper();
            salesReciever = new SalesInvoiceReciever();
            //Fill customers
            if (customers == null)
            {
                Logger.Info("Retrieving customers");
                customers = salesReciever.GetCustomers();
                Logger.Info("Retrieving customers success.");
            }
            var customerDataList = customers.Select(x => new DropDown { Name = x.Comp_Name, Value = x.Customer_Id.ToString() }).ToList();
            customerDataList.Insert(0, new DropDown { Name = "--Select--", Value = "0" });
            helper.FillCombo(cmbFirmName, customerDataList);
            cmbFirmName.SelectedIndex = 0;
            Logger.Info("Customers list fill success.");

            //Fill Items
            Logger.Info("Retrieving Items");
            var items = salesReciever.GetItems();
            Logger.Info("Retrieving Items success.");
            var itemDataList = items.Select(x => new DropDown { Name = x.ItemName, Value = x.ItemId.ToString() }).ToList();
            itemDataList.Insert(0, new DropDown { Name = "--Select--", Value = "0" });
            helper.FillCombo(cmbAddItem, itemDataList);
            cmbAddItem.SelectedIndex = 0;
            Logger.Info("Items list fill success.");

            txtInvoiceNo.Text = salesReciever.GetInvoiceNumber();
            Logger.Info(string.Format("Retrieved Invoice number {0}", txtInvoiceNo.Text));
        }

        private CustomerModel GetCustomer(string customerId)
        {
            CustomerModel customer = null;
            if (customers == null)
            {
                customers = salesReciever.GetCustomers();
            }

            if (customers != null)
            {
                customer = customers.Where(x => x.Customer_Id.ToString().Equals(customerId)).FirstOrDefault();
            }

            return customer;
        }

        private void LoadPurchase()
        {
            Helpers.DataHelper helper = new Helpers.DataHelper();
            purchaseReciever = new PurchaseInvoiceReciever();
            if (suppliers == null)
            {
                Logger.Info("Retrieving suppliers.");
                suppliers = purchaseReciever.GetSuppliers();
                Logger.Info("Retrieving suppliers success.");
            }

            var supplierList = suppliers.Select(x => new DropDown { Name = x.Comp_Name, Value = x.Supplier_Id.ToString() }).ToList();
            supplierList.Insert(0, new DropDown() { Name = "--Select--", Value = 0.ToString() });
            helper.FillCombo(cmbFirmName, supplierList);
            cmbFirmName.SelectedIndex = 0;

            Logger.Info("Retrieving items.");
            var items = purchaseReciever.GetItems();
            Logger.Info("Retrieving items success.");

            var itemsList = items.Select(x => new DropDown { Name = x.RowMaterialName, Value = x.RowMaterialId.ToString() }).ToList();
            itemsList.Insert(0, new DropDown() { Name = "--Select--", Value = 0.ToString() });
            helper.FillCombo(cmbAddItem, itemsList);
            cmbAddItem.SelectedIndex = 0;
        }

        private void cmbFirmName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Logger.Info("Firm name changed.");
                var firmId = (cmbFirmName.SelectedItem as DropDown).Value;
                ConfigureFirmInformation(firmId);
                if (Convert.ToInt32(firmId) > 0)
                {
                    grpAddItem.Enabled = true;
                    pnlButtonsRight.Enabled = true;
                }
                else
                {
                    grpAddItem.Enabled = false;
                    pnlButtonsRight.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                Logger.Error("Error in firm name change.", ex);
            }
        }

        private void ConfigureFirmInformation(string firmId)
        {
            if (toggleBilling.Checked)
            {
                var firm = GetSupplier(firmId);
                if (firm != null)
                {
                    var firmsID = Convert.ToInt32(firmId);
                    double pendingAmount = 0;
                    if (firmsID > 0)
                    {
                        Logger.Info(string.Format("Purchase: Retrieving pending amount for {0}.", firm.Comp_Name));
                        pendingAmount = reportReciever.RetrivePendingAmountByCustomer(firmsID, purchaseType);
                        Logger.Info(string.Format("Purchase: Retrieving pending amount success {0}.", txtPending.Text));
                    }
                    txtPending.Text = pendingAmount.ToString();
                    txtAddr.Text = firm.Address;
                    txtContact.Text = firm.Supplier_Mobileno.ToString().Trim();
                    txtFirmNumber.Text = firm.SupplierNo.ToString();
                }
            }
            else
            {
                var firm = GetCustomer(firmId);
                if (firm != null)
                {
                    var firmsID = Convert.ToInt32(firmId);
                    double pendingAmount = 0;
                    if (firmsID > 0)
                    {
                        Logger.Info(string.Format("Sales: Retrieving pending amount for {0}.", firm.Comp_Name));
                        pendingAmount = reportReciever.RetrivePendingAmountByCustomer(firmsID, salesType);
                        Logger.Info(string.Format("Sales: Retrieving pending amount success {0}.", txtPending.Text));
                    }
                    txtPending.Text = pendingAmount.ToString();
                    txtAddr.Text = firm.Address;
                    txtContact.Text = firm.Cust_Mobileno.ToString().Trim();
                    txtFirmNumber.Text = firm.Customer_No.ToString();
                    txtPending.Text = pendingAmount.ToString();
                }
            }
        }

        private SupplierModel GetSupplier(string supplierId)
        {
            SupplierModel supplier = null;
            if (suppliers != null && suppliers.Any())
            {
                supplier = suppliers.Where(x => x.Supplier_Id == Convert.ToInt32(supplierId)).FirstOrDefault();
            }
            return supplier;
        }

        private void toggleBilling_CheckedChanged(object sender, EventArgs e)
        {
            LoadBasics();
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtQuantity.Text) && !string.IsNullOrWhiteSpace(txtQuantity.Text) && !string.IsNullOrEmpty(txtRate.Text))
            {
                txtAmount.Text = CalculateItemAmount(toggleBilling.Checked).ToString();
            }
        }
        
        private double CalculateItemAmount(bool purchase)
        {
            double amt = 0;
            if (!string.IsNullOrEmpty(txtQuantity.Text) && !string.IsNullOrWhiteSpace(txtQuantity.Text) && !string.IsNullOrEmpty(txtRate.Text))
            {
                double rate = Convert.ToDouble(txtRate.Text);
                int quantity = Convert.ToInt32(txtQuantity.Text);
                if (!purchase)
                {
                    amt = (CalculationHelper.AmountRemovingGST(rate)) * quantity;
                }
                else
                {
                    amt = rate * quantity;
                }
            }
            return amt;
        }

        private void txtRate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var calculatedAmount = CalculateItemAmount(toggleBilling.Checked);
                txtAmount.Text = calculatedAmount != 0 ? calculatedAmount.ToString() : string.Empty;
            }
            catch (Exception ex)
            {
                Logger.Error("Error in amount calculation.", ex);
            }
        }

        private void cmbAddItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool enable = false;
            if (cmbAddItem.SelectedIndex > 0)
            {
                enable = true;
            }
            AvailAmountProcess(enable);
        }

        private void AvailAmountProcess(bool enable)
        {
            txtQuantity.Enabled = enable;
            txtRate.Enabled = enable;
            btnAdd.Enabled = enable;
        }

        private void ConfigureItems()
        {
            ovlItems.Clear();
            ovlItems.RowHeight = 25;
            ovlItems.EmptyListMsg = "No items added.";
            ovlItems.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ovlItems.ShowGroups = false;
            ovlItems.CheckBoxes = true;

            DataHelper helper = new DataHelper();
            List<ListViewColumnsInfo> list = new List<ListViewColumnsInfo>();
            list.Add(new ListViewColumnsInfo() { ColumnSize = 50, Header = helper.GetMemberName((BillingItemModel c) => c.SrNo), Visible = true });
            list.Add(new ListViewColumnsInfo() { ColumnSize = 450, Header = helper.GetMemberName((BillingItemModel c) => c.ProductName), Visible = true });
            list.Add(new ListViewColumnsInfo() { ColumnSize = 90, Header = helper.GetMemberName((BillingItemModel c) => c.Quantity), Visible = true });
            list.Add(new ListViewColumnsInfo() { ColumnSize = 100, Header = helper.GetMemberName((BillingItemModel c) => c.Rate), Visible = true });
            list.Add(new ListViewColumnsInfo() { ColumnSize = 150, Header = helper.GetMemberName((BillingItemModel c) => c.Total), Visible = true });
            list.Add(new ListViewColumnsInfo() { ColumnSize = 150, Header = helper.GetMemberName((BillingItemModel c) => c.ProductValue), Visible = false });
            helper.GenerateListView(ovlItems, list);

            this.ovlItems.ItemChecked += delegate (object sender, ItemCheckedEventArgs args)
            {
                if (this.ovlItems.CheckedObjects.Count > 0)
                {
                    btnDelete.Enabled = true;
                }
                else
                {
                    btnDelete.Enabled = false;
                }
            };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                AddItem();
                CalculateBilling();
                CalculateCreditAmount();
                ResetItem();
            }
            catch (Exception ex)
            {
                Logger.Error("Error in add item.", ex);
            }
        }

        private void ResetItem()
        {
            Logger.Info("Reset item section.");
            cmbAddItem.SelectedIndex = 0;
            txtQuantity.Text = string.Empty;
            txtRate.Text = string.Empty;
            txtAmount.Text = string.Empty;
        }

        private void ResetFirmInformation()
        {
            Logger.Info("Reset firm information.");
            txtAddr.Text = string.Empty;
            txtContact.Text = string.Empty;
            txtPending.Text = string.Empty;
            txtFirmNumber.Text = string.Empty;
        }

        private void ResetBillingInformation()
        {
            Logger.Info("Reset billing information.");
            txtTotal.Text = string.Empty;
            txtGSTAmt.Text = string.Empty;
            txtRound.Text = string.Empty;
            txtGrandTotal.Text = string.Empty;
            txtPayAmount.Text = string.Empty;
            txtCreditAmount.Text = string.Empty;
        }

        private void ResetItemList()
        {
            Logger.Info("Reset items list.");
            ovlItems.ClearObjects();
        }

        private void ResetPaymentMode()
        {
            Logger.Info("Reset payment mode information.");
            transportationModel = null;
        }

        private void ResetTransportationDetails()
        {
            Logger.Info("Reset transportation information.");
            paymentTransactionModel = null;
        }

        private void CalculateBilling()
        {
            try
            {
                txtTotal.Text = ovlItems.Objects.Cast<BillingItemModel>().Sum(x => x.Total).ToString();
                txtGSTAmt.Text = CalculationHelper.CalculateGST(Convert.ToDouble(txtTotal.Text)).ToString();
                var grandTotal = GetGrandTotal();
                txtGrandTotal.Text = grandTotal.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error("Error in billing calculation.", ex);
            }            
        }

        private double GetGrandTotal()
        {
            double grandAmount = 0;
            if (!String.IsNullOrEmpty(txtGSTAmt.Text) && !String.IsNullOrEmpty(txtTotal.Text))
            {
                grandAmount = Math.Ceiling(Convert.ToDouble(txtTotal.Text) + Convert.ToDouble(txtGSTAmt.Text));
            }
            return grandAmount;
        }

        private void AddItem()
        {
            try
            {
                Logger.Info("Add item start.");
                var selectedItem = cmbAddItem.SelectedItem as DropDown;
                bool addNew = true;
                if (ovlItems.GetItemCount() > 0)
                {
                    var items = ovlItems.Objects.Cast<BillingItemModel>().ToList();
                    var rate = toggleBilling.Checked ? Convert.ToDouble(txtRate.Text) : CalculationHelper.AmountRemovingGST(Convert.ToDouble(txtRate.Text));

                    items = items.Where(x => x.ProductValue == selectedItem.Value && x.Rate == rate).ToList();
                    if (items.Any())
                    {
                        var existingItem = items.First();
                        existingItem.Quantity += Convert.ToInt32(txtQuantity.Text);
                        existingItem.Total += CalculationHelper.RoundAmount(CalculateItemAmount(toggleBilling.Checked));
                        addNew = false;
                        ovlItems.UpdateObject(existingItem);
                        Logger.Info(string.Format("Added item {0} in existing entry.", existingItem.ProductName));
                    }
                }

                if (addNew)
                {
                    BillingItemModel salesItem = new BillingItemModel();
                    salesItem.SrNo = ovlItems.Items.Count + 1;
                    salesItem.ProductName = selectedItem.Name.ToString();
                    salesItem.Quantity = Convert.ToInt32(txtQuantity.Text);
                    salesItem.Rate = toggleBilling.Checked ? Convert.ToDouble(txtRate.Text) : CalculationHelper.AmountRemovingGST(Convert.ToDouble(txtRate.Text));
                    salesItem.Total = CalculationHelper.RoundAmount(CalculateItemAmount(toggleBilling.Checked));
                    salesItem.ProductValue = selectedItem.Value.ToString();
                    // Add in items list.
                    ovlItems.AddObject(salesItem);
                    Logger.Info(string.Format("Added item {0} in items list.", salesItem.ProductName));
                }
                txtRound.Text = string.Empty;
                Logger.Info("Add item success.");
            }
            catch (Exception ex)
            {
                Logger.Error("Error in add item.");
                throw ex;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Logger.Info("Delete items start.");
                RemoveItem();
                CalculateBilling();
                CalculateCreditAmount();
                Logger.Info("Delete items success.");
            }
            catch (Exception ex)
            {
                Logger.Error("Error in delete items.", ex);
            }
        }

        private void RemoveItem()
        {
            ovlItems.RemoveObjects(ovlItems.CheckedObjects);

            // Update serial of items
            var remainingItems = ovlItems.Objects.Cast<BillingItemModel>().ToList();
            var index = 1;
            remainingItems.ForEach(x => { x.SrNo = index; index++; });
            ovlItems.UpdateObjects(remainingItems);
            txtRound.Text = string.Empty;
            btnDelete.Enabled = false;
        }

        private void txtPayAmount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CalculateCreditAmount();
                CalculateRoundAmount();
            }
            catch (Exception ex)
            {
                Logger.Error("Error in pay amount calculation.", ex);
            }
        }
        
        private void CalculateCreditAmount()
        {
            if (!string.IsNullOrEmpty(txtGrandTotal.Text) && !string.IsNullOrEmpty(txtPayAmount.Text))
            {
                txtCreditAmount.Text = (Convert.ToDouble(txtGrandTotal.Text) - Convert.ToDouble(txtPayAmount.Text)).ToString();
            }
            else
            {
                txtCreditAmount.Text = string.Empty;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Logger.Info("Payment information save start.");
                Dictionary<string, string> salesInfo = new Dictionary<string, string>();
                int purchaseBillingID = 0;
                if (toggleBilling.Checked)
                {
                    Logger.Info("Save purchase information start.");
                    PurchaseModel purchaseModel = new PurchaseModel();
                    purchaseModel.SupplierID = Convert.ToInt32((cmbFirmName.SelectedItem as DropDown).Value);
                    purchaseModel.ExiseDuty = 0;
                    purchaseModel.GrandTotal = !String.IsNullOrEmpty(txtGrandTotal.Text) ? Convert.ToDouble(txtGrandTotal.Text) : 0;
                    purchaseModel.InvoiceNumber = Convert.ToInt32(txtInvoiceNo.Text);
                    purchaseModel.OnCredit = !String.IsNullOrEmpty(txtCreditAmount.Text) ? Convert.ToDouble(txtCreditAmount.Text) : 0;
                    purchaseModel.Paid = String.IsNullOrEmpty(txtPayAmount.Text) ? 0 : Convert.ToDouble(txtPayAmount.Text);
                    purchaseModel.SubTotal = !String.IsNullOrEmpty(txtAmount.Text) ? Convert.ToDouble(txtAmount.Text) : 0;
                    purchaseModel.Tax = !String.IsNullOrEmpty(txtGst.Text) ? Convert.ToDouble(txtGst.Text) : 0;
                    purchaseModel.Trans_Date = dtpBillingDate.Value;
                    purchaseBillingID = purchaseReciever.SavePurchaseInvoice(purchaseModel);
                    Logger.Info("Save purchase information success.");

                    Logger.Info("Save purchase items information start.");
                    foreach (BillingItemModel item in ovlItems.Objects)
                    {
                        PurchaseItemModel purchaseItemModel = new PurchaseItemModel();
                        purchaseItemModel.InvoiceNumber = Convert.ToInt32(txtInvoiceNo.Text);
                        purchaseItemModel.Price = item.Rate;
                        purchaseItemModel.Quantity = item.Quantity;
                        purchaseItemModel.PurchaseID = purchaseBillingID;
                        purchaseItemModel.SubItemID = Convert.ToInt32(item.ProductValue);
                        purchaseItemModel.Total = item.Total;
                        purchaseReciever.SavePurchaseItemDetails(purchaseItemModel);
                    }
                    Logger.Info("Save purchase items information success.");
                }
                else
                {
                    Logger.Info("Save sales information start.");
                    // Save sales details
                    SalesModel sales = new SalesModel();
                    sales.CustomerID = Convert.ToInt32((cmbFirmName.SelectedItem as DropDown).Value);
                    sales.TransactionDate = dtpBillingDate.Value;
                    sales.Amount = !String.IsNullOrEmpty(txtAmount.Text) ? Convert.ToDouble(txtAmount.Text) : 0;
                    sales.Carton = 0;
                    sales.Discount = String.IsNullOrEmpty(txtRound.Text) ? 0 : Convert.ToDouble(txtRound.Text);
                    sales.GrandTotal = !String.IsNullOrEmpty(txtGrandTotal.Text) ? Convert.ToDouble(txtGrandTotal.Text) : 0;
                    sales.GST = !String.IsNullOrEmpty(txtGst.Text) ? Convert.ToDouble(txtGst.Text) : 0;
                    sales.OnCredit = !String.IsNullOrEmpty(txtCreditAmount.Text) ? Convert.ToDouble(txtCreditAmount.Text) : 0;
                    sales.Paid = String.IsNullOrEmpty(txtPayAmount.Text) ? 0 : Convert.ToDouble(txtPayAmount.Text);
                    sales.TransportationID = transportationModel != null ? transportationModel.TransportationID : 0;
                    salesInfo = salesReciever.SaveSales(sales);
                    Logger.Info("Save sales information success.");

                    Logger.Info("Save sales items information start.");
                    // Add sales Items details
                    foreach (BillingItemModel item in ovlItems.Objects)
                    {
                        SalesItemDetailsModel salesDetails = new SalesItemDetailsModel();
                        salesDetails.InvoiceNumber = Convert.ToInt32(salesInfo.ElementAt(1).Value);
                        salesDetails.SalesID = Convert.ToInt32(salesInfo.ElementAt(0).Value);
                        salesDetails.SubItemID = Convert.ToInt32(item.ProductValue);
                        salesDetails.Quantity = item.Quantity;
                        salesDetails.Rate = item.Rate;
                        salesDetails.Total = item.Total;
                        salesReciever.SaveSalesDetails(salesDetails);
                        Logger.Info(string.Format("Sales item {0} added and amount is {1}.", salesDetails.SubItemID, salesDetails.Total));
                    }
                    Logger.Info("Save sales items information success.");


                    if (transportationModel != null)
                    {
                        if (!String.IsNullOrEmpty(transportationModel.TEmployeeName) && !String.IsNullOrEmpty(transportationModel.TVehicleNumber))
                        {
                            Logger.Info("Save tranportation information start.");
                            transportationModel.SalesID = Convert.ToInt32(salesInfo.ElementAt(0).Value);
                            salesReciever.SaveTransportDetails(transportationModel);
                            Logger.Info("Save tranportation information success.");
                        }
                    }
                }

                if (paymentTransactionModel != null)
                {
                    var sales = toggleBilling.Checked ? false : true;
                    if (paymentTransactionModel.AccountID > 0 && paymentTransactionModel.PaymentModeID > 0)
                    {
                        Logger.Info("Payment information save start.");
                        SalesPayment salesPayment = new SalesPayment();
                        salesPayment.PaymentModeID = paymentTransactionModel.PaymentModeID;
                        salesPayment.TransactionDetailNo = paymentTransactionModel.TransactionNumber;
                        salesPayment.BillingID = sales ? Convert.ToInt32(salesInfo.ElementAt(0).Value) : purchaseBillingID;
                        salesPayment.ToAcc = paymentTransactionModel.AccountID.ToString();
                        salesPayment.TransactionDate = dtpBillingDate.Value;
                        salesPayment.Description = paymentTransactionModel.Description;
                        salesPayment.InvoieType = sales ? "S" : "P";
                        salesReciever.SavePaymentDetails(salesPayment);
                        Logger.Info("Payment information save success.");
                    }
                }

                ResetItem();
                ResetBillingInformation();
                ResetItemList();
                ResetTransportationDetails();
                ResetPaymentMode();
                MessageBox.Show("Billing invoice saved successfully.", "Success", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                Logger.Error("Error in billing invoice submit.", ex);
            }
        }

        private void txtRound_TextChanged(object sender, EventArgs e)
        {
            CalculateRoundAmount();
            CalculateCreditAmount();
        }

        private void CalculateRoundAmount()
        {
            var grandTotal =  GetGrandTotal();
            var roundAmount = !String.IsNullOrEmpty(txtRound.Text) ? Convert.ToDouble(txtRound.Text): 0;
            if (grandTotal > 0)
            {
               
                if (roundAmount <= grandTotal)
                {
                    txtGrandTotal.Text = (grandTotal - roundAmount).ToString();
                }
                else
                {
                    MessageBox.Show("Round/ Discount should be less than grand total.","Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnTransport_Click(object sender, EventArgs e)
        {
            Logger.Info("Transportation section open.");
            if (transportationModel == null)
            {
                transportationModel = new SalesTransportModel();
            }
            FrmSalesTransport transportation = new FrmSalesTransport(transportationModel);
            DialogResult callback = transportation.ShowDialog(this);
            if (DialogResult.OK == callback)
            {
                Logger.Info("Transportation information submitted.");
            }
            else
            {
                transportationModel = null;
                Logger.Info("Transportation information cleared.");
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            Logger.Info("Payment section open.");
            if (paymentTransactionModel == null)
            {
                paymentTransactionModel = new PaymentTransactionModel();
            }
            FrmPaymentTransaction paymentTransaction = new FrmPaymentTransaction(paymentTransactionModel);
            DialogResult callback = paymentTransaction.ShowDialog(this);
            if (DialogResult.OK == callback)
            {
                Logger.Info("Payment mode information submitted.");
            }
            else
            {
                paymentTransactionModel = null;
                Logger.Info("Payment mode information cleared.");
            }
        }
    }
}