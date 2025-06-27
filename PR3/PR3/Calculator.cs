using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR3
{
    public class Calculator
    {
        public static double MultiplyValues(Dictionary<string, double> dict)
        {
            double product = 1;
            foreach (var val in dict.Values)
            {
                product *= val;
            }
            return product;
        }
    }
}
