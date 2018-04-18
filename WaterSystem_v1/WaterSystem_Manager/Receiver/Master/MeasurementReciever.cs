using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterSystem_Model;
using WaterSystem_Repository;

namespace WaterSystem_Manager.Reciever
{
    public class MeasurementReciever
    {
        MeasurementRepository _measurementRepo = null;
        public MeasurementReciever()
        {
            _measurementRepo = new MeasurementRepository();
        }

        public IEnumerable<MeasurementModel> GetList()
        {
            return ModelConverter.CreateListFromTable<MeasurementModel>(_measurementRepo.Retrieve().Tables[0]);
        }
        public void Add(MeasurementModel model)
        {
            model.Flag = Constants.DbConstants.Add;
            DatabaseOperation(model);
        }

        public void Update(MeasurementModel model)
        {
            model.Flag = Constants.DbConstants.Update;
            DatabaseOperation(model);
        }

        public void Delete(MeasurementModel model)
        {
            model.Flag = Constants.DbConstants.Delete;
            DatabaseOperation(model);
        }

        private void DatabaseOperation(MeasurementModel model)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("@MeasurmentId", model.MeasurmentId.ToString());
            parameters.Add("@Measurement_Name", model.MeasurmentName);
            parameters.Add("@IsActive", model.IsActive.ToString());
            parameters.Add("@flag", model.Flag.ToString());
            _measurementRepo.Save(parameters);
        }
    }
}
