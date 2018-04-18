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
    public partial class FrmAccountDetail : Form
    {
        ExpencesReciever reciever = null;
        DataHelper helper = null;
        public FrmAccountDetail()
        {
            reciever = new ExpencesReciever();
            helper = new DataHelper();
            InitializeComponent();
            Configuration();
            RefreshList();
        }

        private void Configuration()
        {
            ovlAccount.RowHeight = 25;
            ovlAccount.EmptyListMsg = "Please start with Account details.";
            ovlAccount.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ovlAccount.ShowGroups = false;
            FillOLV();
            var isActiveColumn = ovlAccount.GetColumn(helper.GetMemberName((ExpencesModel c) => c.IsActive));
            isActiveColumn.AspectGetter = delegate (object row)
            {
                bool active = false;
                if (((ExpencesModel)row).IsActive)
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
                ovlAccount.Clear();
                List<ListViewColumnsInfo> list = new List<ListViewColumnsInfo>();
                list.Add(new ListViewColumnsInfo() { ColumnSize = 100, Header = helper.GetMemberName((ExpencesModel c) => c.Expences_ID), Visible = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 300, Header = helper.GetMemberName((ExpencesModel c) => c.Expences_Name), Visible = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 100, Header = helper.GetMemberName((ExpencesModel c) => c.Option_Type), Visible = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 55, Header = helper.GetMemberName((ExpencesModel c) => c.IsActive), Visible = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 50, Header = helper.GetMemberName((ExpencesModel c) => c.Update), Visible = true, IsButton = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 50, Header = helper.GetMemberName((ExpencesModel c) => c.Delete), Visible = true, IsButton = true });
                helper.GenerateListView(ovlAccount, list);
                this.ovlAccount.ButtonClick += delegate (object sender, CellClickEventArgs e)
                {
                    switch (e.ColumnIndex)
                    {
                        case 4:
                            FrmAddEditAccount addTransportation = new FrmAddEditAccount(e.Model as ExpencesModel, reciever.GetList());
                            AddEdit(addTransportation);
                            break;
                        case 5:
                            var model = e.Model as ExpencesModel;
                            DialogResult result = MessageBox.Show(String.Format("Are you sure? you want to delete account => {0}", model.Expences_Name), "Delete!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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

        private void AddEdit(FrmAddEditAccount addAccount)
        {
            DialogResult callback = addAccount.ShowDialog(this);
            if (DialogResult.OK == callback)
            {
                RefreshList();
            }
        }

        private void RefreshList()
        {
            var measurement = reciever.GetList();
            ovlAccount.SetObjects(measurement);
        }

        private void pnlTopContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddEditAccount addAccount = new FrmAddEditAccount(reciever.GetList());
            AddEdit(addAccount);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
