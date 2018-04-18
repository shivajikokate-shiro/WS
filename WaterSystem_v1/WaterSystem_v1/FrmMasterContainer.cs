using System;
using System.Windows.Forms;

namespace WaterSystem_v1
{
    public partial class FrmMasterContainer : Form
    {
        FrmMeasurementDetail measurement = null;
        FrmItemDetails item = null;
        FrmCustomerDetail customer = null;
        FrmSupplierDetail supplier = null;
        FrmEmployeeDetail employee = null;
        FrmAccountDetail account = null;
        FrmSubAccountDetail subAccount = null;
        public FrmMasterContainer()
        {
            InitializeComponent();
            OpenTab(0);
        }

        private void tabMasterContainer_Click(object sender, EventArgs e)
        {
            OpenTab(tabMasterContainer.SelectedIndex);
        }

        private void OpenTab(int tabIndex)
        {
            switch (tabIndex)
            {
                case MasterTabs.Measurement:
                    if (measurement == null)
                    {
                        measurement = new FrmMeasurementDetail();
                        Helpers.FormHelper.OpenForm(tabMeasurement, measurement);
                    }
                    break;
                case MasterTabs.Item:
                    if (item == null)
                    {
                        item = new FrmItemDetails();
                        Helpers.FormHelper.OpenForm(tabItem, item);
                    }
                    break;
                case MasterTabs.Customer:
                    if (customer == null)
                    {
                        customer = new FrmCustomerDetail();
                        Helpers.FormHelper.OpenForm(tabCustomer, customer);
                    }
                    break;
                case MasterTabs.Supplier:
                    if (supplier == null)
                    {
                        supplier = new FrmSupplierDetail();
                        Helpers.FormHelper.OpenForm(tabSupplier, supplier);
                    }
                    break;
                case MasterTabs.Employee:
                    if (employee == null)
                    {
                        employee = new FrmEmployeeDetail();
                        Helpers.FormHelper.OpenForm(tabEmployee, employee);
                    }
                    break;
                case MasterTabs.Account:
                    if (account == null)
                    {
                        account = new FrmAccountDetail();
                        Helpers.FormHelper.OpenForm(tabAccount, account);
                    }
                    break;
                case MasterTabs.SubAccount:
                    if (subAccount == null)
                    {
                        subAccount = new FrmSubAccountDetail();
                        Helpers.FormHelper.OpenForm(tabSubAccount, subAccount);
                    }
                    break;
            }
        }
    }

    public static class MasterTabs
    {
        public const int Measurement = 0;
        public const int Item = 1;
        public const int Customer = 2;
        public const int Supplier = 3;
        public const int Employee = 4;
        public const int Account = 5;
        public const int SubAccount = 6;

    }
}

