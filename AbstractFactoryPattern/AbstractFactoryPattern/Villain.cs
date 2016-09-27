using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Villain : ComicCharacter
    {
        private string name;
        private string powers;
        private string motive;
        private string rival;

        public Villain(string name, string powers, string motive, string rival)
        {
            this.name = name;
            this.powers = powers;
            this.motive = motive;
            this.rival = rival;
        }

        public string getName()
        {
            return name;
        }

        public string getPowers()
        {
            return powers;
        }

        public string getMotive()
        {
            return motive;
        }

        public string getRival()
        {
            return rival;
        }

        public string getSummary()
        {
            return "* " + getName() + " is a villain of " + getRival() + " who can " + getPowers() + ". The reason they do this is because " + getMotive() + ".";
        }
    }
}
