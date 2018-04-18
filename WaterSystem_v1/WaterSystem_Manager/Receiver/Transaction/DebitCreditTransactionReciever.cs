using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterSystem_Common;
using WaterSystem_Model;
using WaterSystem_Repository;

namespace WaterSystem_Manager.Receiver
{
   public class DebitCreditTransactionReciever
    {
        DebitCreditTransactionRepository _repo = null;
        PaymentTransactionDetailsRepository _paymentTrasactionRepo = null;
        public DebitCreditTransactionReciever()
        {
            _repo = new DebitCreditTransactionRepository();
            _paymentTrasactionRepo = new PaymentTransactionDetailsRepository();
        }

        public IEnumerable<TransactionModeModel> GetTransactionModes()
        {
            return ModelConverter.CreateListFromTable<TransactionModeModel>(_repo.Retrieve().Tables[1]);
        }

        public IEnumerable<SubExpencesModel> GetSubExpenses()
        {
            return ModelConverter.CreateListFromTable<SubExpencesModel>(_repo.Retrieve().Tables[3]);
        }

        public int GetTransactionNumber()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("@Flag", "M");
            return Convert.ToInt32(_paymentTrasactionRepo.Retrieve(parameters).Tables[0].Rows[0][0]);
        }

        public void Save(PaymentTransactionDetailsModel model)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("@T_ID", model.TID.ToString());
            parameters.Add("@Cust_ID", model.FromAcc.ToString());
            parameters.Add("@From_Acc", model.FromAcc.ToString());
            parameters.Add("@To_Acc", model.ToAcc.ToString());
            parameters.Add("@Day_Cash", model.DayCash.ToString());
            parameters.Add("@Paid_Cash", model.PaidCash.ToString());
            parameters.Add("@Pay_Mode_Id", model.PayModeId.ToString());
            parameters.Add("@Opening_Balance", model.OpeningBalance.ToString());
            parameters.Add("@Closing_Balance", model.ClosingBalance.ToString());
            parameters.Add("@Tran_Date", model.TransDate.ToDateString());
            parameters.Add("@Tran_Number", model.TransNumber.ToString());
            parameters.Add("@Description", model.Description);
            parameters.Add("@Cust_Type", !String.IsNullOrEmpty(model.CustType) ? model.CustType.ToString():string.Empty);
            parameters.Add("@User_ID", model.UserID.ToString());
            parameters.Add("@Flag","A");
            parameters.Add("@Voucher_No", !String.IsNullOrEmpty(model.VoucherNo)? model.VoucherNo.ToString(): null);
            parameters.Add("@Tran_Type", "E");
            _paymentTrasactionRepo.Save(parameters);
        }
    }
}
