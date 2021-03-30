using System;

namespace VariablesAndNames
{
    class Program
    {
        private static void Main(string[] args)
        {
            int Cars, Drivers, Passengers, CarsNotDriven, CarsDriven;
            double SeatsInACar, CarpoolCapacity, AveragePassengersPerCar;

            Cars = 100; //cars
            SeatsInACar = 4.0; //seats in a car
            Drivers = 28; // drivers
            Passengers = 90; // passengers
            CarsNotDriven = Cars - Drivers; //cars_not_driven  // free cars
            CarsDriven = Cars - CarsNotDriven; //cars_driven ; // cars driven at the moment
            CarpoolCapacity = CarsDriven * SeatsInACar; //carpool_capacity = // carpool capacity
            AveragePassengersPerCar =
                Math.Round(CarpoolCapacity / Passengers,
                    2); //average_passengers_per_car = // average passengers per car

            Console.WriteLine("There are " + Cars + " cars available.");
            Console.WriteLine("There are only " + Drivers + " drivers available.");
            Console.WriteLine("There will be " + CarsNotDriven + " empty cars today.");
            Console.WriteLine("We can transport " + CarpoolCapacity + " people today.");
            Console.WriteLine("We have " + Passengers + " to carpool today.");
            Console.WriteLine("We need to put about " + AveragePassengersPerCar + " in each car.");
            Console.ReadKey();
        }
    }
}