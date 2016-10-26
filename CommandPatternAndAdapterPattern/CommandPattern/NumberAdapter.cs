using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class NumberAdapter : StringToNumber
    {
        IStringToInt strToInt = new StringToInt();

        public double getNumber(string text, bool hasPeriod)
        {
            if (!hasPeriod)
            {
                return strToInt.getInt(text);
            }
            else
                return 0;
        }
    }
}
