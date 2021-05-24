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
            var test = new Audi();
            //act
            var actual = test.StartEngine();
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void StartEngine_NewTesla_ReturnsTeslaSound()
        {
            //arrange
            const string expected = "-- silence ---";
            var test = new Tesla();
            //act
            var actual = test.StartEngine();
            //assert
            Assert.Equal(expected, actual);
        }


        [Fact]
        public void ShowCurrentSpeed_NewAudi_ReturnsAudiSpeed()
        {
            //arrange
            const string expected = "11";
            var test = new Audi();
            test.StartEngine();
            test.SpeedUp();
            //act
            var actual = test.ShowCurrentSpeed();
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShowCurrentSpeed_NewTesla_ReturnsTeslaSpeed()
        {
            //arrange
            const string expected = "24";
            var test = new Tesla();
            test.SpeedUp();
            test.SpeedUp();
            test.SpeedUp();
            test.SlowDown();
            //act
            var actual = test.ShowCurrentSpeed();
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShowCurrentSpeed_NewBmw_ReturnsBmwSpeed()
        {
            //arrange
            const string expected = "22";
            var test = new Bmw();
            test.SpeedUp();
            test.SpeedUp();
            test.SpeedUp();
            test.SlowDown();
            //act
            var actual = test.ShowCurrentSpeed();
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShowCurrentSpeed_NewPorsche_ReturnsPorscheSpeed()
        {
            //arrange
            const string expected = "40";
            var test = new Porsche();
            test.SpeedUp();
            test.SpeedUp();
            test.SlowDown();
            test.UseNitrousOxideEngine();
            //act
            var actual = test.ShowCurrentSpeed();
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShowCurrentSpeed_NewLexus_ReturnsPorscheSpeed()
        {
            //arrange
            const string expected = "40";
            var test = new Lexus();
            test.StartEngine();
            test.SpeedUp();
            test.SpeedUp();
            test.UseNitrousOxideEngine();
            //act
            var actual = test.ShowCurrentSpeed();
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShowCurrentSpeed_NewLada_ReturnsPorscheSpeed()
        {
            //arrange
            const string expected = "10";
            var test = new Lada();
            test.SpeedUp();
            test.SpeedUp();
            test.SpeedUp();
            test.SlowDown();
            //act
            var actual = test.ShowCurrentSpeed();
            //assert
            Assert.Equal(expected, actual);
        }
    }
}