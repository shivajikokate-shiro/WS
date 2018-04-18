using System.Collections.Generic;
using WaterSystem_Model;
using WaterSystem_Repository;

namespace WaterSystem_Manager.Receiver
{
   public class TransportationReciever 
    {
        TransportationRepository _transportationRepo = null;
        public TransportationReciever()
        {
            _transportationRepo = new TransportationRepository();
        }

        public IEnumerable<TransportationModel> GetList()
        {
            return ModelConverter.CreateListFromTable<TransportationModel>(_transportationRepo.Retrieve().Tables[0]);
        }

        public string GetSupplierNumber()
        {
            return _transportationRepo.Retrieve().Tables[1].Rows[0][0].ToString();
        }

        public void Add(TransportationModel model)
        {
            model.Flag = Constants.DbConstants.Add;
            DatabaseOperation(model);
        }

        public void Update(TransportationModel model)
        {
            model.Flag = Constants.DbConstants.Update;
            DatabaseOperation(model);
        }

        public void Delete(TransportationModel model)
        {
            model.Flag = Constants.DbConstants.Delete;
            DatabaseOperation(model);
        }

        public void DatabaseOperation(TransportationModel model)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("@TranspotationId", model.Transportation_Id.ToString());
            parameters.Add("@TransportationName", model.Transportation_Name.ToString());
            parameters.Add("@Transportation_Address", model.Transportation_Address.ToString());
            parameters.Add("@Transportation_Number", model.Transportation_Number.ToString());
            parameters.Add("@IsActive", model.IsActive.ToString());
            parameters.Add("@flag", model.Flag.ToString());
            _transportationRepo.Save(parameters);
        }
    }
}
