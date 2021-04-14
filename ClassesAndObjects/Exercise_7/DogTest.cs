using System;

namespace Exercise_7
{
    class DogTest
    {
        static void Main(string[] args)
        {
            Dog maxx = new Dog("Max", "male");
            Dog rocky = new Dog("Rocky", "male");
            Dog sparky = new Dog("Sparky", "male");
            Dog buster = new Dog("Buster", "male");
            Dog sam = new Dog("Sam", "male");
            Dog lady = new Dog("Lady", "female");
            Dog molly = new Dog("Molly", "female");
            Dog coco = new Dog("Coco", "female");

            maxx.mother = lady.DogsName();
            maxx.father = rocky.DogsName();

            coco.mother = molly.DogsName();
            coco.father = buster.DogsName();

            rocky.mother = molly.DogsName();
            rocky.father = sam.DogsName();

            buster.mother = lady.DogsName();
            buster.father = sparky.DogsName();

            Console.WriteLine(maxx.FathersName());
            Console.WriteLine(sam.MothersName());
            Console.WriteLine(sam.DogsName());
            Console.WriteLine(coco.HasSameMotherAs(rocky));
            Console.ReadLine();
        }
    }
}