using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dag4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddSeparator("didjdiojwo", "-"));
            Console.WriteLine(IsPalindrome("hallo"));
            Console.WriteLine(StringInReverseOrder("hallo"));

            Console.ReadLine();

        }

        static string AddSeparator(string word, string sep)
        {
            string Word1 = string.Empty;
            for (int i = 0; i < word.Length; i++)
            {
                Word1 += i < word.Length - 1 ? word[i] + sep : word[i].ToString();
            }
            return Word1;
        }

        static bool IsPalindrome(string word)
        {
            string reverseString = string.Empty;

            foreach (char c in word)
            {
                reverseString = c + reverseString;
            }

            if (reverseString == word) 
            {
                return true;
            }
            return false;

        }

        static string StringInReverseOrder(string word)
        {
            string reverseString = string.Empty;

            foreach (char c in word)
            {
                reverseString = c + reverseString;
            }
            return reverseString;
        }

        static string RevertWordsOrder(string word)
        {

        }
    }
}
