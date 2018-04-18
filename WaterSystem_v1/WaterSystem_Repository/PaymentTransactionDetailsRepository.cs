using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSystem_Repository
{
   public class PaymentTransactionDetailsRepository:BaseRepository
    {
        public const string spName = "sp_Payment_Transaction_Details";
        public PaymentTransactionDetailsRepository() : base(new DatabaseCommunication(), spName)
        {

        }
    }
}
