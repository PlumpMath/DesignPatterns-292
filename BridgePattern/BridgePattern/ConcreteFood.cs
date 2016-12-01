using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class ConcreteFood : Food
    {
        private string name;

        public ConcreteFood(string name)
        {
            this.name = name;
        }

        public void warm(Heater heater)
        {
            heater.heat(name);
        }
    }
}
