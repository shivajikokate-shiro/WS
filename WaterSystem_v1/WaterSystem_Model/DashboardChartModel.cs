using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSystem_Model
{
    public class ExpensesReportModel : SubExpencesModel
    {
       public double Amount { get; set; }
    }

    public class SalesRecoveryReportModel
    {
        public double TotalAmount { get; set; }
        public double PaidAmount { get; set; }
        public double RecoveryAmount { get; set; }
    }

    public class SalesMonthReportModel
    {
        public int SalesMonth { get; set; }
        public int SalesYear { get; set; }
        public double TotalSales { get; set; }
    }

    public class ApprovalReportModel
    {
        public int PendingApproval { get; set; }
        public int TotalApproval { get; set; }
    }
}
