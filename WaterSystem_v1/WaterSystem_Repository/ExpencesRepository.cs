using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSystem_Repository
{
    public class ExpencesRepository: BaseRepository
    {
        public const string spName = "SP_ExpencesMaster";
        public ExpencesRepository() : base(new DatabaseCommunication(), spName)
        {

        }
    }
}
