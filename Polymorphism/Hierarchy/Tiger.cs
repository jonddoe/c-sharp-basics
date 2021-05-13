using System;

namespace Hierarchy
{
    public class Tiger:Feline
    {
        private readonly string _region;
        private int _foodQuantity;

        public Tiger(string animalName, string animalType, double animalWeight,string region) : base(animalName, animalType, animalWeight,region)
        {
            _region = region;
        }
        public override void Eat(Food food)
        {
            if (food.TypeOfFood == "meat")
            {
                _foodQuantity = food.Quantity;
               
            }
            else
            {
                Console.WriteLine("Tigers are not eating that type of food!");
                _foodQuantity = 0;
            }
        }

     public override string ShowAnimalInfo()
     {
         return $"{Type} [{Name}, {Weight}, {_region}, {_foodQuantity}]";
     }

     public override string MakeSound()
        {
            return "ROAAR!!!";
        }
    }
}