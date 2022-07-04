using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[,] { { 11, 25, 30 }, { 47, 52, 63}, { 78, 81, 90 }, { 18, 29, 13 } };
            PrintMatrix(matrix);
            Console.WriteLine("");
            FindColumnsSum(matrix);
        }

        //<summary>
        //Задана матрица неотрицательных чисел.
        //Посчитать сумму элементов в каждом столбце.
        //</summary>
        static void FindColumnsSum(int[,] matrix)
        {
            int rowCount = matrix.GetUpperBound(0) + 1;
            int columnCount = matrix.Length / (matrix.GetUpperBound(0) + 1);

            int columnSum;

            for (int column = 0; column < columnCount; column++)
            {
                columnSum = 0;

                for (int row = 0; row < rowCount; row++)
                {
                    columnSum += matrix[row, column];
                }

                Console.Write($"{columnSum} ");
            }
        }

        static void PrintMatrix(int[,] matrix)
        {
            int rowCount = matrix.GetUpperBound(0) + 1;
            int columnCount = matrix.Length / (matrix.GetUpperBound(0) + 1);

            for (int row = 0; row < rowCount; row++)
            {
                for (int column = 0; column < columnCount; column++) 
                {
                    Console.Write($"{matrix[row, column]} ");
                }

                Console.WriteLine("");
            }
        }
    }
}
