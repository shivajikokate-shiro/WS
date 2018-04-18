using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WaterSystem_Manager.Receiver;
using WaterSystem_Model;
using WaterSystem_v1.Helpers;

namespace WaterSystem_v1
{
    public partial class FrmTransportationDetail : Form
    {
        TransportationReciever reciever = null;
        DataHelper helper = null;
        public FrmTransportationDetail()
        {
            reciever = new TransportationReciever();
            helper = new DataHelper();
            InitializeComponent();
            Configuration();
            RefreshList();
        }

        private void Configuration()
        {
            ovlTransportation.RowHeight = 25;
            ovlTransportation.EmptyListMsg = "Please start with Transporation details.";
            ovlTransportation.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ovlTransportation.ShowGroups = false;
            FillOLV();
            var isActiveColumn = ovlTransportation.GetColumn(helper.GetMemberName((TransportationModel c) => c.IsActive));
            isActiveColumn.AspectGetter = delegate (object row)
            {
                bool active = false;
                if (((TransportationModel)row).IsActive)
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
                ovlTransportation.Clear();
                var modelType = typeof(TransportationModel);
                List<ListViewColumnsInfo> list = new List<ListViewColumnsInfo>();
                list.Add(new ListViewColumnsInfo() { ColumnSize = 100, Header = helper.GetMemberName((TransportationModel c) => c.Transportation_Id), Visible = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 300, Header = helper.GetMemberName((TransportationModel c) => c.Transportation_Name), Visible = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 100, Header = helper.GetMemberName((TransportationModel c) => c.Transportation_Number), Visible = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 150, Header = helper.GetMemberName((TransportationModel c) => c.Transportation_Address), Visible = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 55, Header = helper.GetMemberName((TransportationModel c) => c.IsActive), Visible = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 50, Header = helper.GetMemberName((TransportationModel c) => c.Update), Visible = true, IsButton = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 50, Header = helper.GetMemberName((TransportationModel c) => c.Delete), Visible = true, IsButton = true });
                helper.GenerateListView(ovlTransportation, list);
                this.ovlTransportation.ButtonClick += delegate (object sender, CellClickEventArgs e)
                {
                    switch (e.ColumnIndex)
                    {
                        case 5:
                            FrmAddEditTransportation addTransportation = new FrmAddEditTransportation(e.Model as TransportationModel);
                            AddEdit(addTransportation);
                            break;
                        case 6:
                            var model = e.Model as TransportationModel;
                            DialogResult result = MessageBox.Show(String.Format("Are you sure? you want to delete transportation => {0}", model.Transportation_Name), "Delete!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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

        private void AddEdit(FrmAddEditTransportation addTransportation)
        {
            DialogResult callback = addTransportation.ShowDialog(this);
            if (DialogResult.OK == callback)
            {
                RefreshList();
            }
        }

        private void RefreshList()
        {
            var measurement = reciever.GetList();
            ovlTransportation.SetObjects(measurement);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddEditTransportation addTransportation = new FrmAddEditTransportation();
            AddEdit(addTransportation);
        }
    }
}
