using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Xunit;
using Assert = Xunit.Assert;

namespace RandomNumArrayGenerator.Tests
{
    [TestClass]
    public class RandomNumArrayGeneratorTests
    {
        [Fact]
        public void GenerateRandomArray_Generates2RandomValueArrays_ReturnsMinus7AtTheEndOfFirst()
        {
            //arrange
            const string expected = "-7";
            //act
            var actual = RandomNumArrayGenerator.GenerateRandomArray();
            //assert
            Assert.Equal(expected, actual.Substring(actual.IndexOf("\n", StringComparison.Ordinal) - 2, 2));
        }
    }
}