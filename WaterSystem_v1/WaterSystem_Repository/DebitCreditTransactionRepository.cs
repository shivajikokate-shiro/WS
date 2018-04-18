using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSystem_Repository
{
    public class DebitCreditTransactionRepository: BaseRepository
    {
        public const string spName = "SP_Expences_Transaction";
        public DebitCreditTransactionRepository() : base(new DatabaseCommunication(), spName)
        {

        }
    }
}
