using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class FastHero : HeroDecorator
    {
        public FastHero(Hero hero, string level) : base(hero)
        {
            this.level = level;
        }

        public override string getPowers()
        {
            return base.getPowers() + ", can run at " + level;
        }
    }
}
