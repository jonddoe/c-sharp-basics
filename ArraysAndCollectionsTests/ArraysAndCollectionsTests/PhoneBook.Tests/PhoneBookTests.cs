using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using Assert = Xunit.Assert;

namespace PhoneBook.Tests
{
    [TestClass]
    public class PhoneBookTests
    {
        [Fact]
        public void GetNumber_ArgumentJon_ReturnsContactsNumber()
        {
            //arrange
            const string expected = "939-3394-264";
            //act
            var test = new PhoneDirectory();
            test.PutNumber("Jon", "779-3344-564");
            test.PutNumber("Bob", "019-3644-534");
            test.PutNumber("Joe", "939-3394-264");
            var actual = test.GetNumber("Joe");
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetNumber_ArgumentIsNotInDirectory_ReturnsNull()
        {
            //arrange
            const string expected = null;
            //act
            var test = new PhoneDirectory();
            test.PutNumber("Jon", "779-3344-564");
            test.PutNumber("Bob", "019-3644-534");
            test.PutNumber("Joe", "939-3394-264");
            var actual = test.GetNumber("Eddy");
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void FindNumber_ArgumentJoe_ReturnsContactsKey()
        {
            //arrange
            const int expected = 2;
            //act
            var test = new PhoneDirectory();
            test.PutNumber("Jon", "779-3846-566");
            test.PutNumber("Bob", "019-3644-534");
            test.PutNumber("Joe", "939-3394-264");
            var actual = test.Find("Joe");
            //assert
            Assert.Equal(expected, actual);
        }
    }
}