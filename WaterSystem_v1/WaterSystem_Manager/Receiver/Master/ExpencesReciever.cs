using System.Collections.Generic;
using WaterSystem_Model;
using WaterSystem_Repository;


namespace WaterSystem_Manager.Receiver
{
   public class ExpencesReciever
    {
        ExpencesRepository _expencesRepo = null;
        public ExpencesReciever()
        {
            _expencesRepo = new ExpencesRepository();
        }

        public IEnumerable<ExpencesModel> GetList()
        {
            return ModelConverter.CreateListFromTable<ExpencesModel>(_expencesRepo.Retrieve().Tables[0]);
        }

        public void Add(ExpencesModel model)
        {
            model.Flag = Constants.DbConstants.Add;
            DatabaseOperation(model);
        }

        public void Update(ExpencesModel model)
        {
            model.Flag = Constants.DbConstants.Update;
            DatabaseOperation(model);
        }

        public void Delete(ExpencesModel model)
        {
            model.Flag = Constants.DbConstants.Delete;
            DatabaseOperation(model);
        }

        public void DatabaseOperation(ExpencesModel model)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("@Expences_ID", model.Expences_ID.ToString());
            parameters.Add("@Option_Type", model.Option_Type.ToString());
            parameters.Add("@Expences_Name", model.Expences_Name.ToString());
            parameters.Add("@IsActive", model.IsActive.ToString());
            parameters.Add("@SysFlag", model.SysFlag == null? "True": model.SysFlag.ToString());
            parameters.Add("@flag", model.Flag.ToString());
            _expencesRepo.Save(parameters);
        }
    }
}
