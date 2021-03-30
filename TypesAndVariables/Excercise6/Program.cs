using System;
using System.Collections.Generic;
using System.Linq;

namespace Excercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            var enteredValue = new ConsoleKeyInfo();
            var addedNumbers = new List<int>();
            while (enteredValue.Key != ConsoleKey.Escape)
            {
                Console.WriteLine("Press Esc to get the sum of numbers");
                Console.WriteLine("Enter a number ");

                enteredValue = Console.ReadKey();
                Console.WriteLine();
                if (IsEscapeKey(enteredValue))
                {
                    break;
                }

                if (int.TryParse(enteredValue.KeyChar.ToString(), out var number))

                    addedNumbers.Add(number);
            }

            Console.WriteLine($"sum of numbers: {addedNumbers.Sum()}");
            
            Console.ReadKey();
        }

        private static bool IsEscapeKey(ConsoleKeyInfo pressedKey)
        {
            return pressedKey.Key == ConsoleKey.Escape;
        }
    }
}
