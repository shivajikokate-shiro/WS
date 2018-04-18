using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSystem_Repository
{
    public class SubExpencesRepository: BaseRepository
    {
        public const string spName = "SP_SubExpencesMaster";
        public SubExpencesRepository() : base(new DatabaseCommunication(), spName)
        {

        }
    }
}
