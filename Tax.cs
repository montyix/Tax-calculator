using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro2
{
    public class Tax
    {
        public static decimal CalcTax(Employee e)
        {
            if (e.GetType().ToString() == "Pro2.SalesEmployee")
                return ((SalesEmployee)e).CalculatePay() * 8 / 100;
            else
                return e.CalculatePay() * 8 / 100;
        }
    }
}
