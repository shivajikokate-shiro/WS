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

namespace WaterSystem_v1
{
    public partial class FrmAddEditTransportation: Form
    {
        TransportationModel _model = null;
        TransportationReciever reciever = null;
        public FrmAddEditTransportation()
        {
            InitializeComponent();
            StyleConfiguration();
        }

        public FrmAddEditTransportation(TransportationModel model)
        {
            _model = model;
            InitializeComponent();
            StyleConfiguration();
        }

        public void StyleConfiguration()
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAddEditTransportation_Load(object sender, EventArgs e)
        {
            reciever = new TransportationReciever();
            if (_model != null)
            {
                txtName.Text = _model.Transportation_Name;
                txtAddress.Text = _model.Transportation_Address;
                txtMobile.Text = _model.Transportation_Number.ToString();
                toggleActive.Checked = _model.IsActive;
            }
            else
            {
                _model = new TransportationModel();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (_model != null)
            {
                _model.Transportation_Name = txtName.Text;
                _model.Transportation_Number = Convert.ToDecimal(txtMobile.Text);
                _model.Transportation_Address = txtAddress.Text;
                _model.IsActive = toggleActive.Checked;
                if (_model.Transportation_Id > 0)
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
    }
}
