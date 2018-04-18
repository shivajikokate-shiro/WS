using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WaterSystem_Manager.Receiver;
using WaterSystem_Model;
using WaterSystem_v1.Helpers;

namespace WaterSystem_v1
{
    public partial class FrmRootDetail : Form
    {
        RootReciever reciever = null;
        DataHelper helper = null;
        public FrmRootDetail()
        {
            reciever = new RootReciever();
            helper = new DataHelper();
            InitializeComponent();
            Configuration();
            RefreshList();
        }

        private void RefreshList()
        {
            ovlRoot.SetObjects(reciever.GetList());
        }

        private void Configuration()
        {
            ovlRoot.RowHeight = 25;
            ovlRoot.EmptyListMsg = "Please start with item.";
            ovlRoot.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ovlRoot.ShowGroups = true;
            FillOlv();
            var isActiveColumn = ovlRoot.GetColumn(helper.GetMemberName((RootModel c) => c.IsCheck));
            isActiveColumn.AspectGetter = delegate (object row)
            {
                bool active = false;
                if (((RootModel)row).IsCheck)
                {
                    active = true;
                }
                return active;
            };
            isActiveColumn.Renderer = new MappedImageRenderer(new Object[] { true, global::WaterSystem_v1.Properties.ImageResource.active, false, global::WaterSystem_v1.Properties.ImageResource.inactive });
            isActiveColumn.TextAlign = HorizontalAlignment.Center;
        }

        private void FillOlv()
        {
            try
            {
                ovlRoot.Clear();

                List<ListViewColumnsInfo> list = new List<ListViewColumnsInfo>();
                list.Add(new ListViewColumnsInfo() { ColumnSize = 150, Header = helper.GetMemberName((RootModel c) => c.SourceName), Visible = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 300, Header = helper.GetMemberName((RootModel c) => c.DestinationName), Visible = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 55, Header = helper.GetMemberName((RootModel c) => c.IsCheck), Visible = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 50, Header = helper.GetMemberName((RootModel c) => c.Update), Visible = true, IsButton = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 50, Header = helper.GetMemberName((RootModel c) => c.Delete), Visible = true, IsButton = true });

                helper.GenerateListView(ovlRoot, list);

                this.ovlRoot.ButtonClick += delegate (object sender, CellClickEventArgs e)
                {
                    switch (e.ColumnIndex)
                    {
                        case 3:
                            FrmAddEditRoot updateItem = new FrmAddEditRoot(e.Model as RootModel);
                            AddEdit(updateItem);
                            break;
                        case 4:
                            var model = e.Model as RootModel;
                            DialogResult result = MessageBox.Show(String.Format("Are you sure? you want to delete root => {0} to {1}", model.DestinationName, model.SourceName), "Delete!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (result.Equals(DialogResult.Yes))
                            {
                                reciever.Delete(model);
                                RefreshList();
                            }
                            break;
                    }
                };
            }
            catch (Exception ex)
            {

            }
        }

        private void AddEdit(FrmAddEditRoot rootForm)
        {
            DialogResult callback = rootForm.ShowDialog(this);
            if (DialogResult.OK == callback)
            {
                RefreshList();
            }
        }

        private void pnlTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddEditRoot rootForm = new FrmAddEditRoot();
            AddEdit(rootForm);
        }
    }
}
