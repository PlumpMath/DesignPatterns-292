using System;

namespace StatePattern
{
    internal class Cold : State
    {
        public string getDrinkMessage()
        {
            return "The drink is now cold, it does not taste very good";
        }

        public State getNextState()
        {
            return new Cold();
        }

        public string getTemp()
        {
            return "Cold";
        }
    }
}