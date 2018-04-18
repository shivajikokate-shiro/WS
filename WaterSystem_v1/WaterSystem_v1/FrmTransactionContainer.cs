using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaterSystem_v1
{
    public partial class FrmTransactionContainer : Form
    {
        FrmBillingInvoice billingInvoice = null;
        FrmInvoiceApproveBlock invoiceApprove = null;
        FrmDebitCreditExpensesContainer debitCredit = null;
        public FrmTransactionContainer()
        {
            InitializeComponent();
        }

        private void tabTransactionContainer_Click(object sender, EventArgs e)
        {
            OpenTab(tabTransactionContainer.SelectedIndex);
        }

        private void OpenTab(int index)
        {
            switch (index)
            {
                case TransactionTabs.BillingInvoice:
                    if (billingInvoice == null)
                    {
                        billingInvoice = new FrmBillingInvoice();
                        Helpers.FormHelper.OpenForm(tabBillingInvoice, billingInvoice);
                    }
                    break;
                case TransactionTabs.DebitCredit:
                    if (debitCredit == null)
                    {
                        debitCredit = new FrmDebitCreditExpensesContainer();
                        Helpers.FormHelper.OpenForm(tabDebitCredit, debitCredit);
                    }
                    break;
                case TransactionTabs.InvoiceApproval:
                    if (invoiceApprove == null)
                    {
                        invoiceApprove = new FrmInvoiceApproveBlock();
                        Helpers.FormHelper.OpenForm(tabInvoiceApproval, invoiceApprove);
                    }
                    break;
                case TransactionTabs.InvoiceUpdate:
                    break;
            }
        }

        private void FrmTransactionContainer_Load(object sender, EventArgs e)
        {
            OpenTab(0);
        }
    }

    public static class TransactionTabs
    {
        public const int BillingInvoice = 0;
        public const int DebitCredit = 1;
        public const int InvoiceApproval = 2;
        public const int InvoiceUpdate = 3;
        public const int Root = 4;
    }
}
