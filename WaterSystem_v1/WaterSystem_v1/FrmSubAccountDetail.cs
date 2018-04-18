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
    public partial class FrmSubAccountDetail : Form
    {
        SubExpencesReciever reciever = null;
        DataHelper helper = null;
        public FrmSubAccountDetail()
        {
            reciever = new SubExpencesReciever();
            helper = new DataHelper();
            InitializeComponent();
            Configuration();
            RefreshList();
        }

        private void Configuration()
        {
            ovlSubAccount.RowHeight = 25;
            ovlSubAccount.EmptyListMsg = "Please start with Sub Account details.";
            ovlSubAccount.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ovlSubAccount.ShowGroups = false;
            FillOLV();
            var isActiveColumn = ovlSubAccount.GetColumn(helper.GetMemberName((SubExpencesModel c) => c.IsActive));
            isActiveColumn.AspectGetter = delegate (object row)
            {
                bool active = false;
                if (((SubExpencesModel)row).IsActive)
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
                ovlSubAccount.Clear();
                List<ListViewColumnsInfo> list = new List<ListViewColumnsInfo>();
                list.Add(new ListViewColumnsInfo() { ColumnSize = 100, Header = helper.GetMemberName((SubExpencesModel c) => c.SubExpences_ID), Visible = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 300, Header = helper.GetMemberName((SubExpencesModel c) => c.SubExpences_Name), Visible = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 100, Header = helper.GetMemberName((SubExpencesModel c) => c.Expences_Name), Visible = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 100, Header = helper.GetMemberName((SubExpencesModel c) => c.Option_Type), Visible = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 55, Header = helper.GetMemberName((SubExpencesModel c) => c.IsActive), Visible = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 50, Header = helper.GetMemberName((SubExpencesModel c) => c.Update), Visible = true, IsButton = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 50, Header = helper.GetMemberName((SubExpencesModel c) => c.Delete), Visible = true, IsButton = true });
                helper.GenerateListView(ovlSubAccount, list);
                this.ovlSubAccount.ButtonClick += delegate (object sender, CellClickEventArgs e)
                {
                    switch (e.ColumnIndex)
                    {
                        case 5:
                            FrmAddEditSubAccount adddSubAccount = new FrmAddEditSubAccount(e.Model as SubExpencesModel, reciever.GetList());
                            AddEdit(adddSubAccount);
                            break;
                        case 6:
                            var model = e.Model as SubExpencesModel;
                            DialogResult result = MessageBox.Show(String.Format("Are you sure? you want to delete sub account => {0}", model.SubExpences_Name), "Delete!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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

        private void AddEdit(FrmAddEditSubAccount adddSubAccount)
        {
            DialogResult callback = adddSubAccount.ShowDialog(this);
            if (DialogResult.OK == callback)
            {
                RefreshList();
            }
        }

        private void RefreshList()
        {
            var measurement = reciever.GetList();
            ovlSubAccount.SetObjects(measurement);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddEditSubAccount addSubAccount = new FrmAddEditSubAccount(reciever.GetList());
            AddEdit(addSubAccount);
        }
    }
}
