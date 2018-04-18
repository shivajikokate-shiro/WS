using System.Collections.Generic;
using WaterSystem_Model;
using WaterSystem_Repository;


namespace WaterSystem_Manager.Receiver
{
    public class RowMaterialReciever
    {
        RawMaterialRepository repo = null; 
        public RowMaterialReciever()
        {
            repo = new RawMaterialRepository();
        }

        public IEnumerable<RowMaterialModel> GetList()
        {
            return ModelConverter.CreateListFromTable<RowMaterialModel>(repo.Retrieve().Tables[0]);
        }

        public IEnumerable<RowHedarModel> GetHedars()
        {
            return ModelConverter.CreateListFromTable<RowHedarModel>(repo.Retrieve().Tables[1]);
        }

        public IEnumerable<MeasurementModel> GetMeasurements()
        {
            return ModelConverter.CreateListFromTable<MeasurementModel>(repo.Retrieve().Tables[2]);
        }

        public void Add(RowMaterialModel model)
        {
            model.Flag = Constants.DbConstants.Add;
            DatabaseOperation(model);
        }

        public void Update(RowMaterialModel model)
        {
            model.Flag = Constants.DbConstants.Update;
            DatabaseOperation(model);
        }

        public void Delete(RowMaterialModel model)
        {
            model.Flag = Constants.DbConstants.Delete;
            DatabaseOperation(model);
        }

        public void DatabaseOperation(RowMaterialModel model)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("@RowMaterialId", model.RowMaterialId.ToString());
            parameters.Add("@RowMaterialName", model.RowMaterialName.ToString());
            parameters.Add("@RowMaterialFlag", "");
            parameters.Add("@MeasurmentId", model.MeasurmentId.ToString());
            parameters.Add("@RowHedarId", model.RowHedarId.ToString());
            parameters.Add("@IsActive", model.IsActive.ToString());
            parameters.Add("@flag", model.Flag.ToString());
            repo.Save(parameters);
        }
    }
}
