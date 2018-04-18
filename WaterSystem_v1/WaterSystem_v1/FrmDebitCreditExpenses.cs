using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaterSystem_Common;
using WaterSystem_Manager.Receiver;
using WaterSystem_Model;
using WaterSystem_v1.Helpers;
using WaterSystem_v1.Logs;

namespace WaterSystem_v1
{
    public partial class FrmDebitCreditExpenses : Form
    {
        DebitCreditTransactionReciever _reciever = null;
        DataHelper dataHelper = null;
        public FrmDebitCreditExpenses()
        {
            InitializeComponent();
        }

        private void tblDate_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmDebitCreditExpenses_Load(object sender, EventArgs e)
        {
            _reciever = new DebitCreditTransactionReciever();
            dataHelper = new DataHelper();
            LoadBasics();
        }   

        private void FillToken()
        {
            lblTokenValue.Text = GetTransactionNumber();
        }
    

        private void LoadBasics()
        {
            FillTransactionModes();
            FillPayee();
            FillPayer();
            FillToken();
        }

        private void FillTransactionModes()
        {
            List<DropDown> transactionModeList = _reciever.GetTransactionModes().Select(x => new DropDown { Name = x.TransactionMode, Value = x.TransactionModeId.ToString() }).ToList();
            transactionModeList.Insert(0, new DropDown { Name = "--Select--", Value = 0.ToString() });
            dataHelper.FillCombo(cmbPaymentMethod, transactionModeList);
            cmbPaymentMethod.SelectedIndex = 0;
        }

        private void FillPayee()
        {
            List<DropDown> payeeList = new List<DropDown>();
            if (cmbPaymentMethod.SelectedIndex > 0)
            {
                payeeList.AddRange(GetPayee().Select(x => new DropDown { Name = x.SubExpences_Name, Value = x.SubExpences_ID.ToString() }));
            }
            payeeList.Insert(0, new DropDown { Name = "--Select--", Value = 0.ToString() });
            dataHelper.FillCombo(cmbPayee, payeeList);
            cmbPayee.SelectedIndex = 0;
        }

        private void FillPayer()
        {
            List<DropDown> payerList = new List<DropDown>();
            if (cmbPaymentMethod.SelectedIndex > 0)
            {
                payerList.AddRange(GetPayer().Select(x => new DropDown { Name = x.SubExpences_Name, Value = x.SubExpences_ID.ToString() }));
            }
            payerList.Insert(0, new DropDown { Name = "--Select--", Value = 0.ToString() });
            dataHelper.FillCombo(cmbPayer, payerList);
            cmbPayer.SelectedIndex = 0;
        }


        private IEnumerable<SubExpencesModel> GetPayee()
        {
            var paymentMethods = _reciever.GetTransactionModes();
            var transactionMethod = paymentMethods.Where(x => x.TransactionModeId.ToString() == (cmbPaymentMethod.SelectedItem as DropDown).Value).FirstOrDefault();
            var expensesList = _reciever.GetSubExpenses();
            if (transactionMethod.ToBank == true)
            {
                expensesList = expensesList.Where(x => x.Expences_ID == 17).ToList();
            }
            return expensesList;
        }

        private IEnumerable<SubExpencesModel> GetPayer()
        {
            var paymentMethods = _reciever.GetTransactionModes();
            var transactionMethod = paymentMethods.Where(x => x.TransactionModeId.ToString() == (cmbPaymentMethod.SelectedItem as DropDown).Value).FirstOrDefault();
            var expensesList = _reciever.GetSubExpenses();

            if (transactionMethod.FromBank == true)
            {
                expensesList = expensesList.Where(x => x.Expences_ID == 17).ToList();
            }
            return expensesList;
        }

        private void cmbPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillPayee();
            FillPayer();
            FillToken();
        }

        private string GetTransactionNumber()
        {
            var transactionNumber = _reciever.GetTransactionNumber();
            if (cmbPaymentMethod.SelectedIndex > 0)
            {
                var transactionType = CommonHelper.ExtractInitialsFromString(((cmbPaymentMethod.SelectedItem as DropDown).Name));
                return string.Format("{0}{1}", transactionType, transactionNumber);
            }
            return transactionNumber.ToString();
        }
        
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SaveExpenses();
        }

        private void SaveExpenses()
        {
            try
            {
                Logger.Info("Credit debit save start.");
                PaymentTransactionDetailsModel transactionModel = new PaymentTransactionDetailsModel();
                transactionModel.ToAcc = GetPayeeAccount();
                transactionModel.FromAcc = GetPayerAccount();
                transactionModel.DayCash = Convert.ToDecimal(txtAmount.Text);
                transactionModel.PayModeId = Convert.ToInt32((cmbPaymentMethod.SelectedItem as DropDown).Value);
                transactionModel.TransDate = dtpTransaction.Value;
                transactionModel.TransNumber = lblTokenValue.Text;
                transactionModel.Description = txtDescription.Text;
                transactionModel.UserID = 1;
                transactionModel.CustType = "E";
                _reciever.Save(transactionModel);
                Logger.Info("Credit debit save save.");
                MessageBox.Show("Expenses saved successfully.", "Success", MessageBoxButtons.OK);
                ResetComponents();
                FillToken();
            }
            catch (Exception ex)
            {
                Logger.Error("Error in debit credit save.", ex);
            }
        }

        private void ResetComponents()
        {
            cmbPayee.SelectedIndex = 0;
            cmbPayer.SelectedIndex = 0;
            txtAmount.Text = string.Empty;
            txtDescription.Text = string.Empty;
        }

        private int GetPayeeAccount()
        {
           return Convert.ToInt32((cmbPayee.SelectedItem as DropDown).Value);
        }

        private int GetPayerAccount()
        {
            return Convert.ToInt32((cmbPayer.SelectedItem as DropDown).Value);
        }
    }
}
