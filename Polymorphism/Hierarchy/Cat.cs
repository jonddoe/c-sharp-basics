using System;

namespace Hierarchy
{
    public class Cat : Feline
    {
        private int _foodQuantity;
        private readonly string _region;
        private readonly string _breed;

        public Cat(string animalName, string animalType, double animalWeight, string region, string breed) : base(
            animalName,
            animalType, animalWeight, region)
        {
            _region = region;
            _breed = breed;
        }

        public override void Eat(Food food)
        {
            if (food.TypeOfFood == "meat" || food.TypeOfFood == "vegetables")
            {
                _foodQuantity = food.Quantity;
            }
            else
            {
                Console.WriteLine("Cats are not eating that type of food!");
                _foodQuantity = 0;
            }
        }

        public override string ShowAnimalInfo()
        {
            return $"{Type} [{Name}, {_breed}, {Weight}, {_region}, {_foodQuantity}]";
        }

        public override string MakeSound()
        {
            return "Meow";
        }
    }
}