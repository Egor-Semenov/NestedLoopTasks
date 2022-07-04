using System;
using System.Collections.Generic;
using System.Text;

namespace Task17
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 2212332, 0, 1405644, 12345, 1, -1236674, 123321, 1111111, 1236556321 };

            int[] result = FilterByPalindromic(array);

            foreach(var palidrom in result)
            {
                Console.WriteLine(palidrom);
            }
        }

        //<summary>
        //Takes an array of integers and filters it in such a way
        //that the output will be a new array consisting only of elements
        //that are palindromes.
        //If there are no such elements return an empty array.
        //</summary>
        public static int[] FilterByPalindromic(int[] source)
        {
            List<int> result = new List<int>();

            for (int index = 0; index < source.Length; index++)
            {
                int copyNumber = source[index];

                StringBuilder comparassingArray = new StringBuilder();

                while (copyNumber != 0)
                {
                    comparassingArray.Append(copyNumber % 10);
                    copyNumber /= 10;
                }

                int count = 0;

                for (int left = 0, right = comparassingArray.Length - 1; left < right; left++, right--)
                {
                    if (comparassingArray[left] == comparassingArray[right])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (count == comparassingArray.Length / 2)
                {
                    result.Add(source[index]);
                }
            }

            return result.ToArray();
        }
    }
}
