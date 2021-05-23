using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using Assert = Xunit.Assert;

namespace WordCount.Tests
{
    [TestClass]
    public class WordCountTests
    {
        [Fact]
        public void LineWordCharCount_LearTxt_ReturnsCorrectCount()
        {
            //arrange
            const string expected = "Lines = 6\nWords = 43\nChars = 252";
            //act
            var actual = WordCount.LineWordCharCount();
            //assert
            Assert.Equal(expected, actual);
        }
    }
}