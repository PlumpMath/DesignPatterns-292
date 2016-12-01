using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public class Pasta : Food
    {
        public Pasta(string name)
        {
            this.name = name;
        }

        public override string fork()
        {
            return " a fork to bring the " + name + " to your mouth";
        }

        public override string hands()
        {
            return null;
        }

        public override string knife()
        {
            return " a knife to cut the long strands of " + name + ",";
        }

        public override string spoon()
        {
            return " a spoon to twist the " + name + " onto your fork, and";
        }
    }
}
