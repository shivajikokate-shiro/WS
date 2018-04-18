using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSystem_Repository
{
   public class RootRepository: BaseRepository
    {
        public const string spName = "SP_RootMaster";
        public RootRepository() : base(new DatabaseCommunication(), spName)
        {

        }
    }
}
