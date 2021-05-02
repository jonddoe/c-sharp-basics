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
                else if (cozaloza) Console.Write("CozaLoza ");
                else if (loza) Console.Write("Loza ");
                else if (cozawoza) Console.Write("CozaWoza ");
                else if (woza) Console.Write("Woza ");
                else if (notCozaWoza) Console.Write(i + " ");
                else if (coza == false && loza == false && woza == false && cozaloza == false &&
                         cozawoza == false && (i % 11 != 0)) Console.Write(i + " ");
                if (i % 11 == 0) Console.WriteLine();
            }
        }
    }
}