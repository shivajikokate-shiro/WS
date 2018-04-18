using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSystem_Model
{
    public class TransportationModel
    {
        public decimal Transportation_Id { get; set; }
        public string Transportation_Name { get; set; }
        public string Transportation_Address { get; set; }
        public decimal Transportation_Number { get; set; }
        public bool IsActive { get; set; }
        public string Update { get { return "Update"; } }
        public string Delete { get { return "Delete"; } }
        public string Flag { get; set; }
    }
}
