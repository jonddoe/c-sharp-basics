using System;

namespace Hierarchy
{
    public class Cat : Feline
    {
        private int _foodQuantity;
        private readonly string _region;
        private readonly string _breed;
        private readonly string _type;
        private readonly string _name;
        private readonly double _weight;

        public Cat(string animalName, string animalType, double animalWeight, string region, string breed) : base(
            animalName,
            animalType, animalWeight, region)
        {
            _region = region;
            _breed = breed;
            _name = animalName;
            _weight = animalWeight;
            _type = animalType;
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
            return $"{_type} [{_name}, {_breed}, {_weight}, {_region}, {_foodQuantity}]";
        }

        public override string MakeSound()
        {
            return "Meow";
        }
    }
}