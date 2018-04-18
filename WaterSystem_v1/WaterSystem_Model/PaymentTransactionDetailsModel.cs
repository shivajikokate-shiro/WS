using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSystem_Model
{
    public class PaymentTransactionDetailsModel
    {
        public int TID { get; set; }
        public  int CustID { get; set; }
        public int FromAcc { get; set; }
        public int ToAcc { get; set; }
        public string DebitAccount { get; set; }
        public string CreditAccount { get; set; }
        public decimal DayCash { get; set;}
        public decimal PaidCash { get; set; }
        public int PayModeId { get; set; }
        public decimal OpeningBalance { get; set; }
        public decimal ClosingBalance { get; set; }
        public DateTime TransDate { get; set; }
        public string TransNumber { get; set; }
        public string Description { get; set; }
        public string TransType { get; set; }
        public string CustType { get; set; }
        public int UserID { get; set; } 
        public string Flag { get; set; }
        public string VoucherNo { get; set; }

    }
}
