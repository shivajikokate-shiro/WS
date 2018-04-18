using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterSystem_Model;
using WaterSystem_Repository;

namespace WaterSystem_Manager.Receiver
{
    public class VehicleReciever
    {
        VehicleRepository _vehicleRepo = null;
        public VehicleReciever()
        {
            _vehicleRepo = new VehicleRepository();
        }

        public IEnumerable<VehicleModel> GetList()
        {
            return ModelConverter.CreateListFromTable<VehicleModel>(_vehicleRepo.Retrieve().Tables[0]);
        }

        public IEnumerable<VehicleModel> GetVehiclesByTransport(VehicleModel model)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("@Transportation_ID", model.Transportation_ID.ToString());
            parameters.Add("@flag", "S");
            return ModelConverter.CreateListFromTable<VehicleModel>(_vehicleRepo.Retrieve(parameters).Tables[0]);
        }

        public void Add(VehicleModel model)
        {
            model.Flag = Constants.DbConstants.Add;
            DatabaseOperation(model);
        }

        public void Update(VehicleModel model)
        {
            model.Flag = Constants.DbConstants.Update;
            DatabaseOperation(model);
        }

        public void Delete(VehicleModel model)
        {
            model.Flag = Constants.DbConstants.Delete;
            DatabaseOperation(model);
        }

        public void DatabaseOperation(VehicleModel model)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("@ID", model.ID.ToString());
            parameters.Add("@Vehical_No", model.Vehical_No.ToString());
            parameters.Add("@Employee_Name", model.Employee_Name.ToString());
            parameters.Add("@Employee_Address", model.Employee_Address.ToString());
            parameters.Add("@Contact", model.Contact.ToString());
            parameters.Add("@Transportation_ID", model.Transportation_ID.ToString());
            parameters.Add("@Description", model.Description);
            parameters.Add("@IsActive", model.Is_Active.ToString());
            parameters.Add("@flag", model.Flag.ToString());
            _vehicleRepo.Save(parameters);
        }
    }
}
