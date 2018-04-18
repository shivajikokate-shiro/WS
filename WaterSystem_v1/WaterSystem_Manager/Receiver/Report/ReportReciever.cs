using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterSystem_Repository;

namespace WaterSystem_Manager.Receiver
{
    public class ReportReciever
    {
        ReportRepository _reportRepo = null;
        public ReportReciever()
        {
            _reportRepo = new ReportRepository();
        }

        public double RetriveAccountBalance(int customerID)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("@Customer_Id", customerID.ToString());
            parameters.Add("@flag", ReportConstants.OpeningBalace);
            return Convert.ToDouble(_reportRepo.Retrieve(parameters).Tables[0].Rows[0][0]);
        }

        public double RetrivePendingAmountByCustomer(int customerId, int dataType)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("@Customer_Id", customerId.ToString());
            parameters.Add("@Data_Id", dataType.ToString());
            parameters.Add("@flag", ReportConstants.CustomerBalanceAccount);
            return Convert.ToDouble(_reportRepo.Retrieve(parameters).Tables[0].Rows[0][0].ToString());
        }
    }

    public static class ReportConstants
    {
        public const string OpeningBalace = "OB";
        public const string CustomerBalanceAccount = "BA";
    }

}
