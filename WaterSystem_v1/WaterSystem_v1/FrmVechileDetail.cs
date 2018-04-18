using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WaterSystem_Manager.Receiver;
using WaterSystem_Model;
using WaterSystem_v1.Helpers;

namespace WaterSystem_v1
{
    public partial class FrmVechileDetail : Form
    {
        VehicleReciever reciever = null;
        DataHelper helper = null;
        public FrmVechileDetail()
        {
            reciever = new VehicleReciever();
            helper = new DataHelper();
            InitializeComponent();
            Configuration();
            RefreshList();
        }

        private void Configuration()
        {
            ovlVechile.RowHeight = 25;
            ovlVechile.EmptyListMsg = "Please start with Vehicle.";
            ovlVechile.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ovlVechile.ShowGroups = false;
            FillOLV();
            var isActiveColumn = ovlVechile.GetColumn(helper.GetMemberName((VehicleModel c) => c.Is_Active));
            isActiveColumn.AspectGetter = delegate (object row)
            {
                bool active = false;
                if (((VehicleModel)row).Is_Active)
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
                ovlVechile.Clear();
                var modelType = typeof(VehicleModel);
                List<ListViewColumnsInfo> list = new List<ListViewColumnsInfo>();
                list.Add(new ListViewColumnsInfo() { ColumnSize = 100, Header = helper.GetMemberName((VehicleModel c) => c.Vehical_No), Visible = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 300, Header = helper.GetMemberName((VehicleModel c) => c.Employee_Name), Visible = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 100, Header = helper.GetMemberName((VehicleModel c) => c.Contact), Visible = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 100, Header = helper.GetMemberName((VehicleModel c) => c.Employee_Address), Visible = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 100, Header = helper.GetMemberName((VehicleModel c) => c.Description), Visible = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 55, Header = helper.GetMemberName((VehicleModel c) => c.Is_Active), Visible = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 50, Header = helper.GetMemberName((VehicleModel c) => c.Update), Visible = true, IsButton = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 50, Header = helper.GetMemberName((VehicleModel c) => c.Delete), Visible = true, IsButton = true });
                helper.GenerateListView(ovlVechile, list);
                this.ovlVechile.ButtonClick += delegate (object sender, CellClickEventArgs e)
                {
                    switch (e.ColumnIndex)
                    {
                        case 6:
                            FrmAddEditVechile addVehicle = new FrmAddEditVechile(e.Model as VehicleModel);
                            AddEdit(addVehicle);
                            break;
                        case 7:
                            var model = e.Model as VehicleModel;
                            DialogResult result = MessageBox.Show(String.Format("Are you sure? you want to delete vehicle => {0}", model.Vehical_No), "Delete!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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

        private void AddEdit(FrmAddEditVechile addVehicle)
        {
            DialogResult callback = addVehicle.ShowDialog(this);
            if (DialogResult.OK == callback)
            {
                RefreshList();
            }
        }

        private void RefreshList()
        {
            var measurement = reciever.GetList();
            ovlVechile.SetObjects(measurement);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddEditVechile addVehicle = new FrmAddEditVechile();
            AddEdit(addVehicle);
        }
    }
}
