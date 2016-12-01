using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class Empty : State
    {
        public string getDrinkMessage()
        {
            return "The drink is empty.";
        }

        public State getNextState()
        {
            return new Empty();
        }

        public string getTemp()
        {
            return "Empty";
        }
    }
}
