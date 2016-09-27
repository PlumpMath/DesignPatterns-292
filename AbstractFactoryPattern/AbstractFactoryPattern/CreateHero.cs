using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class CreateHero : CreateComicCharacter
    {
        private string name;
        private string powers;
        private string city;
        private string origin;

        public CreateHero(string name, string powers, string city, string origin)
        {
            this.name = name;
            this.powers = powers;
            this.city = city;
            this.origin = origin;
        }

        public ComicCharacter createCharacter()
        {
            return new Hero(name, powers, city, origin);
        }
    }
}
