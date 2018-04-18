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
    public partial class FrmInvoiceApproveBlock : Form
    {
        public FrmInvoiceApproveBlock()
        {
            InitializeComponent();
        }

        private void FrmInvoiceApproveBlock_Load(object sender, EventArgs e)
        {
            FrmInvoiceApproveTabs invoiceApprove = new FrmInvoiceApproveTabs(ApproveTabs.Sales);
            FormHelper.OpenForm(pnlApproveComponent, invoiceApprove);
        }
    }
}
