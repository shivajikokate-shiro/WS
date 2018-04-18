using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSystem_Model
{
    public class SalesItemDetailsModel : BillingItemModel
    {
        public int InvoiceNumber { get; set; }
        public int SalesID { get; set; }
        public int SubItemID { get; set; }
    }
}
