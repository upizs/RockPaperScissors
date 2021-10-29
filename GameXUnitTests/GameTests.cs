using RockPaperScissors.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GameXUnitTests
{
    public class GameTests
    {
        [Fact]
        public void PlayerBeatsComputer()
        {
            //Arange
            Game.StartGame();

            //Act
            Game.Player.Move = Move.Rock;
            Game.Computer.Move = Move.Scissors;
            Game.PlayTurn();

            //Assert
            Assert.Equal("You score!", Game.WhoScores);
        }
        [Fact]
        public void ComputerBeatsPlayer()
        {
            //Arange
            Game.StartGame();

            //Act
            Game.Player.Move = Move.Scissors;
            Game.Computer.Move = Move.Rock;
            Game.PlayTurn();

            //Assert
            Assert.Equal("Computer scores!", Game.WhoScores);
        }
        [Fact]
        public void ItsATie()
        {
            //Arange
            Game.StartGame();

            //Act
            Game.Player.Move = Move.Rock;
            Game.Computer.Move = Move.Rock;
            Game.PlayTurn();

            //Assert
            Assert.Equal("Its a tie!", Game.WhoScores);
        }

        [Fact]
        public void GameEnds()
        {
            //Arange
            Game.StartGame();

            //Act
            GameMaster.ScoreToWin = 2;
            Statistics.ComputerScore = 2;

            //Assert
            Assert.True( Game.EndGame());
        }


    }
}
