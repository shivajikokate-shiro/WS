using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSystem_Model
{
    public class VehicleModel
    {
        public decimal ID { get; set; }
        public string Vehical_No { get; set; }
        public string Employee_Name { get; set; }
        public string Employee_Address { get; set; }
        public string Contact { get; set; }
        public bool Is_Active { get; set; }
        public decimal Transportation_ID { get; set; }
        public string Description { get; set; }
        public string Update { get { return "Update"; } }
        public string Delete { get { return "Delete"; } }
        public string Flag { get; set; }
    }
}
