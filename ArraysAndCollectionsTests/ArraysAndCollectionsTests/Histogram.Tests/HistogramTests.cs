using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using Assert = Xunit.Assert;

namespace Histogram.Tests
{
    [TestClass]
    public class HistogramTests
    {
        [Fact]
        public void HistogramMaker_MidtermsTxt_ReturnsHistogramOfGrades()
        {
            //arrange
            const string expected = "00-09: \n" +
                                    "10-19: *\n" +
                                    "20-29: *\n" +
                                    "30-39: **\n" +
                                    "40-49: *\n" +
                                    "50-59: *****\n" +
                                    "60-69: *******\n" +
                                    "70-79: *****************\n" +
                                    "80-89: ******\n" +
                                    "90-99: **********\n" +
                                    "  100: *";
            //act
            var actual = Histogram.HistogramMaker();
            //assert
            Assert.Equal(expected, actual);
        }
    }
}