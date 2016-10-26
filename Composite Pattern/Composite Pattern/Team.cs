using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite_Pattern
{
    public class Team : Football
    {
        private string name;
        private string mascot;
        private int wins;
        private int losses;

        public Team(string name, string mascot, int wins, int losses)
        {
            this.name = name;
            this.mascot = mascot;
            this.wins = wins;
            this.losses = losses;
        }

        public override string getName()
        {
            return name + " " + mascot;
        }

        public override int getWins()
        {
            return wins;
        }

        public override int getLosses()
        {
            return losses;
        }

        public override int getNumChildren()
        {
            return 0;
        }

        public override Football getChild(int index)
        {
            return null;
        }
    }
}
