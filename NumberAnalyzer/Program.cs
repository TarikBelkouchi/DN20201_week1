using System;

namespace NumberAnalyzer
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Number Analyzer!");
            Console.WriteLine("First off, what is your name?");
            string Name = Console.ReadLine();
            Console.WriteLine( Name + ", Please provide me with a whole number between 1 - 100");

            string Number = Console.ReadLine();

            int num = int.Parse(Number);



            if (num % 2 == 0)
            {
                Console.WriteLine(Name + ", your number is even.");
   }
            else
            {
                Console.WriteLine(Name + ", your number is odd.");

            }


            if (num < 60 && num > 24)
            {
                Console.WriteLine("and  is also less than 60.");
            }

            if (num > 1 && num < 25)
            {
                Console.WriteLine("and is also less than 25.");

            }
            if (num > 60)
            {
                Console.WriteLine("and is also greater than 60.");
            }

        }





            

        }
    }

