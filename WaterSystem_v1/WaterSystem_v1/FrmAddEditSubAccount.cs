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
    public partial class FrmAddEditSubAccount : Form
    {
        SubExpencesReciever reciever = null;
        SubExpencesModel _model = null;
        IEnumerable<SubExpencesModel> _subExpencesList = null;
        Helpers.DataHelper helper = null;
        public FrmAddEditSubAccount(IEnumerable<SubExpencesModel> expences)
        {
            _subExpencesList = expences;
            InitializeComponent();
            ConfigureStyling();
        }

        public FrmAddEditSubAccount(SubExpencesModel model, IEnumerable<SubExpencesModel> expences)
        {
            _model = model;
            _subExpencesList = expences;
            InitializeComponent();
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

        private void FrmAddEditSubAccount_Load(object sender, EventArgs e)
        {
            try
            {
                reciever = new SubExpencesReciever();
                helper = new Helpers.DataHelper();
                // Fill Main account type combo
                var mainAccount = _subExpencesList.GroupBy(x => x.Option_Name).Select(x => x.FirstOrDefault());
                helper.FillCombo(cmbMainAccount, GetMainAccountList(mainAccount));
                if (_model != null)
                {
                    PopulateAccountType(_model.Expences_ID.ToString());
                    txtSubAccountType.Text = _model.SubExpences_Name;
                    cmbMainAccount.SelectedIndex = GetMainAccountList(mainAccount).Select((obj, index) => new { obj, index }).Where(x => x.obj.Value == _model.Option_Name).Select(x => x.index).FirstOrDefault();
                    cmbAccountType.SelectedIndex = GetAccountTypeList(_model.Option_Name).Select((obj, index) => new { obj, index }).Where(x => x.obj.Value == _model.Expences_ID.ToString()).Select(x => x.index).FirstOrDefault();
                    toggleActive.Checked = _model.IsActive;
                }
                else
                {
                    _model = new SubExpencesModel();
                    cmbMainAccount.SelectedIndex = 0;
                    cmbAccountType.SelectedIndex = 0;
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (_model != null)
            {
                _model.SubExpences_Name = txtSubAccountType.Text;
                _model.Expences_ID = Convert.ToDecimal((cmbAccountType.SelectedItem as DropDown).Value);
                _model.IsActive = toggleActive.Checked;
                if (_model.SubExpences_ID > 0)
                {
                    reciever.Update(_model);
                }
                else
                {
                    reciever.Add(_model);
                }
            }
        }

        private void cmbMainAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mainAccount = (cmbMainAccount.SelectedItem as DropDown).Value;
            PopulateAccountType(mainAccount);
            cmbAccountType.SelectedIndex = 0;
        }

        public void PopulateAccountType(string mainAccount)
        {
            // Fill account type combo
            cmbAccountType.Items.Clear();
            helper.FillCombo(cmbAccountType, GetAccountTypeList(mainAccount));
        }

        public IEnumerable<DropDown> GetAccountTypeList(string mainAccount)
        {
            IEnumerable<SubExpencesModel> accountType = _subExpencesList.Where(x => x.Option_Name.ToString() == mainAccount).GroupBy(x => x.Expences_Name).Select(x => x.FirstOrDefault());
            var accountTypeList = accountType.Select(x => new DropDown() { Name = x.Expences_Name, Value = x.Expences_ID.ToString() }).ToList();
            accountTypeList.Insert(0, new DropDown() { Name = "-- Select --", Value = (0).ToString() });
            return accountTypeList;
        }

        public IEnumerable<DropDown> GetMainAccountList(IEnumerable<SubExpencesModel> mainList)
        {
            var mainAccountList = mainList.Select(x => new DropDown() { Name = x.Option_Type, Value = x.Option_Name.ToString() }).ToList();
            mainAccountList.Insert(0, new DropDown() { Name = "-- Select --", Value = (0).ToString() });
            return mainAccountList;
        }
    }
}

