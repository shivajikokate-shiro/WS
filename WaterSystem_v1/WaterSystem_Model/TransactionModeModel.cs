using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSystem_Model
{
   public class TransactionModeModel
    {
        public decimal TransactionModeId { get; set; }
        public string TransactionMode { get; set; }
        public bool IsActive { get; set; }
        public bool? FromBank { get; set; }
        public bool? ToBank { get; set; }
    }
}
