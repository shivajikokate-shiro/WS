using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSystem_Repository
{
   public class BoxwiseBottleRepository: BaseRepository
    {
        public const string spName = "sp_Tbl_BottleQty_Per_Box_Type";
        public BoxwiseBottleRepository() : base(new DatabaseCommunication(), spName)
        {

        }
    }
}
