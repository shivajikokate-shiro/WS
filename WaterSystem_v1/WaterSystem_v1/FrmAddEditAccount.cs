using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using WaterSystem_Manager.Receiver;
using WaterSystem_Model;
using System.Drawing;

namespace WaterSystem_v1
{
    public partial class FrmAddEditAccount : Form
    {
        ExpencesModel _model = null;
        ExpencesReciever reciever = null;
        IEnumerable<ExpencesModel> _accountTypes = null;
        public FrmAddEditAccount(IEnumerable<ExpencesModel> accountType)
        {
            InitializeComponent();
            _accountTypes = accountType;
            ConfigureStyling();
        }

        public FrmAddEditAccount(ExpencesModel model, IEnumerable<ExpencesModel> accountTypes)
        {
            _model = model;
            InitializeComponent();
            _accountTypes = accountTypes;
            ConfigureStyling();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

        private void FrmAddEditAccount_Load(object sender, EventArgs e)
        {
            reciever = new ExpencesReciever();
            // Fill Combo box
            Helpers.DataHelper helper = new Helpers.DataHelper();
            _accountTypes = _accountTypes.GroupBy(x => x.Option_Name).Select(x => x.FirstOrDefault());
            var dataList = _accountTypes.Select(x => new DropDown() { Name = x.Option_Type, Value = x.Option_Name.ToString() }).ToList();
            dataList.Insert(0, new DropDown() { Name = "-- Select --", Value = (0).ToString() });
            helper.FillCombo(cmbMainAccount, dataList);
            if (_model != null)
            {
                cmbMainAccount.SelectedIndex = dataList.Select((obj, index) => new { obj, index }).Where(x => x.obj.Value == _model.Option_Name.ToString()).Select(x => x.index).FirstOrDefault();
                txtAccountType.Text = _model.Expences_Name;
                toggleActive.Checked = _model.IsActive;
            }
            else
            {
                _model = new ExpencesModel();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (_model != null)
            {
                _model.Option_Type = (cmbMainAccount.SelectedItem as DropDown).Value;
                _model.Expences_Name = txtAccountType.Text;
                _model.IsActive = toggleActive.Checked;
                if (_model.Expences_ID > 0)
                {
                    reciever.Update(_model);
                }
                else
                {
                    reciever.Add(_model);
                }
            }
        }
    }
}
