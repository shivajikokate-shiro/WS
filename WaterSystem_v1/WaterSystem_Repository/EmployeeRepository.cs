using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSystem_Repository
{
   public class EmployeeRepository: BaseRepository
    {
        public const string spName = "SP_EmployeeMaster";
        public EmployeeRepository() : base(new DatabaseCommunication(), spName)
        {

        }
    }
}
