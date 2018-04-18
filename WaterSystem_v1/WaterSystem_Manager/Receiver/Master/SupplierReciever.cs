using System.Collections.Generic;
using WaterSystem_Model;
using WaterSystem_Repository;


namespace WaterSystem_Manager.Receiver
{
    public class SupplierReciever
    {
        SupplierRepository _supplierRepo = null;
        public SupplierReciever()
        {
            _supplierRepo = new SupplierRepository();
        }

        public IEnumerable<SupplierModel> GetList()
        {
            return ModelConverter.CreateListFromTable<SupplierModel>(_supplierRepo.Retrieve().Tables[0]);
        }

        public string GetSupplierNumber()
        {
            return _supplierRepo.Retrieve().Tables[1].Rows[0][0].ToString();
        }

        public void Add(SupplierModel model)
        {
            model.Flag = Constants.DbConstants.Add;
            DatabaseOperation(model);
        }

        public void Update(SupplierModel model)
        {
            model.Flag = Constants.DbConstants.Update;
            DatabaseOperation(model);
        }

        public void Delete(SupplierModel model)
        {
            model.Flag = Constants.DbConstants.Delete;
            DatabaseOperation(model);
        }

        public void DatabaseOperation(SupplierModel model)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("@Supplier_Id", model.Supplier_Id.ToString());
            parameters.Add("@SupplierNo", model.SupplierNo.ToString());
            parameters.Add("@Comp_Name", model.Comp_Name.ToString());
            parameters.Add("@Address", model.Address.ToString());
            parameters.Add("@Supplier_Mobileno", model.Supplier_Mobileno.ToString());
            parameters.Add("@Vat_No", model.VatNo != null? model.VatNo.ToString():null);
            parameters.Add("@Tin_No", model.TinNo !=null? model.TinNo.ToString(): null);
            parameters.Add("@IsActive", model.IsActive.ToString());
            parameters.Add("@flag", model.Flag.ToString());
            _supplierRepo.Save(parameters);
        }
    }
}
