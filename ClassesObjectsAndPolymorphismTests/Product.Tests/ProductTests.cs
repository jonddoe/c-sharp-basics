using Microsoft.VisualStudio.TestTools.UnitTesting;
using Xunit;
using Assert = Xunit.Assert;

namespace Product.Tests
{
    [TestClass]
    public class ProductTests
    {
        [Fact]
        public void PrintProduct_AddMouseToInventory_ReturnsProductInfoString()
        {
            //arrange
            const string expected = "Logitech mouse, 70 EUR, 14 Units";
            var mouse = new Product("Logitech mouse", 70.00, 14);
            //act
            var actual = mouse.PrintProduct();
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ChangePrice_ProductInfoIsChanged_ReturnsUpdatedProductInfoString()
        {
            //arrange
            const string expected = "Logitech mouse, 99.99 EUR, 44 Units";
            var mouse = new Product("Logitech mouse", 70.00, 14);
            mouse.ChangePrice(99.99);
            mouse.ChangeAmount(44);
            //act
            var actual = mouse.PrintProduct();
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ChangeAmount_ProductInfoIsChanged_ReturnsUpdatedProductInfoString()
        {
            //arrange
            const string expected = "iPhone 5s, 889.99 EUR, 74 Units";
            var phone = new Product("iPhone 5s", 999.99, 3);
            phone.ChangePrice(889.99);
            phone.ChangeAmount(74);
            //act
            var actual = phone.PrintProduct();
            //assert
            Assert.Equal(expected, actual);
        }
    }
}