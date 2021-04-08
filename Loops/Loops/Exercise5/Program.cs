using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            var outputLength = 30;
            Console.WriteLine("Enter the first word: ");
            var firstWord = Console.ReadLine();
            Console.WriteLine("Enter the second word: ");
            var secondWord = Console.ReadLine();
            var separator = "";
            for (var i = outputLength; i > firstWord.Length + secondWord.Length; i--)
            {
                separator += ".";
            }

            Console.WriteLine($"{firstWord}{separator}{secondWord}");
            Console.ReadLine();
        }
    }
}
