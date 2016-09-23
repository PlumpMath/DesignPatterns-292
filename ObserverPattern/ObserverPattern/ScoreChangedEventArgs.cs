using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class ScoreChangedEventArgs : EventArgs
    {
        private int score;
        private string name;

        public ScoreChangedEventArgs(string teamName, int score)
        {
            this.name = teamName;
            this.score = score;
            
        }

        public string getScore()
        {
            if (score == 6)
                return "a touchdown";
            else if (score == 3)
                return "a field goal";
            else if (score == 2)
                return "a safety or a two point conversion";
            else if (score == 1)
                return "an extra point";
            else
                return "error with code";
        }

        public string getName()
        {
            return name;
        }
    }
}
