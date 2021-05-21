using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Xunit.Assert;
using Xunit;

namespace OddOrEven.Tests
{
    [TestClass]
    public class OddOrEvenTests
    {
        [Fact]
        public void OddOrEven_NumberIsEven_returnsEven()
        {
            //arrange
            const string expected = "Even";
            //act   
            var actual = OddOrEven.IsOddOrEven(6);
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void OddOrEven_NumberIsOdd_returnsOdd()
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