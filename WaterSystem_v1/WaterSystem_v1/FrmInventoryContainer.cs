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
    public partial class FrmInventoryContainer : Form
    {
        FrmRowMaterialDetail rawMaterial = null;
        FrmBoxwiseBottleQuantityDetail boxwiseQuantity = null;
        FrmProductionManage productionManage = null;
        public FrmInventoryContainer()
        {
            InitializeComponent();
            OpenTab(InventoryTabs.RawMaterial);
        }

        private void OpenTab(int tabIndex)
        {
            switch (tabIndex)
            {
                case InventoryTabs.RawMaterial:
                    if (rawMaterial == null)
                    {
                        rawMaterial = new FrmRowMaterialDetail();
                        Helpers.FormHelper.OpenForm(tabRawMaterial, rawMaterial);
                    }
                    break;
                case InventoryTabs.BottleFormula:
                    if (boxwiseQuantity == null)
                    {
                        boxwiseQuantity = new FrmBoxwiseBottleQuantityDetail();
                        Helpers.FormHelper.OpenForm(tabBottelFormula, boxwiseQuantity);
                    }
                    break;
                case InventoryTabs.ProductManufacture:
                    if (productionManage == null)
                    {
                        productionManage = new FrmProductionManage();
                        Helpers.FormHelper.OpenForm(tabProductManufacture, productionManage);
                    }
                    break;
            }
        }

        private void tabInventoryContainer_Click(object sender, EventArgs e)
        {
            OpenTab(tabInventoryContainer.SelectedIndex);
        }
    }

    public static class InventoryTabs
    {
        public const int RawMaterial = 0;
        public const int BottleFormula = 1;
        public const int ProductManufacture = 2;
    }
}

        

