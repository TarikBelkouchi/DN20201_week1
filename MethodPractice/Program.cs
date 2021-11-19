using System;

namespace MethodPractice
{
    class MainClass
    {
        public static void ShowHelp()
        {
            Console.WriteLine("Welcome to the program.");
            Console.WriteLine("Please choose an option.");
            Console.WriteLine("When you are done you can click N.");

        }

        public static string GetFullName(string FirstName, string LastName)
        {
            return FirstName + " " + LastName;
        }

        public static string GetFirstLetter(string word)
        {
            char first = word[0];
            return first.ToString();
        }

        public static string GetLastLetter(string word)
        {
            int index = word.Length - 1;
            char last = word[index];
            return last.ToString();
        }

        public static string GetLastTwo(string word)
        {
            int index = word.Length - 2;
            string last2 = word.Substring(index, 2);
            return last2;
        }

        public static bool EndsWithABC(string word)
        {
            string last = GetLastLetter(word).ToLower();
            if (last == "a" || last == "b" || last == "c")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool EndsWithING(string word)
        {
            string last3 = word.Substring(word.Length - 3).ToLower();
            if (last3 == "ing")
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public static bool StartsWithVowel(string word)
        {
            char first = word[0];
            if (first == 'a' || first == 'e' || first == 'i' || first == 'o' || first == 'u')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //check if first letter is a vowel
        //Notice the character

        public static bool IsVowel(char letter)
        {

                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        public static string PigLatin(string word)
        {
            // Put your pig latin conversion in here

            string platin = word;
            return platin;
        }




        public static void Main(string[] args)
        {
            ShowHelp();
            //ShowHelp();
            //Above you can can seee that "ShowHelp" is a function with the 3 lines of write. when typing it  twice you get the 3 lines twice!

            string fullname = GetFullName("Sally", "Smith");
            Console.WriteLine(fullname);

            string anothername = GetFullName("Fred", "Franklin");
            Console.WriteLine(anothername);

            string firstletter = GetFirstLetter("Hello");
            Console.WriteLine(firstletter);

            string yetAnother = GetFullName("Jim", "Johnson");
            Console.WriteLine(yetAnother);


            string last = GetLastLetter("Hello");
            Console.WriteLine(last);

            Console.WriteLine("Substring practice");
            string myword = "progamming";
            Console.WriteLine(myword.Substring(4, 5));
            Console.WriteLine(myword.Substring(0,2));
            Console.WriteLine(GetLastTwo(myword));

            Console.WriteLine(GetLastTwo("Hello World!"));

            Console.WriteLine("Let's test the EndsWithABC!");
            Console.WriteLine(EndsWithABC("Hello")); //expect false
            Console.WriteLine(EndsWithABC("pizza")); //expect true
            Console.WriteLine(EndsWithABC("PIZZA"));//expect trie

            Console.WriteLine("Let's test the endswithING function");
            Console.WriteLine(EndsWithING("walking"));//expect true
            Console.WriteLine(EndsWithING("walkING"));//expect true
            Console.WriteLine(EndsWithING("walkin"));//expect false
            Console.WriteLine(EndsWithING("walkng"));//expect false

            string letters = " ";
            for (int i = 0; i <= 10; i++)
            {
                letters += 'x';
                 
            }

            string test = "christmas";
            int firstVowel = -1;
            for (int i = 0; i < test.Length; i++)
            {
                if (IsVowel(test[i]))
                {
                    firstVowel = i;
                    break;
                }
            }


        }
    }
}
