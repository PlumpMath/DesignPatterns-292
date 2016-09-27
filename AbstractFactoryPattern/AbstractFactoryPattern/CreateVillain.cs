using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class CreateVillain : CreateComicCharacter
    {
        private string name;
        private string powers;
        private string motive;
        private string rival;

        public CreateVillain(string name, string powers, string motive, string rival)
        {
            this.name = name;
            this.powers = powers;
            this.motive = motive;
            this.rival = rival;
        }

        public ComicCharacter createCharacter()
        {
            return new Villain(name, powers, motive, rival);
        }
    }
}
