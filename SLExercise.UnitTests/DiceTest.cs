using SLExcercise.Domain;
using System;
using Xunit;

namespace SLExercise.UnitTests
{
    public class DiceTest
    {
        [Fact]
        public void Roll()
        {
            var dice = new Dice();
            var result = dice.Roll();

            Assert.InRange(result, 1, 6);
        }
    }
}
