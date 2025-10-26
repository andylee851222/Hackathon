using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon06
{
    internal class Count
    {
        public static decimal CalculateTax(decimal income)
        {
            decimal tax = 0;
            if (income <= 540000)
            {
                tax = income * 0.05m;
            }
            else if( income <= 1210000 && income > 540000)
            {
                tax = (income - 540000) * 0.12m + (540000 * 0.05m);
            }
            else if (income <= 2420000 && income > 1210000)
            {
                tax = ((income -1210000) * 0.20m) + (670000 * 0.12m) + (540000 * 0.05m);
            }
            else if (income <= 4530000 && income > 2420000)
            {
                tax = ((income - 2420000) * 0.30m) +  (1210000 * 0.20m) + (670000 * 0.12m) + (540000 * 0.05m);
            }
            else if (income <= 10310000 && income > 4530000)
            {
                tax = ((income - 4530000) * 0.40m) + (2110000 * 0.30m) + (1210000 * 0.20m) + (670000 * 0.12m) + (540000 * 0.05m);
            }
            else
            {
                tax = ((income - 10310000) * 0.5m) + (5780000 * 0.40m) + (2110000 * 0.30m) + (1210000 * 0.20m) + (670000 * 0.12m) + (540000 * 0.05m);
            }
            return tax;
        }

    }
}
