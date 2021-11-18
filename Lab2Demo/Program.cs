using System;

namespace Lab2Demo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("First text");
            //Console.Write("2nd text");
            //Console.Write("3rd text");
            //Console.WriteLine("/n4th text");
            // Console.Write will continue the next command on the same line as opposed to Console.WriteLine will start a new line after text.
            //  \n will give you a new line at beggining of text


            Console.WriteLine("Please enter a number between 1 and 100.");
            string entry = Console.ReadLine();
            int num = int.Parse(entry);
            Console.WriteLine($"You entered:\t{entry}.\n\n");
            // \t will give you a tab


            if (num % 2 == 1 && num < 60)
            {
                Console.WriteLine($"{ num} Odd and less than 60");
                //When you put $ before quotes in a writeline you can add a variable into the text.
            }
            else if (num % 2 == 0 && num >= 2 && num <= 24)
            {
                Console.WriteLine($"{num}) is even and less than 25");
            }
            else if (num % 2 == 0 && num >= 26 && num <= 60)
            {
                Console.WriteLine($"{ num} is even and between 26 and 6 inclusive.");
            }

            else if (num % 2 == 0 && num > 60)
            {
                Console.WriteLine($"{num} is even and greater than 60");
            }
            else if (num % 2 == 1 && num > 60)
            {
                Console.WriteLine($"{num} is odd and greater than 60.");
            }
            // " var % 2 == 1 " is how you find if number is odd.
            // " var % 2 == 0 " is how you find if numbner is even.






            //Version 2

            Console.WriteLine("Here's Version 2.");

            if (num % 2 == 1)
            {
                
                if (num < 60)
                {
                    Console.WriteLine($"{num} is odd and less than 60.");
                }
                else
                {
                    Console.WriteLine($"{num} is even and greater than 60.");
                }
            }
            else
            {
                if (num >= 2 && num <= 24)
                {
                    Console.WriteLine($"{num} is even and less than 25.");
                }
                else if (num >= 26 && num <= 60)
                {
                    Console.WriteLine($"{num} is even and between 26 and 60 inclusive.");
                }
                else
                {
                    Console.WriteLine($"{num} is odd and greater than 60.");
                }
                //command + and / will not "//" highlighted area.
            }
        }
    }
}
