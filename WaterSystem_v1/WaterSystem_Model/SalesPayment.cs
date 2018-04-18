using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSystem_Model
{
   public class SalesPayment
    {
        public string TransactionDetailNo { get; set; }
        public string Description { get; set; }
        public DateTime TransactionDate { get; set; }
        public int PaymentModeID { get; set; }
        public int BillingID { get; set; }
        public string ToAcc { get; set; }
        public string InvoieType { get; set; }
    }
}
