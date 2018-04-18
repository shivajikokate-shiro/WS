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
    public partial class FrmAddEditUser : Form
    {
        UserModel _model = null;
        UserReciever reciever = null;
        public FrmAddEditUser()
        {
            InitializeComponent();
        }

        public FrmAddEditUser(UserModel user)
        {
            _model = user;
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (_model != null)
                {
                    _model.UserName = txtUserName.Text;
                    _model.Password = txtPassword.Text;
                    _model.GroupId = Convert.ToDecimal((cmbGroupType.SelectedItem as DropDown).Value);
                    if (_model.UserId > 0)
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

        private void FrmAddEditUser_Load(object sender, EventArgs e)
        {
            reciever = new UserReciever();
            // Fill Combo box
            Helpers.DataHelper helper = new Helpers.DataHelper();
            var dataList = GetGroup().Select(x => new DropDown() { Name = x.GroupName, Value = x.GroupId.ToString() }).ToList();
            dataList.Insert(0, new DropDown() { Name = "-- Select --", Value = (0).ToString() });
            helper.FillCombo(cmbGroupType, dataList);
            if (_model != null)
            {
                cmbGroupType.SelectedIndex = dataList.Select((obj, index) => new { obj, index }).Where(x => x.obj.Value == _model.GroupId.ToString()).Select(x => x.index).FirstOrDefault();
                txtUserName.Text = _model.UserName;
                txtPassword.Text = _model.Password;
                txtConfirmPassword.Text = _model.Password;
            }
            else
            {
                _model = new UserModel();
                cmbGroupType.SelectedIndex = 0;
            }
        }

        private IEnumerable<GroupModel> GetGroup()
        {
            return reciever.GetGroupDetails();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
