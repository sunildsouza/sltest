using Moq;
using SLExcercise.Domain;
using SLExcercise.Enum;
using SLExcercise.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SLExercise.UnitTests
{
    public class PlayerTest
    {
        [Fact]
        public void Play()
        {
            var initialTokenPosition = 5;
            var player = new Player(new Dice(), new Board());
            player.TokenPosition = initialTokenPosition;
            player.Play();

            var newTokenPosition = player.TokenPosition;
            Assert.InRange(newTokenPosition, initialTokenPosition+1, initialTokenPosition + 6);
        }

        [Fact]
        public void Player_starts_the_game()
        {
            var player = new Player(new Dice(), new Board());
            player.Play();

            Assert.Equal(1, player.TokenPosition);
        }

        [Fact]
        public void Player_wins_the_game()
        {
            var initialTokenPosition = 97;
            var dice = new Mock<IDice>();
            dice.Setup(d => d.Roll()).Returns(3);
            var player = new Player(dice.Object, new Board());

            player.SetStatus(Status.Playing);
            player.TokenPosition = initialTokenPosition;
            player.Play();


            Assert.Equal(Status.Won, player.Status);
        }

        [Fact]
        public void Player_has_not_won_the_game()
        {
            var initialTokenPosition = 97;
            var dice = new Mock<IDice>();
            dice.Setup(d => d.Roll()).Returns(4);
            var player = new Player(dice.Object, new Board());

            player.SetStatus(Status.Playing);
            player.TokenPosition = initialTokenPosition;
            player.Play();


            Assert.Equal(Status.Playing, player.Status);
        }
    }
}
