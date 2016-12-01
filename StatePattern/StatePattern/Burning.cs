using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class Burning : State
    {
        public string getDrinkMessage()
        {
            return "This drink is way to hot and you burn your mouth on it, not tasting the hot chocolate.";
        }

        public State getNextState()
        {
            return new Hot();
        }

        public string getTemp()
        {
            return "Extremely Hot";
        }
    }
}
