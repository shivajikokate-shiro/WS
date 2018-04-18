using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterSystem_v1.Helpers
{
    public static class CalculationHelper
    {
        public const double _gstPercent = 18;
        public static double AmountAddingGST(double amount)
        {
            return RoundAmount(amount * (_gstPercent + 100) /100) ;
        }

        public static double AmountRemovingGST(double amount)
        {
            return RoundAmount(amount * 100 / (100 + _gstPercent));
        }


        public static double GSTAmount(double amount)
        {
            return RoundAmount(amount * (_gstPercent) / 100);
        }

        public static double CalculateGST(double amount)
        {
            return RoundAmount((amount * _gstPercent) / 100);
        }

        public static double RoundAmount(double amount)
        {
            return Math.Round(amount, 2);
        }
    }
}
