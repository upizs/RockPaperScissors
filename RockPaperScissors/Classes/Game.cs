
using System;
using System.Collections.Generic;
using System.Linq;

namespace RockPaperScissors.Classes
{
    //Runs the game
    public static class Game
    {
        public static Player Player { get; set; }
        public static Cumputer Computer { get; set; }

        public static string WhoScores { get; private set; }

        public static void StartGame()
        {
            Player = new Player();
            Computer = new Cumputer();
            //I set up the game rules, who beats who
            GameMaster.SetUpRules();
            GameMaster.GetMoves();
            Statistics.Reset();
        }
        
        public static void PlayTurn()
        {
            Computer.MakeMove();
            if (Player.Move == Computer.Move)
            {
                WhoScores = "Its a tie!";
            }
            else if (Player.Beats(Computer.Move))
            {
                Statistics.PlayerScore++;
                WhoScores = "You score!";
            }
            else
            {
                Statistics.ComputerScore++;
                WhoScores = "Computer scores!";
            }
            Statistics.CountMoves(Player.Move, Computer.Move);
        }

        public static bool EndGame()
        {
            if (Statistics.PlayerScore >= GameMaster.ScoreToWin || Statistics.ComputerScore >= GameMaster.ScoreToWin)
            {
                return true;
            }
            return false;
        }

    }
}
