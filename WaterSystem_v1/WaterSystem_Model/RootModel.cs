using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSystem_Model
{
   public class RootModel
    {
        public decimal RootId { get; set; }
        public decimal Source { get; set; }
        public string SourceName { get; set; }
        public decimal DestinationId { get; set; }
        public string DestinationName { get; set; }
        public bool IsCheck { get; set; }
        public string Update { get { return "Update"; } }
        public string Delete { get { return "Delete"; } }
        public string Flag { get; set; }

    }
}
