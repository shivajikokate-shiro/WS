using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSystem_Model
{
    public class InvoiceApproveDetailsModel
    {
        public decimal Invoice_Number { get; set; }
        public decimal Sales_Id { get; set; }
        public decimal Purchase_Id { get; set; }
        public int SubExpences_ID { get; set; }
        public string Tran_Date { get; set; }
        public decimal Tran_Expences_ID { get; set; }
        public string SubExpences_Name { get; set; }
        public string Comp_Name { get; set; }
        public double Grand_Total { get; set; }
        public double Paid { get; set; }
        public string Type { get; set; }
    }
}
