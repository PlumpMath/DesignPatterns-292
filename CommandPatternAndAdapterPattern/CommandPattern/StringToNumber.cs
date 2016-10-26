using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public interface StringToNumber
    {
        double getNumber(string text, bool hasPeriod);
    }
}