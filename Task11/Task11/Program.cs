using System;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myMatrix = new int[,] { { 15, 35, 4 }, { 78, 111, 45 }, { 1, 15, 2 } };
            int count = CountTwoDigitNumbers(myMatrix);

            Console.WriteLine(count);
        }

        //<summary>
        //Посчитать количество двузначных чисел в матрице
        //</summary>
        static int CountTwoDigitNumbers(int[,] matrix)
        {
            int totalCount = 0;

            int rowCount = matrix.GetUpperBound(0) + 1;
            int columnCount = matrix.Length / (matrix.GetUpperBound(0) + 1);

            for (int row = 0; row < rowCount; row++)
            {
                for (int column = 0; column < columnCount; column++)
                {
                    if (matrix[row,column] >= 10 && matrix[row,column] <=99)
                    {
                        totalCount++;
                    }
                }
            }

            return totalCount;
        }
    }
}
