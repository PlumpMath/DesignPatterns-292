using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class HeroDecorator : Hero
    {
        public Hero hero;

        public HeroDecorator(Hero hero)
        {
            this.hero = hero;
            this.name = hero.getName();
        }

        public override string getPowers()
        {
            return hero.getPowers();
        }
    }
}
