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
    public partial class FrmDebitCreditExpensesContainer : Form
    {
        public FrmDebitCreditExpensesContainer()
        {
            InitializeComponent();
        }

        private void FrmDebitCreditExpensesContainer_Load(object sender, EventArgs e)
        {
            FrmDebitCreditExpenses debitCreditForm = new FrmDebitCreditExpenses();
            FormHelper.OpenForm(pnlMainContainer, debitCreditForm);
        }
    }
}
