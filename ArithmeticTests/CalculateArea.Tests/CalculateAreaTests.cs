using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using Assert = Xunit.Assert;

namespace CalculateArea.Tests
{
    [TestClass]
    public class CalculateAreaTests
    {
        [Fact]
        public void ArgumentAreaOfCircleRadius_ReturnsAreaOfCircle()
        {
            //arrange
            const string expected = "92.71";
            //act
            var actual = Geometry.AreaOfCircle(decimal.Parse(5.43244.ToString()));
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ArgumentsSidesOfRectangle_ReturnsAreaOfRectangle()
        {
            //arrange
            const string expected = "38.68";
            //act
            var actual = Geometry.AreaOfRectangle(decimal.Parse(6.75.ToString()), decimal.Parse(5.73.ToString()));
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ArgumentsBaseAndHeightOfTriangle_ReturnsAreaOfTriangle()
        {
            //arrange
            const string expected = "11.84";
            //act
            var actual = Geometry.AreaOfTriangle(decimal.Parse(9.32.ToString()), decimal.Parse(2.54.ToString()));
            //assert
            Assert.Equal(expected, actual);
        }
    }
}