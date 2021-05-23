using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using Assert = Xunit.Assert;

namespace IsNumberHappy.Tests
{
    [TestClass]
    public class IsNumberHappyTests
    {
        [Fact]
        public void IsHappy_Argument139_ReturnsHappy()
        {
            //arrange
            const string expected = "Happy";
            //act
            var actual = IsNumberHappy.IsHappy(139);
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsHappy_Argument138_ReturnsNotHappy()
        {
            //arrange
            const string expected = "Not Happy";
            //act
            var actual = IsNumberHappy.IsHappy(138);
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Factorial_Argument139_Returns91()
        {
            //arrange
            const int expected = 91;
            //act
            var actual = IsNumberHappy.Factorial("139");
            //assert
            Assert.Equal(expected, actual);
        }
    }
}