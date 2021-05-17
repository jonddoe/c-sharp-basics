using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Xunit.Assert;
using Xunit;

namespace Exercise_1.Tests
{
    [TestClass]
    public class Any15Tests
    {
        [Fact]
        public void ArgumentA15_returnsTrue()
        {
            //arrange
            const bool expected = true;
            //act   
            var actual = Any15.IsFifteen(15, 2);
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ArgumentB15_returnsTrue()
        {
            //arrange
            const bool expected = true;
            //act   
            var actual = Any15.IsFifteen(1, 15);
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ArgumentDifferenceIs15_returnsTrue()
        {
            //arrange
            const bool expected = true;
            //act   
            var actual = Any15.IsFifteen(20, 5);
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ArgumentComboIsNot15_returnsFalse()
        {
            //arrange
            const bool expected = false;
            //act   
            var actual = Any15.IsFifteen(22, 5);
            //assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8, 7, true)]
        public void ArgumentSumIs15_returnsTrue(int a, int b, bool expected)
        {
            //arrange
            //act   
            var actual = Any15.IsFifteen(a, b);
            //assert
            Assert.Equal(expected, actual);
        }
    }
}