using System;

namespace RockPaperScissors.Classes
{
    public class Cumputer
    {
        public Move Move { get; set; }

        internal void MakeMove()
        {
            Random random = new Random();
            Move = (Move)random.Next(0, 4);
        }
    }
}