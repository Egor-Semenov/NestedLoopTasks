using System;
using System.Collections.Generic;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = FindMaxDigitSumNumbers(new int[] { 11, 5, 39, 44, 86, 799 });
            Console.WriteLine(result);
        }

        //<summary>
        //Find number with the max sum of digits
        //</summary>
        static int FindMaxDigitSumNumbers(int[] array)
        {
            int maxSum = 0;
            int maxSumNumber = 0;

            int temparateSum;
            int number;
            foreach (var element in array)
            {
                temparateSum = 0;
                number = element;

                while (number != 0)
                {
                    temparateSum += number % 10;
                    number = number / 10;
                }

                if (temparateSum > maxSum)
                {
                    maxSum = temparateSum;
                    maxSumNumber = element;
                }
            }

            return maxSumNumber;
        }
    }

}
