using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSystem_Model
{
    public class InvoiceApproveModel
    {
        public decimal Paid { get; set; }
        public DateTime Date { get; set; }
        public int ID { get; set; }
        public string TransactionNo { get; set; }
        public int UserID { get; set; }
        public string Type { get; set; }
        public string Flag { get; set; }
        public string SubExpensesID { get; set; }
    }
}
