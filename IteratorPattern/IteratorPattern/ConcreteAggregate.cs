using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class ConcreteAggregate : Aggregate
    {
        public List<Team> elements = new List<Team>();

        public override Iterator createIterator(string iterType)
        {
            if (iterType == "West")
                return new WestIterator(this);
            else if (iterType == "East")
                return new EastIterator(this);
            else if (iterType == "Ranked")
                return new RankedIterator(this);
            else if (iterType == "Winning")
                return new WinningIterator(this);
            else return null;
        }

        public override void add(Team team)
        {
            elements.Add(team);
        }
    }
}
