using System;
using System.Collections.Generic;

namespace MakeSounds
{
    class Program
    {
        private static void Main(string[] args)
        {
            var firework = new Firework();
            var radio = new Radio();
            var parrot = new Parrot();

            var soundLIst = new List<ISound> {firework, radio, parrot};

            foreach (var c in soundLIst)
            {
                c.PlaySound();
            }

            Console.ReadLine();
        }
    }
}