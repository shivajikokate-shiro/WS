using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaterSystem_Manager.Reciever;
using WaterSystem_Model;

namespace WaterSystem_v1
{
    public partial class FrmAddEditMeasurement : Form
    {
        MeasurementModel _model = new MeasurementModel();
        MeasurementReciever reciever = null;
        public FrmAddEditMeasurement()
        {
            try
            {
                InitializeComponent();
                StyleConfiguration();
                reciever = new MeasurementReciever();
            }
            catch (Exception ex)
            { }
        }

        public FrmAddEditMeasurement(MeasurementModel model)
        {
            try
            {
                InitializeComponent();
                StyleConfiguration();
                reciever = new MeasurementReciever();
                _model = model;
                btnSubmit.Text = "Update";
                lblTitle.Text = "Update";
                ConfigureMeasurement();
            }
            catch (Exception ex)
            {

            }
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

        public void ConfigureMeasurement()
        {
            this.txtName.Text = _model.MeasurmentName.ToString();
            this.toggleActive.Checked = _model.IsActive;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                try
                {
                    if (_model != null)
                    {
                        _model.MeasurmentName = this.txtName.Text.ToString();
                        _model.IsActive = this.toggleActive.Checked;
                        if (_model.MeasurmentId > 0)
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
        }

        private void textBoxName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                e.Cancel = true;
                this.DialogResult = DialogResult.None;
                txtName.Focus();
                errorProvider1.SetError(txtName, "Measurement should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtName, "");
            }
        }

        private void pnlActive_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlActiveContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
