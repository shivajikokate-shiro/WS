using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WaterSystem_Manager.Receiver;
using WaterSystem_Model;
using WaterSystem_v1.Helpers;
namespace WaterSystem_v1
{
    public partial class FrmSupplierDetail : Form
    {
        SupplierReciever reciever = null;
        DataHelper helper = null;
        public FrmSupplierDetail()
        {
            reciever = new SupplierReciever();
            helper = new DataHelper();
            InitializeComponent();
            Configuration();
            RefreshList();
        }

        private void Configuration()
        {
            ovlSupplier.RowHeight = 25;
            ovlSupplier.EmptyListMsg = "Please start with Supplier.";
            ovlSupplier.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ovlSupplier.ShowGroups = false;
            FillOLV();
            var isActiveColumn = ovlSupplier.GetColumn(helper.GetMemberName((SupplierModel c) => c.IsActive));
            isActiveColumn.AspectGetter = delegate (object row)
            {
                bool active = false;
                if (((SupplierModel)row).IsActive)
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
                ovlSupplier.Clear();
                List<ListViewColumnsInfo> list = new List<ListViewColumnsInfo>();
                list.Add(new ListViewColumnsInfo() { ColumnSize = 100, Header = helper.GetMemberName((SupplierModel c) => c.Supplier_Id), Visible = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 300, Header = helper.GetMemberName((SupplierModel c) => c.Comp_Name), Visible = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 100, Header = helper.GetMemberName((SupplierModel c) => c.Supplier_Mobileno), Visible = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 100, Header = helper.GetMemberName((SupplierModel c) => c.Address), Visible = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 100, Header = helper.GetMemberName((SupplierModel c) => c.VatNo), Visible = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 55, Header = helper.GetMemberName((SupplierModel c) => c.IsActive), Visible = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 50, Header = helper.GetMemberName((SupplierModel c) => c.Update), Visible = true, IsButton = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 50, Header = helper.GetMemberName((SupplierModel c) => c.Delete), Visible = true, IsButton = true });
                helper.GenerateListView(ovlSupplier, list);
                this.ovlSupplier.ButtonClick += delegate (object sender, CellClickEventArgs e)
                {
                    switch (e.ColumnIndex)
                    {
                        case 6:
                            FrmAddEditSupplier addSupplier = new FrmAddEditSupplier(e.Model as SupplierModel);
                            AddEdit(addSupplier);
                            break;
                        case 7:
                            var model = e.Model as SupplierModel;
                            DialogResult result = MessageBox.Show(String.Format("Are you sure? you want to delete measurement => {0}", model.Comp_Name), "Delete!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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

        private void AddEdit(FrmAddEditSupplier addSupplier)
        {
            DialogResult callback = addSupplier.ShowDialog(this);
            if (DialogResult.OK == callback)
            {
                RefreshList();
            }
        }

        private void RefreshList()
        {
            var measurement = reciever.GetList();
            ovlSupplier.SetObjects(measurement);
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddEditSupplier addSupplier = new FrmAddEditSupplier();
            AddEdit(addSupplier);
        }
    }
}
