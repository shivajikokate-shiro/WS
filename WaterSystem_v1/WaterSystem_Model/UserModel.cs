using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSystem_Model
{
   public class UserModel
    {
        public decimal UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public decimal GroupId { get; set; }
        public string GroupName { get; set; }
        public string Update { get { return "Update"; } }
        public string Delete { get { return "Delete"; } }
        public string Flag { get; set; }
    }
}
