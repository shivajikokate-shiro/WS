using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSystem_Repository
{
   public class SupplierRepository: BaseRepository
    {
        public const string spName = "SP_SupplierMaster";
        public SupplierRepository(): base(new DatabaseCommunication(), spName)
        {

        }
    }
}
