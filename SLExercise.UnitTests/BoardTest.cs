using SLExcercise.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SLExercise.UnitTests
{
    public class BoardTest
    {
        [Fact]
        public void SnakeTest()
        {
            var board = new Board();
            var initialTokenPosition = 7;
            var player = new Player(new Dice(), new Board());
            player.TokenPosition = initialTokenPosition;
            board.Move(player, 5);

            Assert.Equal(2, player.TokenPosition);
        }

        [Fact]
        public void LadderTest()
        {
            var board = new Board();
            var initialTokenPosition = 1;
            var player = new Player(new Dice(), new Board());
            player.TokenPosition = initialTokenPosition;
            board.Move(player, 1);

            Assert.Equal(12, player.TokenPosition);
        }


        [Fact]
        public void WithoutSnakeLadderTest()
        {
            var board = new Board();
            var initialTokenPosition = 3;
            var player = new Player(new Dice(), new Board());
            player.TokenPosition = initialTokenPosition;
            board.Move(player, 5);

            Assert.Equal(8, player.TokenPosition);
        }
    }
}
