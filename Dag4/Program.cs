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
            int[] arr = new int[] { };
            arr = SortCharactersDescending(new int[] { 1, 2, 3, 4 });
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

            Console.WriteLine(LengthOfAString("dhd hdhd dkhd"));
            Console.ReadLine();


        }

        static int[] SortCharactersDescending(int[] numbers)
        {
            Array.Reverse(numbers);
                return numbers;
        }

        static int LengthOfAString(string input)
        {
            GetLength(input);
            CountWords(input); 
            return input.Length;

            int GetLength(string input1)
            {
                int output = 0;
                foreach (char c in input1)
                {
                    output = output + 1;



                }
                return output;
            }
            int CountWords(string input2)
            {
                int output = 0;
                input = input.Trim();
                foreach (char b in input2)
                {

                    if (b == ' ')
                    {
                        output++;
                    }

                }
                return output + 1;
            }
        }
    }
}
