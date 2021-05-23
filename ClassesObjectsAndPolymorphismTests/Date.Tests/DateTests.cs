using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using Assert = Xunit.Assert;

namespace Date.Tests
{
    [TestClass]
    public class DateTests
    {
        [Fact]
        public void DisplayDate_SetDate_ReturnDateAsString()
        {
            //arrange
            const string expected = "3/12/1989";
            //act
            var test = new Date();
            test.SetDate(3, 12, 1989);
            var actual = test.DisplayDate();
            //assert
            Assert.Equal(expected, actual);
        }
    }
}
