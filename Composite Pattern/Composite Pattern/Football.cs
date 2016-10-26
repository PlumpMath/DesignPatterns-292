using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern
{
    public abstract class Football
    {
        public abstract string getName();
        public abstract int getWins();
        public abstract int getLosses();
        public abstract int getNumChildren();
        public abstract Football getChild(int index);
        public string getRecord()
        {
            return " " + getWins() + " - " + getLosses();
        }
    }
}
