using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSystem_Model
{
    public class ItemModel: IModel
    {
        public decimal ItemId { get; set; }
        public string ItemName { get; set; }
        public decimal MeasurmentId { get; set; }
        public bool IsActive { get; set; }
        public string PFlag { get; set; }
        public string Update { get { return "Update"; } }
        public string Delete { get { return "Delete"; } }
        public string Flag { get; set; }

        public string MeasurmentName { get; set; }
    }
}
