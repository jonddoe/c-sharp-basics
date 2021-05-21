using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using Assert = Xunit.Assert;

namespace SalaryCalculator.Tests
{
    [TestClass]
    public class SalaryCalculatorTests
    {
        [Fact]
        public void SalaryCalculation_BasePayLessThanAllowedAndHoursMoreThanAllowed_ReturnsCalculationErrorMessage()
        {
            //arrange
            const string expected = "Employee 1: Error in salary calculation!";
            //act
            var actual = SalaryCalculator.SalaryCalculation("Employee 1", 7.50, 351);
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SalaryCalculation_BasePayLessThanAllowed_ReturnsCalculationErrorMessage()
        {
            //arrange
            const string expected = "Employee 1: Error in salary calculation!";
            //act
            var actual = SalaryCalculator.SalaryCalculation("Employee 1", 3.50, 50);
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SalaryCalculation_HoursMoreThanAllowed_ReturnsCalculationErrorMessage()
        {
            //arrange
            const string expected = "Employee 1: Error in salary calculation!";
            //act
            var actual = SalaryCalculator.SalaryCalculation("Employee 1", 8.50, 660);
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SalaryCalculation_CalculateSalaryNoOvertime_ReturnsCalculatedSalary()
        {
            //arrange
            const string expected = "Employee 2 salary is: 320.00";
            //act
            var actual = SalaryCalculator.SalaryCalculation("Employee 2", 8.00, 40);
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void SalaryCalculation_CalculateOvertime_ReturnsCalculatedSalary()
        {
            //arrange
            const string expected =
                "Employee 2 salary is: 385.40\nEmployee 2 overtime salary is: 86.00\nEmployee 2 total salary is: 471.40";
            //act
            var actual = SalaryCalculator.SalaryCalculation("Employee 2", 8.20, 47);
            //assert
            Assert.Equal(expected, actual);
        }
    }
}