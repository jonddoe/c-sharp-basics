using System;
using System.IO;
using System.Text.RegularExpressions;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var readText = File.ReadAllLines("D:\\VS Projects\\c-sharp-basics\\Collections\\WordCount\\lear.txt");

            var textSplitWithSpace = Regex.Replace(string.Join(" ", readText), @"(\s)\s+", " ");
            var wordArray = textSplitWithSpace.Split(' ');
            var charArray = string.Join("", readText).ToCharArray();

            Console.WriteLine($"Lines = {readText.Length}");
            Console.WriteLine($"Words = {wordArray.Length}");
            Console.WriteLine($"Chars = {charArray.Length}");

            Console.Read();
        }
    }
}
