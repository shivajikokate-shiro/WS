using System.Collections.Generic;
using WaterSystem_Model;
using WaterSystem_Repository;


namespace WaterSystem_Manager.Receiver
{
    public class SubExpencesReciever
    {
        SubExpencesRepository _subExpencesRepo = null;
        public SubExpencesReciever()
        {
            _subExpencesRepo = new SubExpencesRepository();
        }
        public IEnumerable<SubExpencesModel> GetList()
        {
            return ModelConverter.CreateListFromTable<SubExpencesModel>(_subExpencesRepo.Retrieve().Tables[0]);
        }

        public void Add(SubExpencesModel model)
        {
            model.Flag = Constants.DbConstants.Add;
            DatabaseOperation(model);
        }

        public void Update(SubExpencesModel model)
        {
            model.Flag = Constants.DbConstants.Update;
            DatabaseOperation(model);
        }

        public void Delete(SubExpencesModel model)
        {
            model.Flag = Constants.DbConstants.Delete;
            DatabaseOperation(model);
        }

        public void DatabaseOperation(SubExpencesModel model)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("@Expences_ID", model.Expences_ID.ToString());
            parameters.Add("@SubExpences_ID", model.SubExpences_ID.ToString());
            parameters.Add("@SubExpences_Name", model.SubExpences_Name.ToString());
            parameters.Add("@IsActive", model.IsActive.ToString());
            parameters.Add("@SysFlag", model.SysFlag.ToString());
            parameters.Add("@flag", model.Flag.ToString());
            _subExpencesRepo.Save(parameters);
        }
    }
}
