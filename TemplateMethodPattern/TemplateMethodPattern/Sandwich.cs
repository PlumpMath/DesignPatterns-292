using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public class Sandwich : Food
    {
        public Sandwich(string name)
        {
            this.name = name;
        }

        public override string fork()
        {
            return null;
        }

        public override string hands()
        {
            return " your hands to bring the " + name + " sandwich closer to your mouth";
        }

        public override string knife()
        {
            return " a knife to cut the " + name + " sandwich in half so it is easier to eat, and";
        }

        public override string spoon()
        {
            return null;
        }
    }
}
