using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WaterSystem_Manager.Receiver;
using WaterSystem_Model;
using WaterSystem_v1.Helpers;

namespace WaterSystem_v1
{
    public partial class FrmCustomerDetail : Form
    {
        CustomerReciever reciever = null;
        DataHelper helper = null;

        public FrmCustomerDetail()
        {
            reciever = new CustomerReciever();
            helper = new DataHelper();
            InitializeComponent();
            Configuration();
            RefreshList();

        }

        private void Configuration()
        {
            ovlCustomer.RowHeight = 25;
            ovlCustomer.EmptyListMsg = "Please start with Customer.";
            ovlCustomer.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ovlCustomer.ShowGroups = false;
            FillOLV();
            var isActiveColumn = ovlCustomer.GetColumn(helper.GetMemberName((CustomerModel c) => c.IsActive));
            isActiveColumn.AspectGetter = delegate (object row)
            {
                bool active = false;
                if (((CustomerModel)row).IsActive)
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
                ovlCustomer.Clear();
                var modelType = typeof(CustomerModel);
                List<ListViewColumnsInfo> list = new List<ListViewColumnsInfo>();
                list.Add(new ListViewColumnsInfo() { ColumnSize = 100, Header = helper.GetMemberName((CustomerModel c) => c.Customer_Id), Visible = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 300, Header = helper.GetMemberName((CustomerModel c) => c.Comp_Name), Visible = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 100, Header = helper.GetMemberName((CustomerModel c) => c.Cust_Mobileno), Visible = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 100, Header = helper.GetMemberName((CustomerModel c) => c.Address), Visible = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 100, Header = helper.GetMemberName((CustomerModel c) => c.VatNo), Visible = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 55, Header = helper.GetMemberName((CustomerModel c) => c.IsActive), Visible = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 50, Header = helper.GetMemberName((CustomerModel c) => c.Update), Visible = true, IsButton = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 50, Header = helper.GetMemberName((CustomerModel c) => c.Delete), Visible = true, IsButton = true });
                helper.GenerateListView(ovlCustomer, list);
                this.ovlCustomer.ButtonClick += delegate (object sender, CellClickEventArgs e)
                {
                    switch (e.ColumnIndex)
                    {
                        case 6:
                            FrmAddEditCustomer addCustomer = new FrmAddEditCustomer(e.Model as CustomerModel);
                            AddEdit(addCustomer);
                            break;
                        case 7:
                            var model = e.Model as CustomerModel;
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

        private void AddEdit(FrmAddEditCustomer addCustomer)
        {
            DialogResult callback = addCustomer.ShowDialog(this);
            if (DialogResult.OK == callback)
            {
                RefreshList();
            }
        }

        private void RefreshList()
        {
            var measurement = reciever.GetList();
            ovlCustomer.SetObjects(measurement);
        }

        private void ovlCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddEditCustomer addCustomer = new FrmAddEditCustomer();
            AddEdit(addCustomer);
        }
    }
}
