using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class NumberGetter : StringToNumber
    {
        NumberAdapter numAdapt = new NumberAdapter();
        public double getNumber(string text, bool hasPeriod)
        {
            if (hasPeriod) {
                return Double.Parse(text);
            }
            else
            {
                return numAdapt.getNumber(text, hasPeriod);
            }
        }
    }
}
