using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class Context
    {
        State state;
        public Context()
        {
            state = new Burning();
        }

        public string getTemp()
        {
            return state.getTemp();
        }

        public string getMessage()
        {
            return state.getDrinkMessage();
        }

        public void nextState()
        {
            state = state.getNextState();
        }

        public void drankCup()
        {
            state = new Empty();
        }
    }
}
