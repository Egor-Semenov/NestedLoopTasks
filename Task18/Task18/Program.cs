using System;

namespace Task18
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[,] { { 11, 12, 13, 14 }, { 21, 22, 23, 24 }, { 31, 32, 33, 34 }, { 41, 42, 43, 44 } };
            for (int row  = 0; row < matrix.GetUpperBound(0) + 1; row++)
            {
                for (int column = 0; column < matrix.Length / (matrix.GetUpperBound(0) + 1); column++)
                {
                    Console.Write($"{matrix[row, column]} ");
                }

                Console.WriteLine("");
            }

            Console.WriteLine("");

            Rotate(matrix);

            for (int row = 0; row < matrix.GetUpperBound(0) + 1; row++)
            {
                for (int column = 0; column < matrix.Length / (matrix.GetUpperBound(0) + 1); column++)
                {
                    Console.Write($"{matrix[row, column]} ");
                }

                Console.WriteLine("");
            }
        }

        //<summary>
        //Given an image represented by an n x n matrix
        //Implement that rotates the image clockwise by 90° (do it in place).
        //</summary>
        static void Rotate(int[,] matrix)
        {
            for (int upRow = 0, lowRow = matrix.GetUpperBound(0); upRow < lowRow; upRow++, lowRow--)
            {
                for (int column = 0; column < matrix.GetUpperBound(0) + 1; column++)
                {
                    int tmp = matrix[upRow, column];
                    matrix[upRow, column] = matrix[lowRow, column];
                    matrix[lowRow, column] = tmp;
                }
            }

            for (int i = 0; i < matrix.GetUpperBound(0); i++)
            {
                for (int j = i + 1; j < matrix.GetUpperBound(0) + 1; j++)
                {
                    int tmp = matrix[i, j];
                    matrix[i, j] = matrix[j, i];
                    matrix[j, i] = tmp;
                }
            }

        }
    }
}
