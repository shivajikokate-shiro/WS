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
    public partial class FrmAddEditSupplier : Form
    {
        SupplierReciever reciever = null;
        SupplierModel _model = null;
        public FrmAddEditSupplier()
        {
            reciever = new SupplierReciever();
            InitializeComponent();
        }

        public FrmAddEditSupplier(SupplierModel model)
        {
            reciever = new SupplierReciever();
            _model = model;
            InitializeComponent();
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
                _model.SupplierNo = Convert.ToDecimal(txtNo.Text);
                _model.Comp_Name = txtName.Text;
                _model.Supplier_Mobileno = Convert.ToDecimal(txtMob.Text);
                _model.Address = txtAddress.Text;
                _model.IsActive = toggleActive.Checked;
                _model.TinNo = "-";
                _model.VatNo = "-";
                if (_model.Supplier_Id > 0)
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

        private void FrmAddEditSupplier_Load(object sender, EventArgs e)
        {
            ConfigureStyle();
            reciever = new SupplierReciever();
            if (_model != null)
            {
                txtNo.Text = _model.SupplierNo.ToString();
                txtName.Text = _model.Comp_Name;
                txtGstNo.Text = _model.VatNo != null ? _model.VatNo.ToString() : null;
                txtMob.Text = _model.Supplier_Mobileno.ToString();
                txtAddress.Text = _model.Address.ToString();
                toggleActive.Checked = _model.IsActive;
            }
            else
            {
                _model = new SupplierModel();
                txtNo.Text = reciever.GetSupplierNumber();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
