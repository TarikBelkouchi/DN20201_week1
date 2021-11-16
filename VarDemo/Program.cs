using System;

namespace VarDemo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //CODE NOTES DAY 1 - NOVEMBER 15TH 2021

            //Console.WriteLine("Hello\"World!");
            //Console.WriteLine("This is a second line of text!");

            string message = "Hello World";
            Console.WriteLine(message);

            int AppleCount = 25;
            Console.WriteLine(AppleCount);
            Console.WriteLine(AppleCount + 1);
            Console.WriteLine(AppleCount);

            AppleCount = AppleCount + 10;
            Console.WriteLine(AppleCount);

            AppleCount = AppleCount * 2;
            Console.WriteLine(AppleCount);

            double x = 3.14;
            Console.WriteLine(x);

            //float y = 6.28f; (we don't use float to much in this course but when it's recognized as a double add an f to the end.)

            double z = 20.0 / 3.0;
            Console.WriteLine(z);

            //We don't use float or double for money and financial problems.
            //Instead use decimal
            decimal balance = 100.2512345m;
            Console.WriteLine(balance);

            bool atLunch = false;
            Console.WriteLine(atLunch);
            atLunch = true;
            Console.WriteLine(atLunch);

            //null as in no shopping list at all, so we can write on it
            string test = null;
            Console.WriteLine(test);

            //practice noun dot verb.
            Console.WriteLine(message.Length);
            Console.WriteLine(message.ToUpper());// strings are imutable(unchangeable)
            Console.WriteLine(message);
            message = "something else";
            Console.WriteLine(message);


            //More noun dot verbs. This time with types themselves
            string nums = "37";
            int amount = int.Parse(nums);
            Console.WriteLine(amount*2);

            //\n = shrortcut for new line
            Console.WriteLine("\nEnter an interger.");
            string entry = Console.ReadLine();
            int value = int.Parse(entry);
            Console.WriteLine(value*20);


            Console.WriteLine("Hello! Welcome to the Room Calculator!");

            Console.WriteLine("First off what is the length of the room?");
            string length1 = Console.ReadLine();

            int length = int.Parse(length1);


            Console.WriteLine("Second, what is the Width of the room?");
            string width1 = Console.ReadLine();

            int width = int.Parse(width1);


            int area = width * length;
            Console.WriteLine("The area of your room is area");
            


        }
    }
}




