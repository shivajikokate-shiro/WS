using System;
using System.Drawing;
using System.Windows.Forms;
using WaterSystem_Manager.Receiver;
using WaterSystem_Model;
using WaterSystem_Common;

namespace WaterSystem_v1
{
    public partial class FrmAddEditEmployee : Form
    {
        EmployeeReciever reciever = null;
        EmployeeModel _model = null;
        public FrmAddEditEmployee()
        {
            InitializeComponent();
        }

        public FrmAddEditEmployee(EmployeeModel model)
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

        private void FrmAddEditEmployee_Load(object sender, EventArgs e)
        {
            ConfigureStyle();
            reciever = new EmployeeReciever();
            if (_model != null)
            {
                txtName.Text = _model.Emp_Name.ToString();
                txtMobile.Text = _model.Emp_Mob.ToString(); 
                txtAddress.Text = _model.Emp_Add;
                dtpBirthDate.Text = _model.Emp_BirthDate.ToString();
                dtpJoiningDate.Text = _model.Emp_JoinDate.ToString();
                txtSalary.Text = _model.Emp_Sal.ToString();
                txtAddress.Text = _model.Emp_Add.ToString();
                toggleActive.Checked = _model.IsCheck;
            }
            else
            {
                _model = new EmployeeModel();
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
                _model.Emp_Name = txtName.Text.ToString();
                _model.Emp_Sal = Convert.ToDouble(txtSalary.Text);
                _model.Emp_BirthDate = dtpBirthDate.Text.ToDate();
                _model.Emp_JoinDate = dtpJoiningDate.Text.ToDate();
                _model.Emp_Mob = Convert.ToDecimal(txtMobile.Text);
                _model.Emp_Add = txtAddress.Text;
                _model.IsCheck = toggleActive.Checked;
                if (_model.Emp_Id > 0)
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
