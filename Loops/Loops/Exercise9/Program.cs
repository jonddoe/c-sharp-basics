using System;

namespace Exercise9
{
    class RollTwoDice
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sum you desire: ");
            int.TryParse(Console.ReadLine(), out var sum);

            RollDice(sum);
        }

        static void RollDice(int sum)
        {
            var random = new Random();
            int rollOfDice1;
            int rollOfDice2;
            do
            {
                rollOfDice1 = random.Next(1, 7);
                rollOfDice2 = random.Next(1, 7);

                Console.WriteLine($"{rollOfDice1} and {rollOfDice2} = {rollOfDice1 + rollOfDice2}");
                Console.ReadLine();
            } while (rollOfDice1 + rollOfDice2 != sum);
        }
    }
}
