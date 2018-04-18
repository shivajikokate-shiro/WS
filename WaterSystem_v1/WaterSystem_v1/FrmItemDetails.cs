using BrightIdeasSoftware;
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
using WaterSystem_v1.Helpers;

namespace WaterSystem_v1
{
    public partial class FrmItemDetails : Form
    {
        ItemReciever itemReciever = null;
        DataHelper helper = null;

        public FrmItemDetails()
        {
            try
            {
                InitializeComponent();
                helper = new DataHelper();
                itemReciever = new ItemReciever();
                Configuration();
            }
            catch (Exception ex)
            {

            }
        }
        
        private void RefreshList()
        {
            ovlItem.SetObjects(itemReciever.GetList());
        }

        private void Configuration()
        {
            ovlItem.RowHeight = 25;
            ovlItem.EmptyListMsg = "Please start with item.";
            ovlItem.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ovlItem.ShowGroups = true;
            FillOlv();
            var isActiveColumn = ovlItem.GetColumn(helper.GetMemberName((ItemModel c) => c.IsActive));
            isActiveColumn.AspectGetter = delegate (object row)
            {
                bool active = false;
                if (((ItemModel)row).IsActive)
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
                ovlItem.Clear();

                List<ListViewColumnsInfo> list = new List<ListViewColumnsInfo>();
                list.Add(new ListViewColumnsInfo() { ColumnSize = 150, Header = helper.GetMemberName((ItemModel c) => c.MeasurmentName), Visible = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 300, Header = helper.GetMemberName((ItemModel c) => c.ItemName), Visible = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 55, Header = helper.GetMemberName((ItemModel c) => c.IsActive), Visible = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 50, Header = helper.GetMemberName((ItemModel c) => c.Update), Visible = true, IsButton = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 50, Header = helper.GetMemberName((ItemModel c) => c.Delete), Visible = true, IsButton = true });

                helper.GenerateListView(ovlItem, list);

                this.ovlItem.ButtonClick += delegate (object sender, CellClickEventArgs e)
                {
                    switch (e.ColumnIndex)
                    {
                        case 3:
                            FrmAddEditItem updateItem = new FrmAddEditItem(e.Model as ItemModel);
                            AddEdit(updateItem);
                            break;
                        case 4:
                            var model = e.Model as ItemModel;
                            DialogResult result = MessageBox.Show(String.Format("Are you sure? you want to delete measurement => {0}", model.ItemName), "Delete!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (result.Equals(DialogResult.Yes))
                            {
                                itemReciever.Delete(model);
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

        private void AddEdit(FrmAddEditItem itemForm)
        {
            DialogResult callback = itemForm.ShowDialog(this);
            if (DialogResult.OK == callback)
            {
                RefreshList();
            }
        }

        private void FrmItemDetails_Load(object sender, EventArgs e)
        {
            RefreshList();
        }     

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddEditItem addItem = new FrmAddEditItem();
            AddEdit(addItem);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
