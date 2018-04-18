using System;
using System.Linq;
using System.Windows.Forms;
using WaterSystem_Model;
using WaterSystem_Manager.Receiver;
using System.Collections.Generic;
using System.Drawing;

namespace WaterSystem_v1
{
    public partial class FrmAddEditRoot : Form
    {
        RootModel _model = null;
        RootReciever reciever = null;
        public FrmAddEditRoot()
        {
            InitializeComponent();
        }

        public FrmAddEditRoot(RootModel model)
        {
            InitializeComponent();
            _model = model;
        }

        private void ConfigureStyle()
        {
            toggleActive.Style = JCS.ToggleSwitch.ToggleSwitchStyle.Iphone;
            toggleActive.Size = new Size(68, 22);
            toggleActive.OnText = "Yes";
            toggleActive.OnFont = new Font(this.Font.FontFamily, 10, FontStyle.Bold);
            toggleActive.OnForeColor = Color.White;
            toggleActive.OffText = "No";
            toggleActive.OffFont = new Font(this.Font.FontFamily, 10, FontStyle.Bold);
            toggleActive.OffForeColor = Color.FromArgb(92, 92, 92);
        }


        private void FrmAddEditRoot_Load(object sender, EventArgs e)
        {
            ConfigureStyle();
            reciever = new RootReciever();
            var sources = reciever.GetSources();
            // Fill Combo box
            Helpers.DataHelper helper = new Helpers.DataHelper();
            var sourceList = sources.Select(x => new DropDown() { Name = x.SourceName, Value = x.SourceId.ToString() }).ToList();
            sourceList.Insert(0, new DropDown() { Name = "-- Select --", Value = (0).ToString() });
            helper.FillCombo(cmbSource, sourceList);

            if (_model != null)
            {
                var destinationList = GetDestinationList(_model.Source.ToString());
                helper.FillCombo(cmbDestination, destinationList);
                txtRoot.Text = string.Format("{0} To {1}", _model.DestinationName, _model.SourceName);
                cmbSource.SelectedIndex = sourceList.Select((obj, index) => new { obj, index }).Where(x => x.obj.Value == _model.Source.ToString()).Select(x=>x.index).FirstOrDefault();
                cmbDestination.SelectedIndex = destinationList.Select((obj, index) => new { obj, index }).Where(x => x.obj.Value == _model.DestinationId.ToString()).Select(x => x.index).FirstOrDefault();
                toggleActive.Checked = _model.IsCheck;
            }
            else
            {
                _model = new RootModel();
                cmbSource.SelectedIndex = 0;
                cmbDestination.SelectedIndex = 0;
            }
        }

        private void cmbSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            Helpers.DataHelper helper = new Helpers.DataHelper();
            ComboBox combo = (ComboBox)sender;
            var selectedItem = (DropDown)combo.SelectedItem;
            helper.FillCombo(cmbDestination, GetDestinationList(selectedItem.Value));
            cmbDestination.SelectedIndex = 0;
        }

        private IEnumerable<DropDown> GetDestinationList(string source = null)
        {
            var destination = reciever.GetSources().Where(x => x.SourceId.ToString() != source);
            var destinationList = destination.Select(x => new DropDown() { Name = x.SourceName, Value = x.SourceId.ToString() }).ToList();
            destinationList.Insert(0, new DropDown() { Name = "-- Select --", Value = (0).ToString() });
            return destinationList;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (_model != null)
                {
                    _model.DestinationId = Convert.ToDecimal(((DropDown)cmbDestination.SelectedItem).Value);
                    _model.Source = Convert.ToDecimal(((DropDown)cmbSource.SelectedItem).Value);
                    _model.IsCheck = toggleActive.Checked;
                    if (_model.RootId > 0)
                    {
                        reciever.Update(_model);
                    }
                    else
                    {
                        reciever.Add(_model);
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            var source = ((DropDown)cmbSource.SelectedItem).Name;
            var destination = ((DropDown)cmbDestination.SelectedItem).Name;
            txtRoot.Text = string.Format("{0} To {1}", source, destination);
        }
    }
}
