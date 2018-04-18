using System;
using System.Collections.Generic;
using WaterSystem_Model;
using WaterSystem_Repository;

namespace WaterSystem_Manager.Receiver
{
    public class CustomerReciever
    {
            public CustomerRepository _customerRepo = null;
        public CustomerReciever()
        {
            this._customerRepo = new CustomerRepository();
        }

        public IEnumerable<CustomerModel> GetList()
        {
            return ModelConverter.CreateListFromTable<CustomerModel>(_customerRepo.Retrieve().Tables[0]);
        }
        
        public string GetCustomerNumber()
        {
            return _customerRepo.Retrieve().Tables[1].Rows[0][0].ToString();
        }

        public void Add(CustomerModel model)
        {
            model.Flag = Constants.DbConstants.Add;
            DatabaseOperation(model);
        }

        public void Update(CustomerModel model)
        {
            model.Flag = Constants.DbConstants.Update;
            DatabaseOperation(model);
        }

        public void Delete(CustomerModel model)
        {
            model.Flag = Constants.DbConstants.Delete;
            DatabaseOperation(model);
        }

        public void DatabaseOperation(CustomerModel model)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("@Customer_Id", model.Customer_Id.ToString());
            parameters.Add("@Customer_No", model.Customer_No.ToString());
            parameters.Add("@Comp_Name", model.Comp_Name.ToString());
            parameters.Add("@Address", model.Address.ToString());
            parameters.Add("@Cust_Mobileno", model.Cust_Mobileno.ToString());
            parameters.Add("@Vat_No", model.VatNo!=null? model.VatNo.ToString():"-");
            parameters.Add("@Tin_No", model.TinNo!=null? model.TinNo.ToString(): "-");
            parameters.Add("@IsActive", model.IsActive.ToString());
            parameters.Add("@flag", model.Flag.ToString());
            _customerRepo.Save(parameters);
        }
    }
}
