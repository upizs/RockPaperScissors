using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockPaperScissors.Classes
{
    public class Player
    {
        public Move Move { get; set; }
        public bool Beats(Move computerMove)
        {
            //check if Game rules player move beats computer move
            return GameMaster.Rules[Move].Contains(computerMove);
        }
    }
}
