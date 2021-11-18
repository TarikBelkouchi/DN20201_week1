using System;

namespace ExponentsPowerTable
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Learn your squares and cubes!");
            Console.WriteLine("Enter an integer: ");

            string entered = Console.ReadLine();
            int stopPoint = int.Parse(entered);

            Console.WriteLine("Number \t Squared \t Cubed");

            int num1 = 0;
            num1++;

            int squared = (num1 * num1);

            while (num1 <= 100)
            {
                Console.WriteLine($"{num1} \t {num1} \t\t {squared}");

                if (num1 == stopPoint)
                {

                    
                 break;
                }
                num1++;
            }

           

            
            
        }
    }
}
