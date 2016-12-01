using System;

namespace StatePattern
{
    internal class Warm : State
    {
        public string getDrinkMessage()
        {
            return "This drink is nice and warm, it is the perfect temperature to enjoy.";
        }

        public State getNextState()
        {
            return new Cold();
        }

        public string getTemp()
        {
            return "Warm";
        }
    }
}