using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    public class Team
    {
        private string teamName;
        private int numWins;
        private int numLosses;
        private string apRank;
        private string division;
        public Team(string name, int wins, int losses, string rank, string division)
        {
            teamName = name;
            numWins = wins;
            numLosses = losses;
            apRank = rank;
            this.division = division;
        }

        public string getName()
        {
            return teamName;
        }

        public int getWins()
        {
            return numWins;
        }

        public int getLosses()
        {
            return numLosses;
        }

        public string getRank()
        {
            return apRank;
        }

        public double getWinPercentage()
        {
            return 100 * numWins / (numWins + numLosses);
        }
        
        public string getDivision()
        {
            return division;
        }
    }
}
