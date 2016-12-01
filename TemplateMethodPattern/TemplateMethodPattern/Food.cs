using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    public abstract class Food
    {
        protected string name;
        public string eat()
        {
            return "You eat using" + spoon() + fork() + knife() + hands() + ".";
        }

        public abstract string fork();
        public abstract string spoon();
        public abstract string knife();
        public abstract string hands();
    }
}
