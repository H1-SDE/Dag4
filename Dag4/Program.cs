﻿using System;
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
            Console.WriteLine(RevertWordsOrder("hallo hallo1- hallo2, hallo3."));
            Console.WriteLine(HowManyOccurrences("do it now", "do"));
            Console.WriteLine(HowManyOccurrences("empty", "d"));

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
            string[] halfReverseString = word.Split(' ');
            string reverseString = string.Empty;
            foreach (var word1 in halfReverseString)
            {
                reverseString = word1 + " " + reverseString;
            }
            return reverseString;
        }

        static int HowManyOccurrences(string words, string word2)
        {
            string[] halfReverseString = words.Split(' ');
            int numberOfTimes = 0;
            foreach (var word in halfReverseString)
            {
                if(word == word2)
                {
                    numberOfTimes++;
                }
            }
            return numberOfTimes;
        }
    }
} 
