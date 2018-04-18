using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterSystem_Model;
using WaterSystem_Repository;

namespace WaterSystem_Manager.Receiver
{
    public class RootReciever
    {
        RootRepository _rootRepo = null;
        public RootReciever()
        {
            _rootRepo = new RootRepository();
        }

        public IEnumerable<RootModel> GetList()
        {
            return ModelConverter.CreateListFromTable<RootModel>(_rootRepo.Retrieve().Tables[0]);
        }

        public IEnumerable<SourceModel> GetSources()
        {
            return ModelConverter.CreateListFromTable<SourceModel>(_rootRepo.Retrieve().Tables[1]);
        }

        public void Add(RootModel model)
        {
            model.Flag = Constants.DbConstants.Add;
            DatabaseOperation(model);
        }

        public void Update(RootModel model)
        {
            model.Flag = Constants.DbConstants.Update;
            DatabaseOperation(model);
        }

        public void Delete(RootModel model)
        {
            model.Flag = Constants.DbConstants.Delete;
            DatabaseOperation(model);
        }

        public void DatabaseOperation(RootModel model)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("@RootId", model.RootId.ToString());
            parameters.Add("@Source", model.Source.ToString());
            parameters.Add("@Destination", model.DestinationId.ToString());
            parameters.Add("@SourceId", model.Source.ToString());
            parameters.Add("@IsCheck", model.IsCheck.ToString());
            parameters.Add("@flag", model.Flag.ToString());
            _rootRepo.Save(parameters);
        }
    }
}
