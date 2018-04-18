using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSystem_Model
{
   public class BillingItemModel
    {
        public int SrNo { get; set; }
        public string ProductName { get; set; }
        public string ProductValue { get; set; }
        public int Quantity { get; set; }
        public double Rate { get; set; }
        public double Total { get; set; }
    }
}