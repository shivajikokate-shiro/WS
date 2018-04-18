using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSystem_Repository
{
   public class VehicleRepository: BaseRepository
    {
        public const string spName = "sp_Vehical_Details";
        public VehicleRepository() : base(new DatabaseCommunication(), spName)
        {

        }
    }
}
