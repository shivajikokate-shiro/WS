using BrightIdeasSoftware;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WaterSystem_Manager.Reciever;
using WaterSystem_Model;
using WaterSystem_v1.Helpers;

namespace WaterSystem_v1
{
    public partial class FrmMeasurementDetail : Form
    {
        MeasurementReciever reciever = null;
        DataHelper helper = null;

        public FrmMeasurementDetail()
        {
            try
            {
                reciever = new MeasurementReciever();
                helper = new DataHelper();
                InitializeComponent();
                Configuration();
                RefreshList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void RefreshList()
        {
            var measurement = reciever.GetList();
            ovlMeasurement.SetObjects(measurement);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmAddEditMeasurement addMeasurement = new FrmAddEditMeasurement();
            AddEdit(addMeasurement);
        }

        private void Configuration()
        {
            ovlMeasurement.RowHeight = 25;
            ovlMeasurement.EmptyListMsg = "Please start with Measurement.";
            ovlMeasurement.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            ovlMeasurement.ShowGroups = false;
            FillOLV();
            var isActiveColumn = ovlMeasurement.GetColumn(helper.GetMemberName((MeasurementModel c) => c.IsActive));
            isActiveColumn.AspectGetter = delegate (object row)
            {
                bool active = false;
                if (((MeasurementModel)row).IsActive)
                { 
                    active = true;
                }
                return active;
            };

            isActiveColumn.Renderer = new MappedImageRenderer(new Object[] { true, global::WaterSystem_v1.Properties.ImageResource.active, false, global::WaterSystem_v1.Properties.ImageResource.inactive});
            isActiveColumn.TextAlign = HorizontalAlignment.Center;
        }

        private void FillOLV()
        {
            try
            {
                ovlMeasurement.Clear();
                var modelType = typeof(MeasurementModel);
                List<ListViewColumnsInfo> list = new List<ListViewColumnsInfo>();
                list.Add(new ListViewColumnsInfo() { ColumnSize = 100, Header = helper.GetMemberName((MeasurementModel c) => c.MeasurmentId), Visible = false });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 300, Header = helper.GetMemberName((MeasurementModel c) => c.MeasurmentName), Visible = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 55, Header = helper.GetMemberName((MeasurementModel c) => c.IsActive), Visible = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 50, Header = helper.GetMemberName((MeasurementModel c) => c.Update), Visible = true, IsButton = true });
                list.Add(new ListViewColumnsInfo() { ColumnSize = 50, Header = helper.GetMemberName((MeasurementModel c) => c.Delete), Visible = true, IsButton = true });
                helper.GenerateListView(ovlMeasurement, list);

                this.ovlMeasurement.ButtonClick += delegate (object sender, CellClickEventArgs e)
                {
                    switch (e.ColumnIndex)
                    {
                        case 3:
                            FrmAddEditMeasurement addMeasurement = new FrmAddEditMeasurement(e.Model as MeasurementModel);
                            AddEdit(addMeasurement);
                            break;
                        case 4:
                            var model = e.Model as MeasurementModel;
                            DialogResult result = MessageBox.Show(String.Format("Are you sure? you want to delete measurement => {0}", model.MeasurmentName), "Delete!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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

        private void AddEdit(FrmAddEditMeasurement addMeasurement)
        {
            DialogResult callback = addMeasurement.ShowDialog(this);
            if (DialogResult.OK == callback)
            {
                RefreshList();
            }
        }

        private void pnlClear_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text.ToString().Length >= 3)
            {
                TextMatchFilter filter = TextMatchFilter.Contains(this.ovlMeasurement, ((TextBox)sender).Text);
                this.ovlMeasurement.ModelFilter = filter;
                if (this.ovlMeasurement.DefaultRenderer == null)
                    this.ovlMeasurement.DefaultRenderer = new HighlightTextRenderer(filter);
                this.ovlMeasurement.AdditionalFilter = filter;
            }
        }

        private void pnlButtonRight_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
