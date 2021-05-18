using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Xunit;
using Assert = Xunit.Assert;
using RandomNumArrayGenerator;
using ArraysExercise6;

namespace RandomNumArrayGenerator.Tests
{
    [TestClass]
    public class RandomNumArrayGeneratorTests
    {
        [Fact]
        public void ArgumentsSidesOfRectangle_ReturnsAreaOfRectangle()
        {
            //arrange
            const string expected = "Array 1: 75 82 45 73 53 32 86 56 51 -7\nArray 2: 75 82 45 73 53 32 86 56 51 77";
            //act
            var actual = RandomNumArrayGenerator.GenerateRandomArray();
            //assert
            Assert.Equal(expected, actual);
        }
    }
}
