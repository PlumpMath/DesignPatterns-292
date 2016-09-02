using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public abstract class Aggregate
    {
        public List<Team> elements;
        public abstract void add(Team team);
        public abstract Iterator createIterator(string iterType);
    }
}
