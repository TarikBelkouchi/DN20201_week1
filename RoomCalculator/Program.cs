using System;

namespace RoomCalculator
    {
        class MainClass
    {
            public static void Main(string[] args)
            {

                Console.WriteLine("Welcome to Grand Circus’ Room Detail Generator!");

                Console.WriteLine("Enter Length:");
                string length1 = Console.ReadLine();

                double length = double.Parse(length1);


                Console.WriteLine("Enter Width:");
                string width1 = Console.ReadLine();

                double width = double.Parse(width1);


                double area = width * length;

                double perimeter = 2 * width + 2 * length;

                double volume = length * width * 10;

                double surfaceArea = 2 * (width * length + 10 * length + 10 * width);



                Console.WriteLine("The area of your room is");
                Console.WriteLine(area);
                Console.WriteLine("The perimeter of your room is");
                Console.WriteLine(perimeter);
                Console.WriteLine("The volume of a 10 ft room is");
                Console.WriteLine(volume);
                Console.WriteLine("The surface area of a 10 ft room is");
                Console.WriteLine(surfaceArea);

                string size;

                if (area <= 250)
                {
                    size = "small";
                }
                else if (area <= 650)
                {
                    size = "medium";
                }
                else
                {
                    size = "large";
                }

                Console.WriteLine("The size of your room is");
                Console.WriteLine(size);


                Console.WriteLine("Thank you for using the Room Detail Generator!");




            }
        }
    }

