using System;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point {X = 5, Y = 2};

            var p2 = new Point {X = -3, Y = 6};

            Point.SwapPoints(p1, p2);
            Console.WriteLine("(" + p1.X + ", " + p1.Y + ")");
            Console.WriteLine("(" + p2.X + ", " + p2.Y + ")");
        }
    }
}
