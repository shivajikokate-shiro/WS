using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaterSystem_Manager.Receiver;
using WaterSystem_Model;

namespace WaterSystem_v1
{
    public partial class FrmAddEditCustomer : Form
    {
        CustomerModel _model = null;
        CustomerReciever reciever = null;
        public FrmAddEditCustomer()
        {
            InitializeComponent();
        }

        public FrmAddEditCustomer(CustomerModel model)
        {
            InitializeComponent();
            _model = model;
        }
        
        private void ConfigureStyle()
        {
            toggleActive.Style = JCS.ToggleSwitch.ToggleSwitchStyle.Iphone;
            toggleActive.Size = new Size(68, 22);
            toggleActive.OnText = "Yes";
            toggleActive.OnFont = new Font(this.Font.FontFamily, 10, FontStyle.Bold);
            toggleActive.OnForeColor = Color.White;
            toggleActive.OffText = "No";
            toggleActive.OffFont = new Font(this.Font.FontFamily, 10, FontStyle.Bold);
            toggleActive.OffForeColor = Color.FromArgb(92, 92, 92);
        }


        private void btnSubmit_Click(object sender, EventArgs e)                    
        {
            if (_model != null)
            {
                _model.Customer_No = Convert.ToDecimal(txtNumber.Text);
                _model.Comp_Name = txtName.Text;
                _model.Cust_Mobileno = Convert.ToDecimal(txtMob.Text);
                _model.Address = txtAddress.Text;
                _model.IsActive = toggleActive.Checked;
                _model.TinNo = "-";
                _model.VatNo = "-";
                if (_model.Customer_Id > 0)
                {
                    reciever.Update(_model);
                }
                else
                {
                    reciever.Add(_model);
                }
            }
            else
            {
                throw new ArgumentException();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAddEditCustomer_Load(object sender, EventArgs e)
        {
            ConfigureStyle();
            reciever = new CustomerReciever();
            if (_model != null)
            {
                txtNumber.Text = _model.Customer_No.ToString();
                txtName.Text = _model.Comp_Name;
                txtGstNo.Text = _model.VatNo != null ? _model.VatNo.ToString() : null;
                txtMob.Text = _model.Cust_Mobileno.ToString();
                txtAddress.Text = _model.Address.ToString();
                toggleActive.Checked = _model.IsActive;
            }
            else
            {
                _model = new CustomerModel();
                txtNumber.Text = reciever.GetCustomerNumber();
            }
        }
    }
}
