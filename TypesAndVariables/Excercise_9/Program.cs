using System;

namespace Excercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter distance in meters:");
            var distanceInMeters = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Hours passed:");
            var hoursPassed = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Minutes passed:");
            var minutesPassed = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Seconds passed:");
            var secondsPassed = Int32.Parse(Console.ReadLine());

            var totalSecondsPassed = Convert.ToDecimal(hoursPassed) * 3600 + minutesPassed * 60 + secondsPassed;
            var totalHoursPassed = Convert.ToDecimal(totalSecondsPassed) / 3600;
            var distanceInKilometers = Convert.ToDecimal(distanceInMeters) / 1000;

            var metersPerSecond = Convert.ToDecimal(distanceInMeters) / totalSecondsPassed;
            var kilometersPerHour = distanceInKilometers / totalHoursPassed;
            var milesPerHour = Convert.ToDecimal(distanceInMeters) / 1609 / totalHoursPassed;

            Console.WriteLine($"Your speed in meters/second is {metersPerSecond:N8}");
            Console.WriteLine($"Your speed in km/h is {kilometersPerHour:N8}");
            Console.WriteLine($"Your speed in miles/h is {milesPerHour:N8}");
        }
    }
}
