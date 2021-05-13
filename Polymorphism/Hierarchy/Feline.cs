namespace Hierarchy
{
    public abstract class Feline : Mammal
    {
        protected Feline(string animalName, string animalType, double animalWeight, string region) :
            base(animalName, animalType, animalWeight, region)
        {
        }
    }
}