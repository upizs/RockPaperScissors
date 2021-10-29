using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockPaperScissors.Classes
{
    //Keeps the game rules
    public static class GameMaster
    {
        public static int ScoreToWin { get; set; }
        public static Dictionary<Move, IEnumerable<Move>> Rules { get; set; }
        public static IEnumerable<Move> Moves { get; set; }
        public static void SetUpRules()
        {
            Rules = new Dictionary<Move, IEnumerable<Move>>();
            Rules.Add(Move.Rock, new List<Move> { Move.Lizard, Move.Scissors });
            Rules.Add(Move.Paper, new List<Move> { Move.Rock, Move.Spock });
            Rules.Add(Move.Scissors, new List<Move> { Move.Paper, Move.Lizard });
            Rules.Add(Move.Lizard, new List<Move> { Move.Paper, Move.Spock });
            Rules.Add(Move.Spock, new List<Move> { Move.Rock, Move.Scissors });
        }
        public static void GetMoves()
        {
            Moves = Enum.GetValues(typeof(Move)).Cast<Move>();
        }

    }
}
