using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSystem_Repository
{
    public class DeshboardRepository: BaseRepository
    {
        public const string spName = "DashboardDetails";
        public DeshboardRepository() : base(new DatabaseCommunication(), spName)
        {
        }
    }
}
