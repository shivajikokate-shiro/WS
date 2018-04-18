using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaterSystem_Model;
using WaterSystem_Repository;

namespace WaterSystem_Manager.Receiver
{
    public class ItemReciever
    {
        ItemRepository _itemRepo = null;
        public ItemReciever()
        {
            _itemRepo = new ItemRepository();
        }

        public IEnumerable<ItemModel> GetList()
        {
           return ModelConverter.CreateListFromTable<ItemModel>(_itemRepo.Retrieve().Tables[0]);
        }

        public IEnumerable<MeasurementModel> GetMeasurement()
        {
            return ModelConverter.CreateListFromTable<MeasurementModel>(_itemRepo.Retrieve().Tables[1]);
        }

        public void Add(ItemModel model)
        {
            model.Flag = Constants.DbConstants.Add;
            DatabaseOperation(model);
        }

        public void Update(ItemModel model)
        {
            model.Flag = Constants.DbConstants.Update;
            DatabaseOperation(model);
        }

        public void Delete(ItemModel model)
        {
            model.Flag = Constants.DbConstants.Delete;
            DatabaseOperation(model);
        }

        public void DatabaseOperation(ItemModel model)
        {
            if (model != null)
            {
                Dictionary<string, string> parameters = new Dictionary<string, string>();
                parameters.Add("@ItemId", model.ItemId.ToString());
                parameters.Add("@ItemName", model.ItemName);
                parameters.Add("@MeasurmentId", model.MeasurmentId.ToString());
                parameters.Add("@IsActive", model.IsActive.ToString());
                parameters.Add("@flag", model.Flag.ToString());
                parameters.Add("@PFlag", model.PFlag.ToString());
                _itemRepo.Save(parameters);
            }
            else
            {
                throw new NullReferenceException();
            }
        }
    }
}
