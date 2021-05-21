using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using Assert = Xunit.Assert;

namespace GravityCalculator.Tests
{
    [TestClass]
    public class GravityCalculatorTests
    {
        [Fact]
        public void CalculateFallingObject_Argument10_returnsThisString()
        {
            //arrange
            const string expected = "The object's position after 10 seconds is -490.5 m.";
            //act
            var actual = GravityCalculator.CalculateFallingObject(10);
            //assert
            Assert.Equal(expected, actual);
        }
    }
}