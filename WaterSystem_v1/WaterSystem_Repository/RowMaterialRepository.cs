using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSystem_Repository
{
    public class RawMaterialRepository : BaseRepository
    {
        public const string spName = "SP_RowMaterialMaster";
        public RawMaterialRepository() : base(new DatabaseCommunication(), spName)
        {

        }
    }
}
