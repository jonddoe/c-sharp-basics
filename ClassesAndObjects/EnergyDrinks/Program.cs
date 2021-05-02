using System;

namespace EnergyDrinks
{
    class Program
    {
        private const int NumberedSurveyed = 12467;
        private const double PurchasedEnergyDrinks = 0.14;
        private const double PreferCitrusDrinks = 0.64;

        private static void Main(string[] args)
        {
            Console.WriteLine("Total number of people surveyed " + NumberedSurveyed);
            Console.WriteLine(
                $"Approximately {CalculateEnergyDrinkers(NumberedSurveyed).ToString("N0")} bought at least one energy drink.");
            Console.WriteLine(
                $"{CalculatePreferCitrus(NumberedSurveyed).ToString("N0")} of those prefer citrus flavored energy drinks.");
            Console.ReadLine();
        }

        static double CalculateEnergyDrinkers(int numberSurveyed)
        {
            return NumberedSurveyed * PurchasedEnergyDrinks;
        }

        static double CalculatePreferCitrus(int numberSurveyed)
        {
            return CalculateEnergyDrinkers(NumberedSurveyed) * PreferCitrusDrinks;
        }
    }
}