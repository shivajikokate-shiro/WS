using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSystem_Model
{
    public class PurchaseItemModel
    {
        public int PurchaseID { get; set; }
        public int InvoiceNumber { get; set; }
        public int SubItemID { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double Total { get; set; }
    } 
}
