using System;
using System.Linq;
using System.Windows.Forms;
using WaterSystem_Model;
using WaterSystem_Manager.Receiver;
using System.Collections.Generic;
using System.Drawing;
using Newtonsoft.Json;

namespace WaterSystem_v1
{
    public partial class FrmAddEditItem : Form
    {
        ItemModel _model = null;
        ItemReciever reciever = null;
        IEnumerable<MeasurementModel> measurements;
        public FrmAddEditItem()
        {
            _model = new ItemModel();
            reciever = new ItemReciever();
            InitializeComponent();
        }

        public FrmAddEditItem(ItemModel model)
        {
            _model = model;
            reciever = new ItemReciever();
            InitializeComponent();
        }

        private void FrmAddEditItem_Load(object sender, EventArgs e)
        {
            if (measurements==null)
            {
                measurements = LoadMeasurementList();
            }

            // Fill Combo box
            Helpers.DataHelper helper = new Helpers.DataHelper();
            var dataList = measurements.Select(x => new DropDown() { Name = x.MeasurmentName, Value = x.MeasurmentId.ToString() }).ToList();
            dataList.Insert(0, new DropDown() { Name = "-- Select --", Value = (0).ToString() });
            helper.FillCombo(cmbMeasurement, dataList);
            if (_model != null)
            {
                toggleProcess.Checked = !String.IsNullOrEmpty(_model.PFlag) && _model.PFlag.ToLower() == "p" ? true : false;
                txtItemName.Text = _model.ItemName;
                cmbMeasurement.SelectedIndex = dataList.Select((obj, index) => new { obj, index }).Where(x => x.obj.Value == _model.MeasurmentId.ToString()).Select(x => x.index).FirstOrDefault();
                toggleActive.Checked = _model.IsActive; 
            }
            ConfigureStyling();
        }

        private void ConfigureStyling()
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

        private IEnumerable<MeasurementModel> LoadMeasurementList()
        {
            return reciever.GetMeasurement();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (_model != null)
                {
                    _model.PFlag = toggleProcess.Checked ? process : withoutProcess;
                    _model.MeasurmentId = Convert.ToDecimal((cmbMeasurement.SelectedItem as DropDown).Value);
                    _model.ItemName = txtItemName.Text;
                    _model.IsActive = toggleActive.Checked;
                    if (_model.ItemId > 0)
                    {
                        reciever.Update(_model);
                    }
                    else
                    {
                        reciever.Add(_model);
                    }
                }
            }
            catch(Exception ex)
            {

            }
        }

        string process = "p";
        string withoutProcess = "d";
    }
}
