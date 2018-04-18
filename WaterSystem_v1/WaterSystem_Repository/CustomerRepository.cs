using System.Collections.Generic;
using System.Data;

namespace WaterSystem_Repository
{
    public class CustomerRepository: BaseRepository
    {
        DatabaseCommunication communication = null;
        public const string spName = "SP_CustomerMaster";
        public CustomerRepository():base(new DatabaseCommunication(),spName)
        {
            communication = new DatabaseCommunication();
        }
    }
}
