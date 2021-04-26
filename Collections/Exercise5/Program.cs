using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int.TryParse(Console.ReadLine(), out var inputNum);

            static int Factorial(string n)
            {
                var d = 0;

                var digitsArray = n.ToCharArray();
                foreach (var c in digitsArray)
                {
                    d += int.Parse(c.ToString()) * int.Parse(c.ToString());
                }

                return d;
            }

            static bool IsHappy(int n)
            {
                int fast;
                var slow = fast = n;
                do
                {
                    slow = Factorial(slow.ToString());
                    fast = Factorial(Factorial(fast.ToString()).ToString());
                } while (slow != fast);

                return (slow == 1);
            }

            Console.Write(IsHappy(inputNum) ? "Happy" : "Not Happy");
            Console.Read();
        }
    }
}