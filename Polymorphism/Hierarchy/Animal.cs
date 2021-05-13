namespace Hierarchy
{
    public abstract class Animal
    {
        protected Animal(string animalName, string animalType, double animalWeight)
        {
        }

        public abstract string ShowAnimalInfo();

        public abstract string MakeSound();

        public abstract void Eat(Food food);
    }
}