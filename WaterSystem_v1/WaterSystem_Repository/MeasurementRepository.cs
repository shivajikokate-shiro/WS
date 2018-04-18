using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSystem_Repository
{
    public class MeasurementRepository: BaseRepository
    {
        DatabaseCommunication dbCommunication = null;
        public const string spName = "SP_MeasurementMaster";

        public MeasurementRepository(): base(new DatabaseCommunication(), spName)
        {
            dbCommunication = new DatabaseCommunication();
        }
    }
}
