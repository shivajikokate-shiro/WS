using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaterSystem_v1
{
    public partial class frmMain : Form
    {
        string selectedTabStorage; 
        public frmMain()
        {
            Logs.Logger.Info("======= Application start ======");
            InitializeComponent();
            OpentDashboard();
        }

        private void lbl_MouseLeave(object sender, EventArgs e)
        {
            var control = (Control)sender;
            if (selectedTabStorage != control.Name)
            {
                control.BackColor = NormalLeftPanelColor();
            }
        }

        private void lbl_MouseMove(object sender, MouseEventArgs e)
        {
            var control = (Control)sender;
            control.BackColor = SelectedLeftPanelColor();
        }

        private void SetSelectedTab(string newConrolString)
        {

            if (!String.IsNullOrEmpty(selectedTabStorage))
            {
                var ct = GetControl(this, selectedTabStorage);
                if (ct != null)
                {
                    ct.BackColor = NormalLeftPanelColor();
                }
            }

            selectedTabStorage = newConrolString;
            if (!String.IsNullOrEmpty(selectedTabStorage))
            {
                var pt = GetControl(this, selectedTabStorage);
                if (pt != null)
                {
                    pt.BackColor = NormalLeftPanelColor();
                }
            }
            
        }

        private Control GetControl(Control source, string controlName)
        {
            Control answerControl = null;
            var controls = source.Controls;
            foreach (Control control in controls)
            {
                answerControl = control.Controls[controlName];
                if (answerControl != null)
                {
                    break;
                }
                foreach (Control aa in control.Controls)
                {
                    answerControl = aa.Controls[controlName];
                    if (answerControl != null)
                    {
                        break;
                    }
                }
            }
            return answerControl;
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            var control = ((Control)sender);
            SetSelectedTab(control.Name);
            OpentDashboard();
        }      

        private void lblMaster_Click(object sender, EventArgs e)
        {
            var control = ((Control)sender);
            SetSelectedTab(control.Name);
            OpenMaster();
        }        

        private void lblInventory_Click(object sender, EventArgs e)
        {
            var control = ((Control)sender);
            SetSelectedTab(control.Name);
            OpenInventory();
        }  

        #region Manual
        // Left Panel Color
        private Color SelectedLeftPanelColor()
        {
            return Color.FromArgb(31, 43, 55);
        }

        private Color NormalLeftPanelColor()
        {
            return pnlLeftPanel.BackColor;
        }
        
        // Open Dashboard tab
        private void OpentDashboard()
        {
            Logs.Logger.Info("Open dashboard container.");
            FrmDashboardContainer dashboardContainer = new FrmDashboardContainer();
            Helpers.FormHelper.OpenForm(pnlContainer, dashboardContainer);
        }

        //Open Master Tab
        private void OpenMaster()
        {
            Logs.Logger.Info("Open master section.");
            FrmMasterContainer master = new FrmMasterContainer();
            Helpers.FormHelper.OpenForm(pnlContainer, master);
        }

        // Open Invetory Tab
        private void OpenInventory()
        {
            Logs.Logger.Info("Open inventory section.");
            FrmInventoryContainer inventory = new FrmInventoryContainer();
            Helpers.FormHelper.OpenForm(pnlContainer, inventory);
        }

        // Open Transaction Tab
        private void OpenTransaction()
        {
            Logs.Logger.Info("Open transaction section.");
            FrmTransactionContainer transaction = new FrmTransactionContainer();
            Helpers.FormHelper.OpenForm(pnlContainer, transaction);
        }

        #endregion

        private void pnlTransporation_Click(object sender, EventArgs e)
        {
            Logs.Logger.Info("Open transportation section.");
            FrmTransportationContainer transportationContainer = new FrmTransportationContainer();
            Helpers.FormHelper.OpenForm(pnlContainer, transportationContainer);
        }

        private void pnlUser_Click(object sender, EventArgs e)
        {
            Logs.Logger.Info("Open user section.");
            FrmUserDetail userDetails = new FrmUserDetail();
            Helpers.FormHelper.OpenForm(pnlContainer, userDetails);
        }

        private void lblTransaction_Click(object sender, EventArgs e)
        {
            var control = ((Control)sender);
            SetSelectedTab(control.Name);
            OpenTransaction();
        }

        private void lblReports_Click(object sender, EventArgs e)
        {
            var control = ((Control)sender);
            SetSelectedTab(control.Name);
        }
    }
}
