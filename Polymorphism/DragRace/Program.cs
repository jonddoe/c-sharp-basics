using System;
using System.Collections.Generic;
using System.Linq;

namespace DragRace
{
    class Program
    {
        private static void Main(string[] args)
        {
            var carsList = new List<ICar> {new Audi(), new Bmw(), new Lexus(), new Tesla(), new Porsche(), new Lada()};
            for (int i = 1; i <= 10; i++)
            {
                foreach (var car in carsList)
                {
                    switch (i)
                    {
                        case 1:
                            car.StartEngine();
                            break;
                        case 3 when car is IBoostable boostable:
                            boostable.UseNitrousOxideEngine();
                            break;
                    }

                    car.SpeedUp();
                }
            }

            carsList = carsList.OrderByDescending(c => int.Parse(c.ShowCurrentSpeed())).ToList();
            Console.WriteLine($"{carsList[0].GetType().Name} {carsList[0].ShowCurrentSpeed()}");
            Console.Read();
        }
    }
}