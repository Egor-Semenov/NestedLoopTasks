using System;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = GetSpiralMatrix(5);

            int rowCount = matrix.GetUpperBound(0) + 1;
            int columnCount = matrix.Length / (matrix.GetUpperBound(0) + 1);

            for (int row = 0; row < rowCount; row++)
            {
                for (int columnumn = 0; columnumn < columnCount; columnumn++)
                {
                    Console.Write($"{matrix[row, columnumn]} ");
                }

                Console.WriteLine("");
            }
        }

        //<summary>
        //Create a square matrix of order size with spiral elements.
        //
        //Spiral matrix - size = 3
        //
        //1 2 3  
        //8 9 4  
        //7 6 5  
        //</summary>
        static int[,] GetSpiralMatrix(int size)
        {
            if (size == 1)
            {
                int[,] trivialMatrix = new int[1, 1];
                trivialMatrix[0, 0] = 1;
                return trivialMatrix;
            }

            int[,] spiralMatrix = new int[size, size];
            int column = size;
            int detourCount = 0;
            int number = 1;

            while (Math.Round((double)column / 2) > 0)
            {
                for (int side = 0; side < 4; side++)
                {
                    for (int col = 0; col < column; col++)
                    {
                        if (side == 0 && col < column - detourCount)
                        {
                            spiralMatrix[side + detourCount, col + detourCount] = number;
                            number++;
                        }

                        if (col != 0)
                        {
                            if (side == 1 && col < column - detourCount)
                            {
                                spiralMatrix[col + detourCount, column - 1] = number;
                                number++;
                            }
                            else if (side == 2 && col < column - detourCount)
                            {
                                spiralMatrix[column - 1, column - (col + 1)] = number;
                                number++;
                            }
                            else if (side == 3 && col < column - (detourCount + 1))
                            {
                                spiralMatrix[column - (col + 1), detourCount] = number;
                                number++;
                            }
                        }
                    }
                }

                column--;
                detourCount++;
            }

            return spiralMatrix;
        }

    }
}
