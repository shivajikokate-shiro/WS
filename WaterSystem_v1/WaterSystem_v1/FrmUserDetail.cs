using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WaterSystem_Manager.Receiver;
using WaterSystem_Model;
using WaterSystem_v1.Helpers;

namespace WaterSystem_v1
{
    public partial class FrmUserDetail : Form
    {
        UserReciever reciever = null;
        DataHelper helper = null;
        public FrmUserDetail()
        {
            reciever = new UserReciever();
            helper = new DataHelper();
            InitializeComponent();
            Configuration();
        }

        private void Configuration()
        {
            ovlUser.RowHeight = 25;
            ovlUser.EmptyListMsg = "Please start with User.";
            ovlUser.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ovlUser.ShowGroups = true;
            FillOLV();
            RefreshList();
        }

        private void FillOLV()
        {
            try
            {
                ovlUser.Clear();
                List<ListViewColumnsInfo> list = new List<ListViewColumnsInfo>();
                list.Add(new ListViewColumnsInfo() { ColumnSize = 100, Header = helper.GetMemberName((UserModel c) => c.GroupName), Visible = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 300, Header = helper.GetMemberName((UserModel c) => c.UserName), Visible = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 50, Header = helper.GetMemberName((UserModel c) => c.Update), Visible = true, IsButton = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 50, Header = helper.GetMemberName((UserModel c) => c.Delete), Visible = true, IsButton = true });
                helper.GenerateListView(ovlUser, list);
                this.ovlUser.ButtonClick += delegate (object sender, CellClickEventArgs e)
                {
                    switch (e.ColumnIndex)
                    {
                        case 2:
                            FrmAddEditUser addUser = new FrmAddEditUser(e.Model as UserModel);
                            AddEdit(addUser);
                            break;
                        case 3:
                            var model = e.Model as UserModel;
                            DialogResult result = MessageBox.Show(String.Format("Are you sure? you want to delete measurement => {0}", model.UserName), "Delete!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (result.Equals(DialogResult.Yes))
                            {
                                reciever.Delete(model);
                                RefreshList();
                            }
                            break;
                    }
                };
            }
            catch (Exception err) { err.GetBaseException(); }
        }

        private void AddEdit(FrmAddEditUser addUser)
        {
            DialogResult callback = addUser.ShowDialog(this);
            if (DialogResult.OK == callback)
            {
                RefreshList();
            }
        }

        private void RefreshList()
        {
            var measurement = reciever.GetList();
            ovlUser.SetObjects(measurement);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddEditUser addUser = new FrmAddEditUser();
            AddEdit(addUser);
        }
    }  
}
