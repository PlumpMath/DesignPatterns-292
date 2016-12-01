using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public class Soup : Food
    {
        public Soup(string name)
        {
            this.name = name;
        }

        public override string fork()
        {
            return null;
        }

        public override string hands()
        {
            return null;
        }

        public override string knife()
        {
            return null;
        }

        public override string spoon()
        {
            return " a spoon to scoop up the " + name + " soup";
        }
    }
}
