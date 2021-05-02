using System;
using System.Runtime.Intrinsics.Arm;
using System.Threading;

namespace Excercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            var inputString = Console.ReadLine();
            var numberOfUppercaseLetters = 0;
            if (inputString != null)
                foreach (var c in inputString)
                {
                    if (char.IsUpper(c)) numberOfUppercaseLetters++;
                }

            Console.WriteLine($"This string has {numberOfUppercaseLetters} uppercase letters in it.");
        }
    }
}
