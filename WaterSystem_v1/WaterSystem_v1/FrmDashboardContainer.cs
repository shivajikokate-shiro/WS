using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaterSystem_v1.Helpers;

namespace WaterSystem_v1
{
    public partial class FrmDashboardContainer : Form
    {
        public FrmDashboardContainer()
        {
            InitializeComponent();
        }

        private void FrmDashboardContainer_Load(object sender, EventArgs e)
        {
            LoadBasics();
        }

        private void LoadBasics()
        {
            FrmDashboardCharts dashboard = new FrmDashboardCharts();
            FormHelper.OpenForm(pnlChartsContainer, dashboard);
        }
    }
}
