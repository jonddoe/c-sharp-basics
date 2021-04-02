using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int.TryParse(Console.ReadLine(), out var num);
            Console.Write("Enter another number: ");
            int.TryParse(Console.ReadLine(), out var num2);

            Boolean isFifteen()
            {
                if (num == 15 || num2 == 15 || num + num2 == 15 || num - num2 == 15 || num2 - num == 15)
                {
                    return true;
                }

                return false;
            }

            Console.WriteLine(isFifteen());
            
        }
    }
}
