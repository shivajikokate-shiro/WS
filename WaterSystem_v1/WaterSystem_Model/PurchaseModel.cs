using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSystem_Model
{
    public class PurchaseModel
    {
        public decimal InvoiceNumber { get; set; }
        public DateTime Trans_Date { get; set; }
        public int SupplierID { get; set; }
        public double SubTotal { get; set; }
        public double Tax { get; set; }
        public double GrandTotal { get; set; }
        public double ExiseDuty { get; set; }
        public double Paid { get; set; }
        public double OnCredit { get; set; }
    }
}
