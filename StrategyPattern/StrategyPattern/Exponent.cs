using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Exponent : Operation
    {
        public double doOperation(double a, double b)
        {
            return Math.Pow(a, b);
        }

        public override string ToString()
        {
            return "To The Power Of";
        }
    }
}
