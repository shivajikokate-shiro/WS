using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSystem_Model
{
    public class PaymentTransactionModel
    {
        public int PaymentModeID { get; set; }
        public int AccountID { get; set; }
        public double Balance { get; set; }
        public string TransactionNumber { get; set; }
        public string Description { get; set; }
    }
}
