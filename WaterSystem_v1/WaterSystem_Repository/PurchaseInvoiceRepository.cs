using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSystem_Repository
{
    public class PurchaseInvoiceRepository: BaseRepository
    {
        public const string spName = "Sp_PurchaseInvoice";

        public PurchaseInvoiceRepository() : base(new DatabaseCommunication(), spName) { }
    }
}
