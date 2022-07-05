using System;

namespace Task24
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] array = new[] { new[] { 2, -40, 55 }, new[] { 1 }, new[] { 1, 1 }};

            foreach (var row in array)
            {
                foreach (var element in row)
                {
                    Console.Write($"{element} ");
                }

                Console.WriteLine("");
            }

            Console.WriteLine("");

            OrderByAscendingBySum(array);

            foreach (var row in array)
            {
                foreach (var element in row)
                {
                    Console.Write($"{element} ");
                }

                Console.WriteLine("");
            }
        }

        //<summary>
        //Implement method that orders the rows in a jagged-array
        //by ascending of the sum of the elements in them.
        //</summary>
        static void OrderByAscendingBySum(int[][] source)
        {
            int firstSum;
            int secondSum;

            for (int i = 0; i < source.GetUpperBound(0); i++)
            {
                for (int j = 0; j < source.GetUpperBound(0) - i; j++)
                {
                    firstSum = 0;
                    secondSum = 0;

                    if (source[j] != null)
                    {
                        for (int column = 0; column < source[j].Length; column++)
                        {
                            firstSum += source[j][column];
                        }
                    }

                    if (source[j + 1] != null)
                    {
                        for (int column = 0; column < source[j + 1].Length; column++)
                        {
                            secondSum += source[j + 1][column];
                        }
                    }

                    if (firstSum > secondSum)
                    {
                        int[] tmp = source[j];

                        if (source[j + 1] == null)
                        {
                            source[j] = null;
                        }

                        source[j] = source[j + 1];
                        source[j + 1] = tmp;
                    }
                }
            }
        }
    }
}
