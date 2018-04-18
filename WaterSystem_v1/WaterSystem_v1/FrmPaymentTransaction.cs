using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaterSystem_Model;
using WaterSystem_Manager.Receiver;
using WaterSystem_v1.Helpers;

namespace WaterSystem_v1
{
    public partial class FrmPaymentTransaction : Form
    {
        private PaymentTransactionModel _paymentTransaction = null;
        ReportReciever reportReciever = null;
        public FrmPaymentTransaction()
        {
            InitializeComponent();
        }

        public FrmPaymentTransaction(PaymentTransactionModel model)
        {
            InitializeComponent();
            _paymentTransaction = model;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (_paymentTransaction != null)
            {
                _paymentTransaction.PaymentModeID = Convert.ToInt32((cmbPayMode.SelectedItem as DropDown).Value);
                _paymentTransaction.AccountID = Convert.ToInt32((cmbAccount.SelectedItem as DropDown).Value);
                _paymentTransaction.Balance = Convert.ToDouble(txtBalance.Text);
                _paymentTransaction.TransactionNumber = txtTransactionNumber.Text;
                _paymentTransaction.Description = txtDescription.Text;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbPayMode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmPaymentTransaction_Load(object sender, EventArgs e)
        {
            DataHelper dataHelper = new DataHelper();
            reportReciever = new ReportReciever();
            // Get Payment modes
            SalesInvoiceReciever salesReciever = new SalesInvoiceReciever();
            var paymentModes = salesReciever.RetrievePayModes();
            List<DropDown> paymentModesList = paymentModes.Select(x => new DropDown { Name = x.Pay_Type, Value = x.Pay_Mode_Id.ToString() }).ToList();
            paymentModesList.Insert(0, new DropDown() { Name = "--- Select ---", Value = (0).ToString() });
            dataHelper.FillCombo(cmbPayMode, paymentModesList);

            var accounts = salesReciever.RetrieveSubExpences();
            var accountsList = accounts.Select(x => new DropDown { Name = x.SubExpences_Name, Value = x.SubExpences_ID.ToString() }).ToList();
            accountsList.Insert(0, new DropDown() { Name = "--- Select ---", Value = (0).ToString() });
            dataHelper.FillCombo(cmbAccount, accountsList);

            if (_paymentTransaction != null)
            {
                cmbPayMode.SelectedIndex = paymentModesList.Select((obj, index) => new { obj, index }).Where(x => x.obj.Value == _paymentTransaction.PaymentModeID.ToString()).Select(x => x.index).FirstOrDefault();
                cmbAccount.SelectedIndex = accountsList.Select((obj, index) => new { obj, index }).Where(x => x.obj.Value == _paymentTransaction.AccountID.ToString()).Select(x => x.index).FirstOrDefault();
                txtBalance.Text = _paymentTransaction.Balance.ToString();
                txtDescription.Text = _paymentTransaction.Description;
                txtTransactionNumber.Text = _paymentTransaction.TransactionNumber;
            }
            else
            {
                cmbPayMode.SelectedIndex = 0;
                cmbAccount.SelectedIndex = 0;
            }
        }

        private void cmbAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            var accountNumber = Convert.ToInt32((cmbAccount.SelectedItem as DropDown).Value);
            txtBalance.Text = (accountNumber > 0 ? reportReciever.RetriveAccountBalance(accountNumber) : 0).ToString();
        }
    }
}
