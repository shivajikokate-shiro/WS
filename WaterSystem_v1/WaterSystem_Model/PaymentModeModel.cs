using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSystem_Model
{
    public class PaymentModeModel
    {
        public decimal Pay_Mode_Id { get; set; }
        public string Pay_Type { get; set; }
        public bool IsCheck { get; set; }
    }
}
