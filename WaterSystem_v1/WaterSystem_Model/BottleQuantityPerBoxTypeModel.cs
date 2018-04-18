using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSystem_Model
{
    public class BottleQuantityPerBoxTypeModel
    {
        public decimal ID { get; set; }
        public decimal Per_Box_Qty { get; set; }
        public string BottleType { get; set; }
        public decimal Bottle_ID { get; set; }
        public string BoxType { get; set; }
        public decimal Box_ID { get; set; }
        public string Is_Active { get; set; }
        public string Update { get { return "Update"; } }
        public string Delete { get { return "Delete"; } }
        public string Flag { get; set; }
    }
}
