using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assert = Xunit.Assert;
using Xunit;

namespace CozaWozaLoza.Tests
{
    [TestClass]
    public class CozaWozaLozaTests
    {
        [Fact]
        public void Argument15_returnsThisString()
        {
            //arrange
            const string expected =
                "1 2 Coza 4 Loza Coza Woza 8 Coza Loza 11\nCoza 13 Woza CozaLoza 16 17 Coza 19 Loza CozaWoza 22\n23 Coza Loza 26 Coza Woza 29 CozaLoza 31 32 Coza";
            //act   
            var actual = CozaWozaLoza.CozaWozaLozaString(33);
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Argument110_returnsThisString()
        {
            //arrange
            const string expected =
                "1 2 Coza 4 Loza Coza Woza 8 Coza Loza 11\nCoza 13 Woza CozaLoza 16 17 Coza 19 Loza CozaWoza 22\n23 Coza Loza 26 Coza Woza 29 CozaLoza 31 32 Coza\n34 Loza Coza 37 38 Coza Loza 41 CozaWoza 43 44\nCozaLoza 46 47 Coza Woza Loza Coza 52 53 Coza Loza\nWoza Coza 58 59 CozaLoza 61 62 CozaWoza 64 Loza Coza\n67 68 Coza Loza 71 Coza 73 74 CozaLoza 76 Woza\nCoza 79 Loza Coza 82 83 CozaWoza Loza 86 Coza 88\n89 CozaLoza Woza 92 Coza 94 Loza Coza 97 Woza Coza\nLoza 101 Coza 103 104 CozaLoza 106 107 Coza 109 Loza";
            //act   
            var actual = CozaWozaLoza.CozaWozaLozaString(110);
            //assert
            Assert.Equal(expected, actual);
        }
    }
}