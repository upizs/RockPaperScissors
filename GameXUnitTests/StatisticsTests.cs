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
            Statistics.Reset();

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
            Statistics.Reset();

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
            Statistics.Reset();

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
            Statistics.Reset();
            //Act
            Statistics.ComputerScore += 2;
            Statistics.PlayerScore++;
            //Assert
            Assert.Equal("Computer", Statistics.ReturnWinner());
        }
        [Fact]
        public void PlayerIsWinner()
        {
            //Arange
            //For this particular case I needed to use start game 
            //So that GameMaster.GetMoves would run. Otherwise getting NullReference Error.
            //Dont know why other tests didnt say anything.
            Game.StartGame();
            //Act
            Statistics.ComputerScore++;
            Statistics.PlayerScore += 2;
            //Assert
            Assert.Equal("You", Statistics.ReturnWinner());
        }
        [Fact]
        public void WhoIsWinnerWhenBoth()
        {
            //Arange
            Statistics.Reset();
            //Act
            Statistics.ComputerScore += 2;
            Statistics.PlayerScore += 2;
            //Assert
            Assert.Equal("You", Statistics.ReturnWinner());
            //Returns Than PLayer is winner
            //Which is fair, better player satisfaction.
        }
        [Fact]
        public void WhatHappensWhenPlayerDoesntHaveScore()
        {
            //Arange
            Statistics.Reset();
            //Act
            Statistics.ComputerScore += 2;
            //Assert
            Assert.Equal("Computer", Statistics.ReturnWinner());
            //Computer still wins
        }
    }
}
