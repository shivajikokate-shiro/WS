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
    public partial class FrmTransportationContainer : Form
    {
        FrmTransportationDetail transportationDetail = null;
        FrmVechileDetail vehicleDetail = null;
        FrmRootDetail routeDetail = null;
        public FrmTransportationContainer()
        {
            InitializeComponent();
            OpenTab(TransportationTabs.Transportation);
        }

        private void OpenTab(int tabIndex)
        {
            switch (tabIndex)
            {
                case TransportationTabs.Transportation:
                    if (transportationDetail == null)
                    {
                        transportationDetail = new FrmTransportationDetail();
                        Helpers.FormHelper.OpenForm(tabTransportation, transportationDetail);
                    }
                    break;
                case TransportationTabs.Vehicle:
                    if (vehicleDetail == null)
                    {
                        vehicleDetail = new FrmVechileDetail();
                        Helpers.FormHelper.OpenForm(tabVehicle, vehicleDetail);
                    }
                    break;
                case TransportationTabs.Route:
                    if (routeDetail == null)
                    {
                        routeDetail = new FrmRootDetail();
                        Helpers.FormHelper.OpenForm(tabRoute, routeDetail);
                    }
                    break;
            }
        }

        private void tabTrasportationContainer_Click(object sender, EventArgs e)
        {
            OpenTab(tabTrasportationContainer.SelectedIndex);
        }

        private void FrmTransportationContainer_Load(object sender, EventArgs e)
        {
         
        }
    }

    public static class TransportationTabs
    {
        public const int Transportation = 0;
        public const int Vehicle = 1;
        public const int Route = 2;
    }
}
