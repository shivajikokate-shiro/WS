using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterSystem_Model;
using WaterSystem_Repository;
using WaterSystem_Common;

namespace WaterSystem_Manager.Receiver
{
    public class PurchaseInvoiceReciever
    {
        PurchaseInvoiceRepository _purchaseRepo = null;
        public PurchaseInvoiceReciever()
        {
            _purchaseRepo = new PurchaseInvoiceRepository();
        }

        public IEnumerable<SupplierModel> GetSuppliers()
        {
            return ModelConverter.CreateListFromTable<SupplierModel>(_purchaseRepo.Retrieve().Tables[0]);
        }

        public IEnumerable<RowMaterialModel> GetItems()
        {
            return ModelConverter.CreateListFromTable<RowMaterialModel>(_purchaseRepo.Retrieve().Tables[2]);
        }

        public IEnumerable<TransportationModel> GetTransportation()
        {
            return ModelConverter.CreateListFromTable<TransportationModel>(_purchaseRepo.Retrieve().Tables[5]);
        }

        public int SavePurchaseInvoice(PurchaseModel model)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("@Invoice_Number", model.InvoiceNumber.ToString());
            parameters.Add("@Tran_Date", model.Trans_Date.ToDateString());
            parameters.Add("@Customer_Id", model.SupplierID.ToString());
            parameters.Add("@Sub_Total", model.SubTotal.ToString());
            parameters.Add("@Tax", model.Tax.ToString());
            parameters.Add("@Grand_Total", model.GrandTotal.ToString());
            parameters.Add("@ExciseDuety", 0.ToString());
            parameters.Add("@Paid", model.Paid.ToString());
            parameters.Add("@On_Credit", model.OnCredit.ToString());
            parameters.Add("@flag", PurchaseDbConstants.PurchaseInvoice);
            var result = _purchaseRepo.Save(parameters);
            return Convert.ToInt32(result.Tables[0].Rows[0][0]);
        }

        public void SavePurchaseItemDetails(PurchaseItemModel model)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("@Purchase_Id", model.PurchaseID.ToString());
            parameters.Add("@Invoice_Number", model.InvoiceNumber.ToString());
            parameters.Add("@SubItemId", model.SubItemID.ToString());
            parameters.Add("@Quantity", model.Quantity.ToString());
            parameters.Add("@Prise", model.Price.ToString());
            parameters.Add("@Total", model.Total.ToString());
            parameters.Add("@flag", PurchaseDbConstants.PurchaseItemDetails);
            _purchaseRepo.Save(parameters);
        }
    }

    public static class PurchaseDbConstants
    {
        public const string PurchaseInvoice = "AI";
        public const string PurchaseItemDetails = "AP";
    }
}
