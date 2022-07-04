using System;
using System.Collections.Generic;
using System.Linq;

namespace Task16
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 12, 32, 5, 4, 24, 22, 82, 9, 74 };
            List<int> result = FilterByDigit(array, 2);

            result.ForEach(element => Console.WriteLine(element));
        }

        //<summary>
        //Obtains an array of integers whose elements contain a given digit.
        //{ 1, 2, 3, 4, 5, 6, 7, 68, 69, 70, 15, 17 } => { 7, 70, 17 } for digit = 7.
        //</summary>
        static List<int> FilterByDigit(int[] source, int digit)
        {
            List<int> result = new List<int>();

            for (int index = 0; index < source.Length; index++)
            {
                if (source[index] == 0 && digit == 0)
                {
                    result.Add(0);
                    continue;
                }

                int copyNumber = source[index];

                while (copyNumber != 0)
                {
                    if (copyNumber % 10 == digit || copyNumber % 10 == -digit)
                    {
                        result.Add(source[index]);
                        break;
                    }

                    copyNumber /= 10;
                }
            }

            return result;
        }
    }
}
