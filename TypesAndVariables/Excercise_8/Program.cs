using System;
using System.Threading.Channels;

namespace Excercise_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter minutes:");
            var minutes = Int64.Parse(Console.ReadLine());
            var years = minutes / 525600;
            var days = minutes / 1440;
            var remainingMinutesInYears = days % 525600;
            var remainingDaysInYears= (remainingMinutesInYears / 1440).ToString("N0");
            Console.WriteLine($"{minutes} minutes equals {years} years or {days} days. Or {years} years and {remainingDaysInYears} days.");
        }
    }
}
