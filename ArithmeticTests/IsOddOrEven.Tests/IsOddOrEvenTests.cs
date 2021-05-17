using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise_2;
using Assert = Xunit.Assert;
using Xunit;

namespace IsOddOrEven.Tests
{
    [TestClass]
    public class IsOddOrEvenTests
    {
        [Fact]
        public void NumberIsEven_returnsEven()
        {
            //arrange
            const string expected = "Even";
            //act   
            var actual = OddOrEven.IsOddOrEven(6);
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void NumberIsOdd_returnsOdd()
        {
            //arrange
            const string expected = "Odd";
            //act   
            var actual = OddOrEven.IsOddOrEven(3);
            //assert
            Assert.Equal(expected, actual);
        }
    }
}