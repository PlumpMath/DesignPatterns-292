using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class Hero
    {
        protected string name;
        protected string level;
        public string getName()
        {
            return name;
        }
        public abstract string getPowers();
    }
}
