using SLExcercise.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SLExercise.UnitTests
{
    public class GameTest
    {
        [Fact]
        public void Start_Game()
        {
            var game = new Game(new Board());
            var dice = new Dice();
            var board = new Board();
            var player = new Player(dice, board)
            {
                Id = 1,
                Name = "Test Player"
            };
            game.AddPlayer(player);

            game.Start(player);
        }


        [Fact]
        public void Game_PlayOrder_Test()
        {
            var game = new Game(new Board());
            var dice = new Dice();
            var board = new Board();
            var player1 = new Player(dice, board)
            {
                Id = 1,
                Name = "Test Player1"
            };
            player1.Roll();
            game.AddPlayer(player1);

            var player2 = new Player(dice, board)
            {
                Id = 2,
                Name = "Test Player2"
            };
            player2.Roll();

            game.AddPlayer(player2);

            var playerToStart = game.GetFirstPlayerToPlay();

            game.Start(playerToStart);

            //This test is incomplete
        }
    }
}
