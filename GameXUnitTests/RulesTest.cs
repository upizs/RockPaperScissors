using RockPaperScissors.Classes;
using System;
using Xunit;

namespace GameXUnitTests
{
    public class RulesTest
    {
        [Fact]
        public void PaperBeatsRockAndSpock()
        {
            //Arrange
            Game.StartGame();
            //Act
            Game.Player.Move = Move.Paper;
            //Assets
            Assert.True(Game.Player.Beats(Move.Rock));
            Assert.True(Game.Player.Beats(Move.Spock));
        }
        [Fact]
        public void RockBeatsScissorsAndLizard()
        {
            //Arrange
            Game.StartGame();
            //Act
            Game.Player.Move = Move.Rock;
            //Assets
            Assert.True(Game.Player.Beats(Move.Scissors));
            Assert.True(Game.Player.Beats(Move.Lizard));
        }

        [Fact]
        public void ScissorsBeatsPaperAndLizard()
        {
            //Arrange
            Game.StartGame();
            //Act
            Game.Player.Move = Move.Scissors;
            //Assets
            Assert.True(Game.Player.Beats(Move.Paper));
            Assert.True(Game.Player.Beats(Move.Lizard));
        }

        [Fact]
        public void SpockBeatsScissorsAndRock()
        {
            //Arrange
            Game.StartGame();
            //Act
            Game.Player.Move = Move.Spock;
            //Assets
            Assert.True(Game.Player.Beats(Move.Scissors));
            Assert.True(Game.Player.Beats(Move.Rock));
        }
        [Fact]
        public void LizardBeatsSpockAndPaper()
        {
            //Arrange
            Game.StartGame();
            //Act
            Game.Player.Move = Move.Lizard;
            //Assets
            Assert.True(Game.Player.Beats(Move.Paper));
            Assert.True(Game.Player.Beats(Move.Spock));
        }


    }
}
