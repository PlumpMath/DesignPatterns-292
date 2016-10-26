using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern
{
    public class Division : Football
    {
        private string name;
        private List<Football> footballs = new List<Football>();

        public Division(string name)
        {
            this.name = name;
        }

        public override int getLosses()
        {
            int losses = 0;
            foreach(Football children in footballs)
            {
                losses += children.getLosses();
            }
            return losses;
        }

        public override string getName()
        {
            return name;
        }

        public override int getWins()
        {
            int wins = 0;
            foreach (Football children in footballs)
            {
                wins += children.getWins();
            }
            return wins;
        }

        public override int getNumChildren()
        {
            return footballs.Count;
        }

        public override Football getChild(int index)
        {
            return footballs[index];
        }

        public void add(Football football)
        {
            footballs.Add(football);
        }

        public void remove(Football football)
        {
            footballs.Remove(football);
        }
    }
}
