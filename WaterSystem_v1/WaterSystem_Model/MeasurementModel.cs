using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSystem_Model
{
    public class MeasurementModel: IModel
    {
        public decimal MeasurmentId { get; set; }
        public string MeasurmentName { get; set; }
        public bool IsActive { get; set; }

        public string Update { get { return "Update"; } }

        public string Delete { get { return "Delete"; } }
        
        public string Flag { get; set; }
    }
}
