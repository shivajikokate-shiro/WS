using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BrightIdeasSoftware;
using WaterSystem_Manager.Receiver;
using WaterSystem_Model;
using WaterSystem_v1.Helpers;

namespace WaterSystem_v1
{
    public partial class FrmRowMaterialDetail : Form
    {
        RowMaterialReciever reciever = null;
        DataHelper helper = null;
        public FrmRowMaterialDetail()
        {
            reciever = new RowMaterialReciever();
            helper = new DataHelper();
            InitializeComponent();
            Configuration();
            RefreshList();
        }

        private void Configuration()
        {
            ovlRowMaterial.RowHeight = 25;
            ovlRowMaterial.EmptyListMsg = "Please start with Employee.";
            ovlRowMaterial.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ovlRowMaterial.ShowGroups = true;
            FillOLV();
            var isActiveColumn = ovlRowMaterial.GetColumn(helper.GetMemberName((RowMaterialModel c) => c.IsActive));
            isActiveColumn.AspectGetter = delegate (object row)
            {
                bool active = false;
                if (((RowMaterialModel)row).IsActive)
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
                ovlRowMaterial.Clear();
                List<ListViewColumnsInfo> list = new List<ListViewColumnsInfo>();
                list.Add(new ListViewColumnsInfo() { ColumnSize = 100, Header = helper.GetMemberName((RowMaterialModel c) => c.RowHedarName), Visible = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 300, Header = helper.GetMemberName((RowMaterialModel c) => c.RowMaterialName), Visible = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 100, Header = helper.GetMemberName((RowMaterialModel c) => c.MeasurmentName), Visible = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 55, Header = helper.GetMemberName((RowMaterialModel c) => c.IsActive), Visible = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 50, Header = helper.GetMemberName((RowMaterialModel c) => c.Update), Visible = true, IsButton = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 50, Header = helper.GetMemberName((RowMaterialModel c) => c.Delete), Visible = true, IsButton = true });
                helper.GenerateListView(ovlRowMaterial, list);
                this.ovlRowMaterial.ButtonClick += delegate (object sender, CellClickEventArgs e)
                {
                    switch (e.ColumnIndex)
                    {
                        case 4:
                            FrmAddEditRowMaterial addEmployee = new FrmAddEditRowMaterial(e.Model as RowMaterialModel);
                            AddEdit(addEmployee);
                            break;
                        case 5:
                            var model = e.Model as RowMaterialModel;
                            DialogResult result = MessageBox.Show(String.Format("Are you sure? you want to delete row material => {0}", model.RowMaterialName), "Delete!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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

        private void AddEdit(FrmAddEditRowMaterial addEmployee)
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
            ovlRowMaterial.SetObjects(measurement);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddEditRowMaterial addRowMaterial = new FrmAddEditRowMaterial();
            AddEdit(addRowMaterial);
        }
    }
}
