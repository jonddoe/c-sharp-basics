using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using Assert = Xunit.Assert;

namespace DragRace.Tests
{
    [TestClass]
    public class DragRaceTests
    {
        [Fact]
        public void StartEngine_NewAudi_ReturnsAudiSound()
        {
            //arrange
            const string expected = "Rrrrrrr.....";
            //act
            var test = new Audi();
            var actual = test.StartEngine();
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void StartEngine_NewTesla_ReturnsTeslaSound()
        {
            //arrange
            const string expected = "-- silence ---";
            //act
            var test = new Tesla();
            var actual = test.StartEngine();
            //assert
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void SpeedUp_NewAudi_ReturnsAudiSpeed()
        {
            //arrange
            const string expected = "11";
            //act
            var test = new Audi();
            test.StartEngine();
            test.SpeedUp();
            var actual = test.ShowCurrentSpeed();
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SpeedUp_NewTesla_ReturnsTeslaSpeed()
        {
            //arrange
            const string expected = "24";
            //act
            var test = new Tesla();
            test.SpeedUp();
            test.SpeedUp();
            test.SpeedUp();
            test.SlowDown();
            var actual = test.ShowCurrentSpeed();
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SlowDown_NewBmw_ReturnsBmwSpeed()
        {
            //arrange
            const string expected = "22";
            //act
            var test = new Bmw();
            test.SpeedUp();
            test.SpeedUp();
            test.SpeedUp();
            test.SlowDown();
            var actual = test.ShowCurrentSpeed();
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void UseNitro_NewPorsche_ReturnsPorscheSpeed()
        {
            //arrange
            const string expected = "40";
            //act
            var test = new Porsche();
            test.SpeedUp();
            test.SpeedUp();
            test.SlowDown();
            test.UseNitrousOxideEngine();
            var actual = test.ShowCurrentSpeed();
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void UseNitro_NewLexus_ReturnsPorscheSpeed()
        {
            //arrange
            const string expected = "40";
            //act
            var test = new Lexus();
            test.StartEngine();
            test.SpeedUp();
            test.SpeedUp();
            test.UseNitrousOxideEngine();
            var actual = test.ShowCurrentSpeed();
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SpeedUp_NewLada_ReturnsPorscheSpeed()
        {
            //arrange
            const string expected = "10";
            //act
            var test = new Lada();
            test.SpeedUp();
            test.SpeedUp();
            test.SpeedUp();
            test.SlowDown();
            var actual = test.ShowCurrentSpeed();
            //assert
            Assert.Equal(expected, actual);
        }
    }
}