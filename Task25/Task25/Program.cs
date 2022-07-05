using System;

namespace Task25
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] array = new[] { new[] { 10, 10, 1, 100, 1 }, new[] { 1, 2, 21, 3 }, new[] { 1, 2, 3 }, new[] { 10, 1, 1, 1, 1 }, new[] { 90 } };

            foreach (var row in array)
            {
                foreach (var element in row)
                {
                    Console.Write($"{element} ");
                }

                Console.WriteLine("");
            }

            Console.WriteLine("");

            OrderByAscendingByMax(array);

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
        //by ascending of the maximum of the elements in them.
        //</summary>
        static void OrderByAscendingByMax(int[][] source)
        {
            int firstMax;
            int secondMax;

            for (int i = 0; i < source.GetUpperBound(0); i++)
            {
                for (int j = 0; j < source.GetUpperBound(0) - i; j++)
                {
                    firstMax = int.MinValue;
                    secondMax = int.MinValue;

                    if (source[j] != null)
                    {
                        for (int column = 0; column < source[j].Length; column++)
                        {
                            if (source[j][column] > firstMax)
                            {
                                firstMax = source[j][column];
                            }
                        }
                    }

                    if (source[j + 1] != null)
                    {
                        for (int column = 0; column < source[j + 1].Length; column++)
                        {
                            if (source[j + 1][column] > firstMax)
                            {
                                secondMax = source[j + 1][column];
                            }
                        }
                    }

                    if (firstMax > secondMax)
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
