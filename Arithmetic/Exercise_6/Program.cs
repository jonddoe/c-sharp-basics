using System;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 110;


            for (var i = 1; i <= number; i++)
            {
                var coza = (i % 3 == 0) && (i % 7 != 0) && (i % 5 != 0);
                var loza = (i % 5 == 0) && (i % 3 != 0);
                var woza = (i % 7 == 0) && (i % 3 != 0);
                var cozaloza = (i % 3 == 0) && (i % 5 == 0);
                var cozawoza = (i % 3 == 0) && (i % 7 == 0);
                var notCozaWoza = (i % 11 == 0) && false == coza && false == loza && false == woza &&
                                  false == cozaloza &&
                                  false == cozawoza;

                if (coza) Console.Write("Coza ");
                if (cozaloza) Console.Write("CozaLoza ");
                if (loza) Console.Write("Loza ");
                if (cozawoza) Console.Write("CozaWoza ");
                if (woza) Console.Write("Woza ");
                if (notCozaWoza) Console.Write(i + " ");
                if (false == coza && false == loza && false == woza && false == cozaloza &&
                    false == cozawoza && (i % 11 != 0)) Console.Write(i + " ");
                if (i % 11 == 0) Console.WriteLine();
            }
        }
    }
}