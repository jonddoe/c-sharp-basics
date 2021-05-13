namespace Hierarchy
{
    public abstract class Animal
    {
        public string Name;
        public string Type;
        public double Weight;

        protected Animal(string animalName, string animalType, double animalWeight)
        {
            Name = animalName;
            Type = animalType;
            Weight = animalWeight;
        }

        public abstract string ShowAnimalInfo();

        public abstract string MakeSound();

        public abstract void Eat(Food food);
    }
}