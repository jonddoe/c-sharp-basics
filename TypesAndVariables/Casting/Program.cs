﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            first();
            second();
            Console.ReadKey();
        }

        static void first()
        {
            String a = "1";
            int b = 2;
            int c = 3;
            int d = 4;
            int e = 5;

            //fixme - should be 15 :|
            int sum = (int.Parse(a) + b + c + d + e);
            Console.WriteLine(sum);
        }

        static void second()
        {
            String a = "1";
            int b = 2;
            int c = 3;
            double d = 4.2;
            float e = 5.3f;

            //fixme - should be 15.5 :| 
            double sum = Math.Round(int.Parse(a) + b + c + d + e, 2);
            Console.WriteLine(sum);
        }
    }
}
