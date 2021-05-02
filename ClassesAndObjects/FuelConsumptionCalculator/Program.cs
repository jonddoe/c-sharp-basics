using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelConsumptionCalculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine();

            Car car = new Car(0);
            Car car1 = new Car(0);
            Car car2 = new Car(0);

            Console.Write("Enter first reading: ");
            int.TryParse(Console.ReadLine(), out var startKilometers);
            Console.Write("Enter liters reading: ");
            int.TryParse(Console.ReadLine(), out var liters);
            car.FillUp(startKilometers, liters);

            Console.Write("Enter first reading: ");
            startKilometers = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter liters reading: ");
            liters = Convert.ToInt32(Console.ReadLine());
            car1.FillUp(startKilometers, liters);

            Console.Write("Enter first reading: ");
            startKilometers = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter liters reading: ");
            liters = Convert.ToInt32(Console.ReadLine());
            car2.FillUp(startKilometers, liters);

            Console.WriteLine("Car Kilometers per liter are " + car.CalculateConsumption() + " gasHog:" + car.GasHog() +
                              " economyCar:" + car.EconomyCar());
            Console.WriteLine("Car1 Kilometers per liter are " + car1.CalculateConsumption() + " gasHog:" +
                              car1.GasHog() + " economyCar:" + car1.EconomyCar());
            Console.WriteLine("Tesla Kilometers per liter are " + car2.CalculateConsumption() + " gasHog:" +
                              car2.GasHog() + " economyCar:" + car2.EconomyCar());
            Console.ReadKey();
        }
    }
}