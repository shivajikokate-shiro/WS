using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSystem_Model
{
    public class EmployeeModel: IModel
    {
        public decimal Emp_Id { get; set; }
        public string Emp_Name { get; set; }
        public string Emp_Add { get; set; }
        public decimal Emp_Mob { get; set; }
        public DateTime Emp_BirthDate { get; set; }
        public DateTime Emp_JoinDate { get; set; }
        public double Emp_Sal { get; set; }
        public bool IsCheck { get; set; }
        public string Update { get { return "Update"; } }
        public string Delete { get { return "Delete"; } }
        public string Flag { get; set; }
    }
}
