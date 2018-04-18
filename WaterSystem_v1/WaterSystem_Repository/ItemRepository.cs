using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSystem_Repository
{
   public class ItemRepository: BaseRepository
    {
        DatabaseCommunication communication = null;
        public const string spName = "SP_ItemMaster";
        public ItemRepository(): base(new DatabaseCommunication(), spName)
        {
            communication = new DatabaseCommunication();
        }
    }
}
