namespace Hierarchy
{
    public abstract class Mammal : Animal
    {
        protected Mammal(string animalName, string animalType, double animalWeight, string region) :
            base(animalName, animalType, animalWeight)
        {
        }
    }
}