using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using WaterSystem_Manager.Receiver;
using WaterSystem_Model;

namespace WaterSystem_v1
{
    public partial class FrmAddEditRowMaterial : Form
    {
        RowMaterialReciever receiver = null;
        RowMaterialModel _model = null;
        public FrmAddEditRowMaterial()
        {
            InitializeComponent();
        }

        public FrmAddEditRowMaterial(RowMaterialModel model)
        {
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

        private void cmbRowMaterialName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FrmAddEditRowMaterial_Load(object sender, EventArgs e)
        {
            receiver = new RowMaterialReciever();
            ConfigureStyle();
            var headers = GetRowHeaders();
            var measurements = GetMeasurements();

            // Fill Combo
            Helpers.DataHelper helper = new Helpers.DataHelper();
            helper.FillCombo(cmbRowHeaderName, headers);
            helper.FillCombo(cmbMeasurement, measurements);

            if (_model != null)
            {
                txtRowMaterial.Text = _model.RowMaterialName;
                cmbRowHeaderName.SelectedIndex = headers.Select((obj, index) => new { obj, index }).Where(x => x.obj.Value == _model.RowHedarId.ToString()).Select(x => x.index).FirstOrDefault();
                cmbMeasurement.SelectedIndex = measurements.Select((obj, index) => new { obj, index }).Where(x => x.obj.Value == _model.MeasurmentId.ToString()).Select(x => x.index).FirstOrDefault();
                toggleActive.Checked = _model.IsActive;
            }
            else
            {
                _model = new RowMaterialModel();
                cmbRowHeaderName.SelectedIndex = 0;
                cmbMeasurement.SelectedIndex = 0;
            }
        }

        private IEnumerable<DropDown> GetRowHeaders()
        {
           var headers = receiver.GetHedars();
            List<DropDown> dropDownHeaders = new List<DropDown>();
            dropDownHeaders.Add(new DropDown { Name = "--Select--", Value = "0" });
            if (headers.Any())
            {
                dropDownHeaders.AddRange(headers.Select(x => new DropDown { Name = x.RowHedarName, Value = x.RowHedarId.ToString() }).ToList());
            }
            return dropDownHeaders;
        }

        private IEnumerable<DropDown> GetMeasurements()
        {
            var measurement = receiver.GetMeasurements();
            List<DropDown> dropDownMeasurement = new List<DropDown>();
            dropDownMeasurement.Add(new DropDown { Name = "--Select--", Value = "0" });
            if (measurement.Any())
            {
                dropDownMeasurement.AddRange(measurement.Select(x => new DropDown { Name = x.MeasurmentName, Value = x.MeasurmentId.ToString() }).ToList());
            }
            return dropDownMeasurement;
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
                    _model.RowMaterialName = txtRowMaterial.Text;
                    _model.RowHedarId = Convert.ToDecimal(((DropDown)cmbRowHeaderName.SelectedItem).Value);
                    _model.MeasurmentId = Convert.ToDecimal(((DropDown)cmbMeasurement.SelectedItem).Value);
                    _model.IsActive = toggleActive.Checked;
                    if (_model.RowMaterialId > 0)
                    {
                        receiver.Update(_model);
                    }
                    else
                    {
                        receiver.Add(_model);
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
