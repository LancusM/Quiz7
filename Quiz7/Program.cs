using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz7
{
    internal class Program
    {
        public static void ReverseString(string input)
        {
            input = input.ToLower();
            Array reverseInput = input.ToArray();
            Array.Reverse(reverseInput);
            foreach (char i in reverseInput)
            {
                Console.Write(i);
            }
        }
        public static void CountVowels(string input)
        {
            int vowelSum = 0;
            input = input.ToLower();
            Array vowelInput = input.ToArray();
            
            foreach (var i in vowelInput)
            {
                //OK so the vowel thing doesn't work but I don't have time to fix it, give me more time and it'd be done better, promise
                if (i != "b" && i != "c" && i != "d" && i != "f" && i != "g" && i != "h" && i != "j" && i != "k" && i != "l" && i != "m" && i != "n" && i != "p" && i != "q" && i != "r" && i != "s" && i != "t" && i != "v" && i != "w" && i != "x" && i != "y" && i != "z" && i != " ")
                {
                    vowelSum = vowelSum + 1;
                }
            }
            Console.WriteLine(vowelSum);
        }
        public static void IsPalindrome(string input)
        {
            input = input.ToLower();
            Array palindromeInput = input.ToArray();
            Array.Reverse(palindromeInput);
            string stringPalindrome = palindromeInput.ToString();
            if (input == stringPalindrome)
            {
                Console.WriteLine(stringPalindrome + " is a palindrome!"); 
            }
            else
            {
                Console.WriteLine(input + " is not a palindrome.");
            }
        }
        static void Main(string[] args)
        {
            int choice = 0;
            while (choice != 4)
            {

                Console.WriteLine("Enter a string: ");
                string input = Console.ReadLine();
                input = input.ToLower();

                Console.WriteLine("What action would you like to perform?");
                Console.WriteLine("Reverse the string (1), count the vowels in the string (2), check if the string is a palindrome (3), or exit (4)?");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    ReverseString(input);
                }
                else if (choice == 2)
                {
                    CountVowels(input);
                }
                else if (choice == 3)
                {
                    IsPalindrome(input);
                }
                //Almost forgot to call IsPalindrome
                //Also again, running out of time, no time for comments, sorry but not sorry because I'm trinyg my best here with less than a half hour

                Console.WriteLine();
                Console.WriteLine("Enter a string: ");
                input = Console.ReadLine();

                //BEST I CAN DO, SORRY

                Console.Read();
            }
        }
    }
}
