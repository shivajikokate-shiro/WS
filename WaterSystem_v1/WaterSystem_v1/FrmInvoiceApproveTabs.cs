using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaterSystem_v1.Helpers;

namespace WaterSystem_v1
{
    public partial class FrmInvoiceApproveTabs : Form
    {
        FrmInvoiceApprove invoicesApprove = null;
        int tabIndex;
        public FrmInvoiceApproveTabs(int index)
        {
            InitializeComponent();
            tabIndex = index;
        }

        private void FrmInvoiceApproveTabs_Load(object sender, EventArgs e)
        {
            OpenTab();
        }

        private void tabApproval_Click(object sender, EventArgs e)
        {
            tabIndex = tabApproval.SelectedIndex;
            OpenTab();
        }

        public void OpenTab()
        {
            if (invoicesApprove != null)
            {
                invoicesApprove.Close();
            }
            invoicesApprove = new FrmInvoiceApprove(tabIndex);
            switch (tabIndex)
            {
                case ApproveTabs.Sales:
                    FormHelper.OpenForm(sales, invoicesApprove);
                    break;
                case ApproveTabs.Purchase:
                    FormHelper.OpenForm(purchase, invoicesApprove);
                    break;
                case ApproveTabs.Expenses:
                    FormHelper.OpenForm(expenses, invoicesApprove);
                    break;
            }
        }

        private void sales_Click(object sender, EventArgs e)
        {

        }
    }

    public static class ApproveTabs
    {
        public const int Sales = 0;
        public const int Purchase = 1;
        public const int Expenses = 2;
    }
}
