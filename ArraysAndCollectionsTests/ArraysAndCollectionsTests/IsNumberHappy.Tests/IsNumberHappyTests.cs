using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using Assert = Xunit.Assert;

namespace IsNumberHappy.Tests
{
    [TestClass]
    public class IsNumberHappyTests
    {
        [Fact]
        public void Argument139_ReturnsTrue()
        {
            //arrange
            const bool expected = true;
            //act
            var actual = IsNumberHappy.IsHappy(139);
            //assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void Argument138_ReturnsFalse()
        {
            //arrange
            const bool expected = false;
            //act
            var actual = IsNumberHappy.IsHappy(138);
            //assert
            Assert.Equal(expected, actual);
        }
    }
}
