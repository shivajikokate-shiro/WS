using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterSystem_Repository;
using WaterSystem_Model;
using WaterSystem_Common;

namespace WaterSystem_Manager.Receiver
{
    public class InvoiceApproveReciever
    {
        InvoiceApproveRepository _invoiceRepo = null;
        public InvoiceApproveReciever()
        {
            _invoiceRepo = new InvoiceApproveRepository();
        }

        public IEnumerable<InvoiceApproveDetailsModel> GetSalesApproveList()
        {
            Dictionary<string, string> parameter = new Dictionary<string, string>();
            parameter.Add("@Date", DateTime.Now.ToDateString());
            return  ModelConverter.CreateListFromTable<InvoiceApproveDetailsModel>(_invoiceRepo.Retrieve(parameter).Tables[0]);
        }

        public IEnumerable<InvoiceApproveDetailsModel> GetPurchaseApproveList()
        {
            Dictionary<string, string> parameter = new Dictionary<string, string>();
            parameter.Add("@Date", DateTime.Now.ToDateString());
            return ModelConverter.CreateListFromTable<InvoiceApproveDetailsModel>(_invoiceRepo.Retrieve(parameter).Tables[1]);
        }

        public IEnumerable<InvoiceApproveDetailsModel> GetExpensesApproveList()
        {
            Dictionary<string, string> parameter = new Dictionary<string, string>();
            parameter.Add("@Date", DateTime.Now.ToDateString());
            return ModelConverter.CreateListFromTable<InvoiceApproveDetailsModel>(_invoiceRepo.Retrieve(parameter).Tables[2]);
        }

        public void ApproveSales(InvoiceApproveDetailsModel model)
        {
            PassInvoices(ToSales(model));
        }

        public void ApprovePurchase(InvoiceApproveDetailsModel model)
        {
            PassInvoices(ToPurchase(model));
        }

        public void ApproveExpenses(InvoiceApproveDetailsModel model)
        {
            PassInvoices(ToExpenses(model));
        }

        public void PassInvoices(InvoiceApproveModel model)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("@ID", model.ID.ToString());
            parameters.Add("@Date", model.Date != null ? model.Date.ToDateString() : string.Empty);
            parameters.Add("@Paid", model.Paid.ToString());
            parameters.Add("@Type", model.Type != null ? model.Type.ToString() : string.Empty);
            parameters.Add("@Transaction_No", model.TransactionNo != null ? model.TransactionNo.ToString() : string.Empty);
            parameters.Add("@SubExpences_ID", model.SubExpensesID != null ? model.SubExpensesID.ToString() : 0.ToString());
            parameters.Add("@User_ID", model.UserID.ToString());
            parameters.Add("@Flag", model.Flag.ToString());
            _invoiceRepo.Save(parameters);
        }

        private InvoiceApproveModel ToSales(InvoiceApproveDetailsModel approveDetails)
        {
            InvoiceApproveModel invoiceApprove = null;
            if (approveDetails != null)
            {
                invoiceApprove = new InvoiceApproveModel();
                invoiceApprove.Date = approveDetails.Tran_Date.ToDate();
                invoiceApprove.Flag = "S";
                invoiceApprove.ID = Convert.ToInt32(approveDetails.Sales_Id);
                invoiceApprove.Paid = Convert.ToDecimal(approveDetails.Paid);
                invoiceApprove.TransactionNo = approveDetails.Invoice_Number.ToString();
                invoiceApprove.UserID = 1;
            }
            return invoiceApprove;
        }

        private InvoiceApproveModel ToPurchase(InvoiceApproveDetailsModel approveDetails)
        {
            InvoiceApproveModel invoiceApprove = null;
            if (approveDetails != null)
            {
                invoiceApprove = new InvoiceApproveModel();
                invoiceApprove.ID = Convert.ToInt32(approveDetails.Purchase_Id);
                invoiceApprove.Date = approveDetails.Tran_Date.ToDate();
                invoiceApprove.Paid = Convert.ToDecimal(approveDetails.Paid);
                invoiceApprove.TransactionNo = approveDetails.Invoice_Number.ToString();
                invoiceApprove.UserID = 1;
                invoiceApprove.Flag = "P";
            }
            return invoiceApprove;
        }

        private InvoiceApproveModel ToExpenses(InvoiceApproveDetailsModel approveDetails)
        {
            InvoiceApproveModel invoiceApprove = null;
            if (approveDetails != null)
            {
                invoiceApprove = new InvoiceApproveModel();
                invoiceApprove.ID = Convert.ToInt32(approveDetails.Purchase_Id);
                invoiceApprove.Date = approveDetails.Tran_Date.ToDate();
                invoiceApprove.Paid = Convert.ToDecimal(approveDetails.Paid);
                invoiceApprove.Type = approveDetails.Type;
                invoiceApprove.UserID = 1;
                invoiceApprove.Flag = "E";
            }
            return invoiceApprove;
        }
    }
}
