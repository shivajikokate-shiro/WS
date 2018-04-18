using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterSystem_Model;
using WaterSystem_Repository;


namespace WaterSystem_Manager.Receiver
{
    public class BoxQuantityPerBoxReciever
    {
        BoxwiseBottleRepository boxRepo = null;
        public BoxQuantityPerBoxReciever()
        {
            boxRepo = new BoxwiseBottleRepository();
        }

        public IEnumerable<BottleQuantityPerBoxTypeModel> GetList()
        {
            return ModelConverter.CreateListFromTable<BottleQuantityPerBoxTypeModel>(boxRepo.Retrieve().Tables[0]);
        }

        public IEnumerable<RowMaterialModel> GetBottleType()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("@flag", "S");
            return ModelConverter.CreateListFromTable<RowMaterialModel>(boxRepo.Retrieve(parameters).Tables[0]);
        }

        public IEnumerable<RowMaterialModel> GetBoxType()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("@flag", "S");
            return ModelConverter.CreateListFromTable<RowMaterialModel>(boxRepo.Retrieve(parameters).Tables[1]);
        }

        public void Add(BottleQuantityPerBoxTypeModel model)
        {
            model.Flag = Constants.DbConstants.Add;
            DatabaseOperation(model);
        }

        public void Update(BottleQuantityPerBoxTypeModel model)
        {
            model.Flag = Constants.DbConstants.Update;
            DatabaseOperation(model);
        }

        public void Delete(BottleQuantityPerBoxTypeModel model)
        {
            model.Flag = Constants.DbConstants.Delete;
            DatabaseOperation(model);
        }

        public void DatabaseOperation(BottleQuantityPerBoxTypeModel model)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();
            parameters.Add("@ID", model.ID.ToString());
            parameters.Add("@Box_ID", model.Box_ID.ToString());
            parameters.Add("@Bottle_ID", model.Bottle_ID.ToString());
            parameters.Add("@Per_Box_Qty", model.Per_Box_Qty.ToString());
            parameters.Add("@IsActive", "Y");
            parameters.Add("@flag", model.Flag.ToString());
            boxRepo.Save(parameters);
        }
    }
}
