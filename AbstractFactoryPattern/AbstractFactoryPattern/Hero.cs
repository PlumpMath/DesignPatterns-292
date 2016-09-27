using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class Hero : ComicCharacter
    {
        private string name;
        private string powers;
        private string city;
        private string origin;

        public Hero(string name, string powers, string city, string origin)
        {
            this.name = name;
            this.powers = powers;
            this.city = city;
            this.origin = origin;
        }

        public string getName()
        {
            return name;
        }

        public string getPowers()
        {
            return powers;
        }

        public string getCity()
        {
            return city;
        }

        public string getOrigin()
        {
            return origin;
        }

        public string getSummary()
        {
            return "* " + getName() + " is a superhero from " + getCity() + " who got " + getPowers() + " when " + getOrigin() + ".";
        }
    }
}
