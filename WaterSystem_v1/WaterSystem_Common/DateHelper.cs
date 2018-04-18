using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSystem_Common
{
    public static class DateHelper
    {
        public static string ToDateString(this DateTime date)
        {
            return date.ToString(DateFormat);
        }

        public static DateTime ToDate(this string dateString)
        {
            DateTime date;
            if (DateTime.TryParse(dateString, out date))
            {
                date = DateTime.Parse(dateString);
            }
            return date;
        }

        public static string DateFormat = "MM/dd/yyyy";
    }
}
