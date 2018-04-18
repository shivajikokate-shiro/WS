using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSystem_Repository
{
    public class InvoiceApproveRepository:BaseRepository
    {
        public const string spName = "sp_Approve_Invoice";
        public InvoiceApproveRepository() : base(new DatabaseCommunication(), spName) { }
    }
}
