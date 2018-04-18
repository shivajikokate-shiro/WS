using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSystem_Repository
{
    public class BaseRepository
    {
        DatabaseCommunication _communication = null;
        public readonly string _spName = null;
        public BaseRepository(DatabaseCommunication communication, string spName)
        {
            _communication = communication;
            _spName = spName;
        }

        public DataSet Retrieve()
        {
            return _communication.blFill(_spName);
        }

        public DataSet Retrieve(Dictionary<string, string> parameters)
        {
            return _communication.blFill_Para_Name(parameters, _spName);
        }

        public DataSet Save(Dictionary<string, string> parameters)
        {
            return _communication.blFill_Para_Name(parameters, _spName);
        }
    }
}
