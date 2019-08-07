using System;
using System.Collections.Generic;
using System.Text;

namespace Roshambo
{
    public class Scoreboard
    {
        public int uScore { get; set; }
        public int oScore { get; set; }
        public int draws { get; set; }
        public string uName { get; set; }
        public string oName { get; set; }

        public Scoreboard(int uScore, int oScore, int draws, string uName, string oName)
        {
            this.uScore = uScore;
            this.oScore = oScore;
            this.draws = draws;
            this.uName = uName;
            this.oName = oName;
        }

        public override string ToString()
        {
            Console.WriteLine($"{uName}: " + uScore);
            Console.WriteLine($"{oName}: " + oScore);
            Console.WriteLine("draws: " + draws);
            return "";
        }
    }
}
