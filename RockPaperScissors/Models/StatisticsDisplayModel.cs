using RockPaperScissors.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockPaperScissors.Models
{
    public class StatisticsViewModel
    {
        public string Winner { get; set; }
        public int PlayerScore { get; set; }
        public int ComputerScore { get; set; }
        public int Turns { get; set; }
        public Move MostUsedMove { get; set; }
    }
}
