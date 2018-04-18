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
    public partial class FrmAddEditVechile : Form
    {
        VehicleReciever reciever = null;
        VehicleModel _model = null;
        public FrmAddEditVechile()
        {
            reciever = new VehicleReciever();
            InitializeComponent();

        }

        public FrmAddEditVechile(VehicleModel model)
        {
            reciever = new VehicleReciever();
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

        private void FrmAddEditVechile_Load(object sender, EventArgs e)
        {
            ConfigureStyle();
            // Fill Combo box
            TransportationReciever transportReciever = new TransportationReciever();
            var transportations = transportReciever.GetList();
            Helpers.DataHelper helper = new Helpers.DataHelper();
            var dataList = transportations.Select(x => new DropDown() { Name = x.Transportation_Name, Value = x.Transportation_Id.ToString() }).ToList();
            dataList.Insert(0, new DropDown() { Name = "-- Select --", Value = (0).ToString() });
            helper.FillCombo(cmbTransportation, dataList);
            if (_model != null)
            {
                txtEmployeName.Text = _model.Employee_Name;
                txtMobile.Text = _model.Contact;
                txtVechileNo.Text = _model.Vehical_No;
                cmbTransportation.SelectedIndex = dataList.Select((obj, index) => new { obj, index }).Where(x => x.obj.Value == _model.Transportation_ID.ToString()).Select(x => x.index).FirstOrDefault();
                txtAdress.Text = _model.Employee_Address;
                txtDescription.Text = _model.Description;
                toggleActive.Checked = _model.Is_Active;
            }
            else
            {
                _model = new VehicleModel();
                cmbTransportation.SelectedIndex = 0;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (_model != null)
                {
                    _model.Employee_Name = txtEmployeName.Text;
                    _model.Vehical_No = txtVechileNo.Text;
                    _model.Transportation_ID = Convert.ToDecimal((cmbTransportation.SelectedItem as DropDown).Value);
                    _model.Contact = txtMobile.Text;
                    _model.Description = txtDescription.Text;
                    _model.Employee_Address = txtAdress.Text;
                    _model.Is_Active = toggleActive.Checked;
                    if (_model.ID > 0)
                    {
                        reciever.Update(_model);
                    }
                    else
                    {
                        reciever.Add(_model);
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
