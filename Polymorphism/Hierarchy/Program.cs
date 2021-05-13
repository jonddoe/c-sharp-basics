using System;

namespace Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        {
            var animalType = "";
            var animalStorage = new AnimalStorage();
            do
            {
                Console.WriteLine("Enter animal characteristics:");
                Console.WriteLine("Enter animal type:");
                animalType = Console.ReadLine();

                switch (animalType.ToLower())
                {
                    case "tiger":
                    {
                        Console.WriteLine("Enter animal name:");
                        var animalName = Console.ReadLine();
                        Console.WriteLine("Enter animal weight:");
                        double.TryParse(Console.ReadLine(), out var animalWeight);
                        Console.WriteLine("Enter animal region:");
                        var animalLivingRegion = Console.ReadLine();

                        var newTiger = new Tiger(animalName, animalType, animalWeight, animalLivingRegion);
                        animalStorage.AddToAnimalStorage(newTiger);

                        Console.WriteLine(newTiger.MakeSound() + "\nEnter food:");
                        var food = Console.ReadLine();
                        Console.WriteLine("Enter quantity:");
                        int.TryParse(Console.ReadLine(), out var quantity);

                        var newFood = new Meat(food, quantity);
                        newTiger.Eat(newFood);

                        Console.WriteLine(newTiger.ShowAnimalInfo());
                        break;
                    }
                    case "cat":
                    {
                        Console.WriteLine("Enter animal name:");
                        var animalName = Console.ReadLine();
                        Console.WriteLine("Enter animal breed:");
                        var catBreed = Console.ReadLine();
                        Console.WriteLine("Enter animal weight:");
                        double.TryParse(Console.ReadLine(), out var animalWeight);
                        Console.WriteLine("Enter animal region:");
                        var animalLivingRegion = Console.ReadLine();

                        var newCat = new Cat(animalName, animalType, animalWeight, animalLivingRegion, catBreed);
                        animalStorage.AddToAnimalStorage(newCat);

                        Console.WriteLine(newCat.MakeSound() + "\nEnter food:");
                        var food = Console.ReadLine();
                        Console.WriteLine("Enter quantity:");
                        int.TryParse(Console.ReadLine(), out var quantity);

                        switch (food.ToLower())
                        {
                            case "meat":
                            {
                                var newFood = new Meat(food, quantity);
                                newCat.Eat(newFood);
                                break;
                            }
                            case "vegetables":
                            {
                                var newFood = new Vegetable(food, quantity);
                                newCat.Eat(newFood);
                                break;
                            }
                        }

                        Console.WriteLine(newCat.ShowAnimalInfo());
                        break;
                    }
                    case "mouse":
                    {
                        Console.WriteLine("Enter animal name:");
                        var animalName = Console.ReadLine();
                        Console.WriteLine("Enter animal weight:");
                        double.TryParse(Console.ReadLine(), out var animalWeight);
                        Console.WriteLine("Enter animal region:");
                        var animalLivingRegion = Console.ReadLine();

                        var newMouse = new Mouse(animalName, animalType, animalWeight, animalLivingRegion);
                        animalStorage.AddToAnimalStorage(newMouse);

                        Console.WriteLine(newMouse.MakeSound() + "\nEnter food:");
                        var food = Console.ReadLine();
                        Console.WriteLine("Enter quantity:");
                        int.TryParse(Console.ReadLine(), out var quantity);

                        switch (food.ToLower())
                        {
                            case "meat":
                            {
                                var newFood = new Meat(food, quantity);
                                newMouse.Eat(newFood);
                                break;
                            }
                            case "vegetables":
                            {
                                var newFood = new Vegetable(food, quantity);
                                newMouse.Eat(newFood);
                                break;
                            }
                                
                        }

                        Console.WriteLine(newMouse.ShowAnimalInfo());
                        break;
                    }
                    case "zebra":
                    {
                        Console.WriteLine("Enter animal name:");
                        var animalName = Console.ReadLine();
                        Console.WriteLine("Enter animal weight:");
                        double.TryParse(Console.ReadLine(), out var animalWeight);
                        Console.WriteLine("Enter animal region:");
                        var animalLivingRegion = Console.ReadLine();

                        var newZebra = new Zebra(animalName, animalType, animalWeight, animalLivingRegion);
                        animalStorage.AddToAnimalStorage(newZebra);

                        Console.WriteLine(newZebra.MakeSound() + "\nEnter food:");
                        var food = Console.ReadLine();
                        Console.WriteLine("Enter quantity:");
                        int.TryParse(Console.ReadLine(), out var quantity);

                        var newFood = new Vegetable(food, quantity);
                        newZebra.Eat(newFood);

                        Console.WriteLine(newZebra.ShowAnimalInfo());
                        break;
                    }
                }

                Console.ReadLine();
                Console.Clear();
            } while (animalType.ToLower() != "end");

            Console.WriteLine(animalStorage);
            Console.Read();
        }
    }
}