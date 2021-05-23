using System.Collections.Generic;

namespace Hierarchy
{
    public class AnimalStorage
    {
        private readonly List<Animal> _animalStorage;

        public AnimalStorage()
        {
            _animalStorage = new List<Animal>();
        }

        public void AddToAnimalStorage(Animal animal)
        {
            _animalStorage.Add(animal);
        }

        public override string ToString()
        {
            var n = "";
            foreach (var c in _animalStorage)
            {
                n += c.ShowAnimalInfo() + ", ";
            }

            return n.Substring(0, n.Length - 2);
        }
    }
}