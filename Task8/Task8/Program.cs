using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            FindPerfectNumbers(1000);
        }

        //<summary>
        //number is perfect, if the sum of its dividers, except itself, equals itself
        //examle: 6
        //1 + 2 + 3 = 6
        //</summary>
        static void FindPerfectNumbers(int range)
        {
            int dividersSum;
            for (int checkNumber = 1; checkNumber <= range; checkNumber++)
            {
                dividersSum = 1;

                for (int checkDivider = 2; checkDivider <= checkNumber / 2; checkDivider++)
                {
                    if (checkNumber % checkDivider == 0)
                    {
                        dividersSum += checkDivider;
                    }
                }

                if (dividersSum == checkNumber)
                {
                    Console.WriteLine(checkNumber);
                }
            }
        }
    }
}
