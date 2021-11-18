﻿using System;

namespace MethodDemo
{
    class Program
    {
        static double Sum(double m, double n)
        {
            Console.WriteLine($"m is {m} and n is {n}");
            double total = m + n;
            return total;
        }


        static void Main(string[] args)
        {
            double x = 64.0;

            double y = Math.Sqrt(x);
            //We are passing into this function the VALUE that is stored in out variable named x.
            // Math.Sqrt = Square root

            Console.WriteLine(y);


            double z = Sum(5, 3);
            Console.WriteLine($"The sum is {z}");
        }
    }
}
