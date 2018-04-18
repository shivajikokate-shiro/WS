using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSystem_Model
{
   public class SalesModel
    {
        public int CustomerID { get; set; }
        public double Amount { get; set; }
        public double GrandTotal { get; set; }
        public double Paid { get; set; }
        public double OnCredit { get; set; }
        public double Discount { get; set; }
        public double GST { get; set; }
        public int TransportationID { get; set; }
        public DateTime TransactionDate { get; set; }
        public int Carton { get; set; }

    }
}
