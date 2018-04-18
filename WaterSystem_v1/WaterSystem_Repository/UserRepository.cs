using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSystem_Repository
{
   public class UserRepository: BaseRepository
    {
        public const string spName = "SP_UserMaster";
        public UserRepository() : base(new DatabaseCommunication(), spName)
        {

        }
    }
}
