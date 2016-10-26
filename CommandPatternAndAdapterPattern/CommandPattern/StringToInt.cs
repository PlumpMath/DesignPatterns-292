using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class StringToInt : IStringToInt
    {
        public int getInt(string text)
        {
            return Int32.Parse(text);
        }
    }
}
