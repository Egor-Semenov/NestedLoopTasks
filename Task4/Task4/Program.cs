using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = FindDigitCount(new int[] { 11, 28, 3, 15, 24, 72, 36, 2, 22 }, 2);
            Console.WriteLine(result);
        }

        //<summary>
        //Find count of digit in numbers in array
        //example:
        //[11, 8, 15, 21]
        //digit: 1
        //result: 4
        //<summary>

        static int FindDigitCount(int[] searchArray, int digitToFind)
        {
            int totalCount = 0;

            for (int arrayIndex = 0; arrayIndex < searchArray.Length; arrayIndex++)
            {
                int number = searchArray[arrayIndex];
                while (number != 0)
                {
                    if (number % 10 == digitToFind)
                    {
                        totalCount++;
                    }

                    number /= 10;
                }
            }

            return totalCount;
        }
    }
}
