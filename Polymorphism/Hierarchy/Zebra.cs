using System;

namespace Hierarchy
{
    public class Zebra : Mammal
    {
        private int _foodQuantity;
        private readonly string _region;

        public Zebra(string animalName, string animalType, double animalWeight, string region) : base(
            animalName, animalType, animalWeight, region)
        {
            _region = region;
        }

        public override void Eat(Food food)
        {
            if (food.TypeOfFood == "vegetables")
            {
                _foodQuantity = food.Quantity;
            }
            else
            {
                Console.WriteLine("Zebras are not eating that type of food!");
                _foodQuantity = 0;
            }
        }

        public override string ShowAnimalInfo()
        {
            return $"{Type} [{Name}, {Weight}, {_region}, {_foodQuantity}]";
        }

        public override string MakeSound()
        {
            return "zzz";
        }
    }
}