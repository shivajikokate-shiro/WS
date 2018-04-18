using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSystem_Repository
{
   public class SalesInvoiceRepository : BaseRepository
    {
        public const string preInitSpName = "sp_GetPreDetailsInvoice";
        public const string spName = "Sp_SalesInvoice";
        public SalesInvoiceRepository(bool preInit = false) : base(new DatabaseCommunication(), preInit ? preInitSpName : spName) { }
    }
}
