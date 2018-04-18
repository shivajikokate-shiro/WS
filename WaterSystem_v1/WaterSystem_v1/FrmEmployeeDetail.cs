using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WaterSystem_Manager.Receiver;
using WaterSystem_Model;
using WaterSystem_v1.Helpers;

namespace WaterSystem_v1
{
    public partial class FrmEmployeeDetail : Form
    {
        EmployeeReciever reciever = null;
        DataHelper helper = null;
        public FrmEmployeeDetail()
        {
            reciever = new EmployeeReciever();
            helper = new DataHelper();
            InitializeComponent();
            Configuration();
            RefreshList();
        }

        private void Configuration()
        {
            ovlEmployee.RowHeight = 25;
            ovlEmployee.EmptyListMsg = "Please start with Employee.";
            ovlEmployee.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ovlEmployee.ShowGroups = false;
            FillOLV();
            var isActiveColumn = ovlEmployee.GetColumn(helper.GetMemberName((EmployeeModel c) => c.IsCheck));
            isActiveColumn.AspectGetter = delegate (object row)
            {
                bool active = false;
                if (((EmployeeModel)row).IsCheck)
                {
                    active = true;
                }
                return active;
            };

            isActiveColumn.Renderer = new MappedImageRenderer(new Object[] { true, global::WaterSystem_v1.Properties.ImageResource.active, false, global::WaterSystem_v1.Properties.ImageResource.inactive });
            isActiveColumn.TextAlign = HorizontalAlignment.Center;
        }

        private void FillOLV()
        {
            try
            {
                ovlEmployee.Clear();
                List<ListViewColumnsInfo> list = new List<ListViewColumnsInfo>();
                list.Add(new ListViewColumnsInfo() { ColumnSize = 100, Header = helper.GetMemberName((EmployeeModel c) => c.Emp_Id), Visible = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 300, Header = helper.GetMemberName((EmployeeModel c) => c.Emp_Name), Visible = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 100, Header = helper.GetMemberName((EmployeeModel c) => c.Emp_Mob), Visible = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 100, Header = helper.GetMemberName((EmployeeModel c) => c.Emp_Add), Visible = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 80, Header = helper.GetMemberName((EmployeeModel c) => c.Emp_BirthDate), Visible = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 80, Header = helper.GetMemberName((EmployeeModel c) => c.Emp_JoinDate), Visible = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 80, Header = helper.GetMemberName((EmployeeModel c) => c.Emp_Sal), Visible = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 55, Header = helper.GetMemberName((EmployeeModel c) => c.IsCheck), Visible = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 50, Header = helper.GetMemberName((EmployeeModel c) => c.Update), Visible = true, IsButton = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 50, Header = helper.GetMemberName((EmployeeModel c) => c.Delete), Visible = true, IsButton = true });
                helper.GenerateListView(ovlEmployee, list);
                this.ovlEmployee.ButtonClick += delegate (object sender, CellClickEventArgs e)
                {
                    switch (e.ColumnIndex)
                    {
                        case 8:
                            FrmAddEditEmployee addEmployee = new FrmAddEditEmployee(e.Model as EmployeeModel);
                            AddEdit(addEmployee);
                            break;
                        case 9:
                            var model = e.Model as EmployeeModel;
                            DialogResult result = MessageBox.Show(String.Format("Are you sure? you want to delete employee => {0}", model.Emp_Name), "Delete!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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

        private void AddEdit(FrmAddEditEmployee addEmployee)
        {
            DialogResult callback = addEmployee.ShowDialog(this);
            if (DialogResult.OK == callback)
            {
                RefreshList();
            }
        }

        private void RefreshList()
        {
            var measurement = reciever.GetList();
            ovlEmployee.SetObjects(measurement);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddEditEmployee addEmployee = new FrmAddEditEmployee();
            AddEdit(addEmployee);
        }
    }
}
