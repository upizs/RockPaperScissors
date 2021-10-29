using System;
using System.Collections.Generic;
using System.Linq;

namespace RockPaperScissors.Classes
{
    public static class Statistics
    {
        public static int  PlayerScore { get; set; }
        public static int ComputerScore { get; set; }
        public static int Turns { get; set; }
        public static Dictionary<Move, int> MoveCount { get; set; }

        public static string ShowScore()
        {
            return $"Your score : {PlayerScore} , Computer score : {ComputerScore}";
        }

        public static Move ReturnTopMove()
        {
            return MoveCount.OrderByDescending(x => x.Value).First().Key;
        }

        private static void SetUpMoveCount()
        {
            MoveCount = new Dictionary<Move, int>();
            foreach (var move in GameMaster.Moves)
            {
                MoveCount.Add(move, 0);
            }
        }

        public static string ReturnWinner()
        {
            return ComputerScore > PlayerScore ? "Computer" : "You";
        }

        public static void CountMoves(Move playerMove, Move computerMove)
        {
            MoveCount[playerMove]++;
            MoveCount[computerMove]++;
            Turns++;
        }
        public static void Reset()
        {
            PlayerScore = 0;
            ComputerScore = 0;
            Turns = 0;
            SetUpMoveCount();
        }

    }
}