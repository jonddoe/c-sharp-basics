﻿using System;
using System.Net.Http.Headers;

namespace Output_09
{
    class Program
    {
        //todo: using function return hello world and display it.
        static void Main(string[] args)
        {
            Console.WriteLine(Concat("hello ", "world"));
            Console.ReadKey();
        }

        static string Concat(string w1, string w2)
        {
            return string.Concat(w1, w2);
        }
    }
}
