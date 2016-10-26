using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class Operate
    {
        Operation operation;

        public double calculate(double a, double b)
        {
            return operation.doOperation(a, b);
        }

        public void setOperation(Operation op)
        {
            this.operation = op;
        }
    }
}
