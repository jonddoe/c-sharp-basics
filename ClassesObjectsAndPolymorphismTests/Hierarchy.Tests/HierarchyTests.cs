using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Xunit;
using Assert = Xunit.Assert;

namespace Hierarchy.Tests
{
    [TestClass]
    public class HierarchyTests
    {
        [Fact]
        public void MakeSound_NewZebra_ReturnsZebraSound()
        {
            //arrange
            const string expected = "zzz";
            var test = new Zebra("Bob", "zebra", 82, "Africa");
            //act
            var actual = test.MakeSound();
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShowAnimalInfo_NewZebraEats_ReturnsAnimalInfo()
        {
            //arrange
            const string expected = "zebra [Bob, 82, Africa, 5]";
            var test = new Zebra("Bob", "zebra", 82, "Africa");
            var testFood = new Vegetable("vegetables", 5);
            test.Eat(testFood);
            //act
            var actual = test.ShowAnimalInfo();
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShowAnimalInfo_NewTigerEats_ReturnsAnimalInfo()
        {
            //arrange
            const string expected = "tiger [Bob, 82, Africa, 2]";
            var test = new Tiger("Bob", "tiger", 82, "Africa");
            var testFood = new Meat("meat", 2);
            test.Eat(testFood);
            //act
            var actual = test.ShowAnimalInfo();
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShowAnimalInfo_NewCat_ReturnsAnimalInfo()
        {
            //arrange
            const string expected = "cat [Bob, Persian, 2, Africa, 5]";
            var test = new Cat("Bob", "cat", 2, "Africa", "Persian");
            var testFood = new Vegetable("vegetables", 5);
            test.Eat(testFood);
            //act
            var actual = test.ShowAnimalInfo();
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Eat_NewCatEatsWrongFood_ExceptionThrown()
        {
            //arrange
            const string expected = "Cats are not eating that type of food!";
            var test = new Cat("Bob", "cat", 2, "LV", "Persian");
            var testFood = new Meat("dfdw", 2);
            //act
            var ex = Assert.Throws<ArgumentException>(() => test.Eat(testFood));
            //assert
            Assert.Equal(expected, ex.Message);
        }

        [Fact]
        public void MakeSound_NewMouse_ReturnsMouseSound()
        {
            //arrange
            const string expected = "pii";
            var test = new Mouse("Stewart", "mouse", 1, "Basement");
            //act
            var actual = test.MakeSound();
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void MakeSound_NewTiger_ReturnsTigerSound()
        {
            //arrange
            const string expected = "ROAAR!!!";
            var test = new Tiger("Bob", "tiger", 82, "Africa");
            //act
            var actual = test.MakeSound();
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShowAnimalInfo_NewMouseEats_ReturnsAnimalInfo()
        {
            //arrange
            const string expected = "mouse [Stewart, 1, Basement, 5]";
            var test = new Mouse("Stewart", "mouse", 1, "Basement");
            var testFood = new Meat("meat", 5);
            //act
            test.Eat(testFood);
            var actual = test.ShowAnimalInfo();
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void AnimalStorage_AddAnimalToStorage_ReturnsAllAnimalInfo()
        {
            //arrange
            const string expected = "mouse [Stewart, 1, Basement, 5], cat [Bob, Persian, 2, Africa, 0]";
            var test = new Mouse("Stewart", "mouse", 1, "Basement");
            var test2 = new Cat("Bob", "cat", 2, "Africa", "Persian");
            var testFood = new Meat("meat", 5);
            test.Eat(testFood);
            var testStorage = new AnimalStorage();
            testStorage.AddToAnimalStorage(test);
            testStorage.AddToAnimalStorage(test2);
            //act
            var actual = testStorage.ToString();
            //assert
            Assert.Equal(expected, actual);
        }
    }
}