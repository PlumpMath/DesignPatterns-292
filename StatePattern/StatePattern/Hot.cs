using System;

namespace StatePattern
{
    internal class Hot : State
    {
        public string getDrinkMessage()
        {
            return "This drink is still really hot and burns a little when you drink it, but it still tastes pretty good.";
        }

        public State getNextState()
        {
            return new Warm();
        }

        public string getTemp()
        {
            return "Rather Hot";
        }
    }
}