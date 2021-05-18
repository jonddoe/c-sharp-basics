using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Xunit;
using Assert = Xunit.Assert;

namespace WordCount.Tests
{
    [TestClass]
    public class WordCountTests
    {
        [Fact]
        public void Generates2RandomValueArrays_ReturnsMinus7AtTheEndOfFirst()
        {
            //arrange
            const string expected = "-7";
            //act
            var actual = WordCount.LineWordCharCount();
            //assert
            Assert.Equal(expected, actual.Substring(actual.IndexOf("\n", StringComparison.Ordinal) - 2, 2));
        }
    }
}
