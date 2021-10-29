using RockPaperScissors.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace GameXUnitTests
{
    public class StatisticsTests
    {
        [Fact]
        public void RockIsTopMove()
        {
            //Arange
            Game.StartGame();

            //Act
            Statistics.CountMoves(Move.Rock, Move.Rock);
            Statistics.CountMoves(Move.Rock, Move.Paper);

            //Assert
            Assert.Equal(Move.Rock, Statistics.ReturnTopMove());
        }
        [Fact]

        public void SpockIsTopMove()
        {
            //Arange
            Game.StartGame();

            //Act
            Statistics.CountMoves(Move.Spock, Move.Spock);
            Statistics.CountMoves(Move.Spock, Move.Paper);

            //Assert
            Assert.Equal(Move.Spock, Statistics.ReturnTopMove());
        }
        [Fact]
        //When two moves are top moves what returns is Alphabetic first?
        public void TopMoveComesInAplphabeticOrder()
        {
            //Arange
            Game.StartGame();

            //Act
            Statistics.CountMoves(Move.Spock, Move.Spock);
            Statistics.CountMoves(Move.Paper, Move.Paper);

            //Assert
            Assert.Equal(Move.Paper, Statistics.ReturnTopMove());
        }
        [Fact]
        public void ComputerIsWinner()
        {
            //Arange
            Game.StartGame();
            //Act
            Statistics.ComputerScore = 2;
            Statistics.PlayerScore = 1;
            //Assert
            Assert.Equal("Computer", Statistics.ReturnWinner());
        }
        [Fact]
        public void PlayerIsWinner()
        {
            //Arange
            Game.StartGame();
            //Act
            Statistics.ComputerScore =1;
            Statistics.PlayerScore = 2;
            //Assert
            Assert.Equal("You", Statistics.ReturnWinner());
        }
        [Fact]
        public void WhoIsWinnerWhenBoth()
        {
            //Arange
            Game.StartGame();
            //Act
            Statistics.ComputerScore = 2;
            Statistics.PlayerScore = 2;
            //Assert
            Assert.Equal("You", Statistics.ReturnWinner());
            //Returns Than PLayer is winner
            //Which is fair, better player satisfaction.
        }
        [Fact]
        public void WhatHappensWhenPlayerDoesntHaveScore()
        {
            //Arange
            Game.StartGame();
            //Act
            Statistics.ComputerScore = 2;
            //Assert
            Assert.Equal("Computer", Statistics.ReturnWinner());
            //Computer still wins
        }

    }
}
