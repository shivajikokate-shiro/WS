using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSystem_Repository
{
   public class TransportationRepository: BaseRepository
    {
        public const string spName = "SP_TransportationMaster";
        public TransportationRepository() : base(new DatabaseCommunication(), spName)
        {
        }
    }
}
