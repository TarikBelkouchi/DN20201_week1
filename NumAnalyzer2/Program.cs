using System;

namespace NumAnalyzer2
{
    class Program
    {

        static bool IsOddUnder60(int num)
        {
            //Checking the expression for the either true or false
            if (num % 2 == 1 && num < 60)
            {
                //When the expression comes back true, return true
                return true;
            }
            else
            {
                //When the expression comes back false, return false
                return false;

            }
        }

        static bool IsOddOver60(int num)
        {
            //Really, we're just returning exactly waht we got back
            //from the expression. So why not just return exactly
            //what we got back?
            if (num % 2 == 1 && num > 60)
            {
                return true;
            }
            else
            {
                return false;

            }
        }

        public static void Main(string[] args)

        {
            int x = 61;
            if ( IsOddUnder60 (x) == true)
            {
                Console.WriteLine($"{x} is odd under 60.");
            }
            else if (IsOddOver60(x) == true)
            {
                Console.WriteLine($"{x} is odd over 60.");
            }

        }
    }
}
