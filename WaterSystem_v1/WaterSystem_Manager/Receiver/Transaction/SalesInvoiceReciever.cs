using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterSystem_Repository;
using WaterSystem_Model;
using System.Globalization;
using WaterSystem_Common;

namespace WaterSystem_Manager.Receiver
{
    public class SalesInvoiceReciever
    {
        SalesInvoiceRepository _preInitRepo = null;
        SalesInvoiceRepository _repo = null;
        public SalesInvoiceReciever()
        {
            _preInitRepo = new SalesInvoiceRepository(true);
            _repo = new SalesInvoiceRepository(false);
        }

        public IEnumerable<CustomerModel> GetCustomers()
        {
            return ModelConverter.CreateListFromTable<CustomerModel>(_repo.Retrieve().Tables[0]);
        }

        public IEnumerable<ItemModel> GetItems()
        {
            return ModelConverter.CreateListFromTable<ItemModel>(_repo.Retrieve().Tables[3]);
        }

        public Dictionary<string,string> SaveSales(SalesModel model)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("@Customer_Id", model.CustomerID.ToString());
            parameters.Add("@Amount", model.Amount.ToString());
            parameters.Add("@Carton", model.Carton.ToString());
            parameters.Add("@Discount", model.Discount.ToString());
            parameters.Add("@Grand_Total", model.GrandTotal.ToString());
            parameters.Add("@Vat", model.GST.ToString());
            parameters.Add("@On_Credit", model.OnCredit.ToString());
            parameters.Add("@Paid", model.Paid.ToString());
            parameters.Add("@Tras_Date", model.TransactionDate.ToDateString());
            parameters.Add("@Transportation_Id", model.TransportationID.ToString());
            parameters.Add("@flag", SalesDbConstants.SalesInvoice);
            var salesInfo = _repo.Save(parameters);

            Dictionary<string, string> salesInfoList = new Dictionary<string, string>();
            salesInfoList.Add("SalesID", salesInfo.Tables[0].Rows[0][0].ToString());
            salesInfoList.Add("InvoiceNumber", salesInfo.Tables[0].Rows[0][1].ToString());
            return salesInfoList;
        }

        public void SaveSalesDetails(SalesItemDetailsModel model)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("@Sales_Id", model.SalesID.ToString());
            parameters.Add("@Invoice_Number", model.InvoiceNumber.ToString());
            parameters.Add("@SubItemId", model.SubItemID.ToString());
            parameters.Add("@Quantity", model.Quantity.ToString());
            parameters.Add("@Rate", model.Rate.ToString());
            parameters.Add("@Total", model.Total.ToString());
            parameters.Add("@flag", SalesDbConstants.SalesItemDetails);
            _repo.Save(parameters);
        }

        public void SavePaymentDetails(SalesPayment model)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("@Number", model.TransactionDetailNo.ToString());
            parameters.Add("@Details", model.Description.ToString());
            parameters.Add("@Tras_Date", model.TransactionDate.ToDateString());
            parameters.Add("@Pay_Mode_Id", model.PaymentModeID.ToString());
            parameters.Add("@Billing_ID", model.BillingID.ToString());
            parameters.Add("@Invoice_Type", model.InvoieType.ToString());
            parameters.Add("@To_Acc", model.ToAcc.ToString());
            parameters.Add("@flag", SalesDbConstants.SalesPayment);
            _repo.Save(parameters);
        }

        public void SaveTransportDetails(SalesTransportModel model)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("@TEmployee_Name", model.TEmployeeName.ToString());
            parameters.Add("@TVehicale_Number", model.TVehicleNumber.ToString());
            parameters.Add("@TEmployee_Number", model.TEmployeeMobNumber.ToString());
            parameters.Add("@Transportation_Id", model.TransportationID.ToString());
            parameters.Add("@Sales_Id", model.SalesID.ToString());
            parameters.Add("@flag", SalesDbConstants.SalesTransport);
            _repo.Save(parameters);
        }

        public IEnumerable<PaymentModeModel> RetrievePayModes()
        {
            return ModelConverter.CreateListFromTable<PaymentModeModel>(_preInitRepo.Retrieve().Tables[0]);
        }

        public IEnumerable<SubExpencesModel> RetrieveSubExpences()
        {
            return ModelConverter.CreateListFromTable<SubExpencesModel>(_preInitRepo.Retrieve().Tables[2]);
        }

        public IEnumerable<TransportationModel> RetrieveTransportation()
        {
            return ModelConverter.CreateListFromTable<TransportationModel>(_preInitRepo.Retrieve().Tables[1]);
        }

        public string GetInvoiceNumber()
        {
            return _repo.Retrieve().Tables[6].Rows[0][0].ToString();
        }

        public static class SalesDbConstants
        {
            public const string SalesInvoice = "AI";
            public const string SalesItemDetails = "AP";
            public const string SalesPayment = "PY";
            public const string SalesTransport = "TP";
        }
    }
}
