using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterSystem_Model;
using WaterSystem_Repository;

namespace WaterSystem_Manager.Receiver
{
   public class DashboardReciever
    {
        DeshboardRepository _repo = null;
        public DashboardReciever()
        {
            _repo = new DeshboardRepository();
        }

        public IEnumerable<ExpensesReportModel> GetExpensesReport()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("@flag", DashboardReportConstatnts.Expenses);
            return ModelConverter.CreateListFromTable<ExpensesReportModel>(_repo.Retrieve(parameters).Tables[0]);
        }

        public IEnumerable<SalesMonthReportModel> GetSalesMonthWiseReport()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("@flag", DashboardReportConstatnts.MonthWiseSales);
            return ModelConverter.CreateListFromTable<SalesMonthReportModel>(_repo.Retrieve(parameters).Tables[0]);
        }

        public IEnumerable<SalesRecoveryReportModel> GetSalesRecoveryReport()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("@flag", DashboardReportConstatnts.Recovery);
            return ModelConverter.CreateListFromTable<SalesRecoveryReportModel>(_repo.Retrieve(parameters).Tables[0]);
        }

        public IEnumerable<ApprovalReportModel> GetSalesApprovalReport()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("@flag", DashboardReportConstatnts.PendingApprovals);
            return ModelConverter.CreateListFromTable<ApprovalReportModel>(_repo.Retrieve(parameters).Tables[0]);
        }
    }

    public static class DashboardReportConstatnts
    {
        public static string Expenses = "Expenses";
        public static string MonthWiseSales = "MonthWiseSales";
        public static string Recovery = "SalesRecovery";
        public static string PendingApprovals = "PendingApprovals";
    }
}
