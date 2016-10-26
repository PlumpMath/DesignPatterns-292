using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Multiply : Operation
    {
        public double doOperation(double a, double b)
        {
            return a * b;
        }

        public override string ToString()
        {
            return "Times";
        }
    }
}
