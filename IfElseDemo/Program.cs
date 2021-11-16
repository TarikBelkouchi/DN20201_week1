using System;

namespace IfElseDemo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Some basic comparisons i.e less than, less than or equal, greater than or equal, equal, not equal.

            int x = 10;
            int y = 5;

            // if (x > y)
            // {
            //Console.WriteLine("x is indeed greater than y.");//Sort of an answer to the question "Is x greater than y)
            //Console.WriteLine("The expression x > y is true.");// More a response to the the statement
            //}
            //if (y > x)
            {
                //If the expression evaluates to true, this code will run.
                // Console.WriteLine("y > x is true");
            }
            // else
            {
                //If the expression evaluates as false, this code will run.
                //   Console.WriteLine("the expression y < x is false");

            }
            //int size = 649;

            //&& means and in C#

            //if (size >= 1 && size <= 250)
            //{
            // Console.WriteLine("Small room");
            // }
            // if (size > 250 && size < 650)
            //{
            // Console.WriteLine("Medium room");
            //}
            //if (size >= 650)
            // {
            // //Console.WriteLine("Large room");
            //}

            int size = 700;

            if (size >= 1 && size <= 250)
            {
                Console.WriteLine("Small Room");
            }
            else if (size > 250 && size < 650)
            {
                Console.WriteLine("Medium Room");
            }
            else
            {
                Console.WriteLine("Large Room");
            }
            Console.WriteLine("All done!");
        }
    }
}
