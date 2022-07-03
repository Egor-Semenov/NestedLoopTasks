using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMultiplicationTable(9);
        }

        //<summary>
        //Print multiplication table
        //<summary>

        static void PrintMultiplicationTable(int tableSize)
        {
            for (int firstFactor = 1; firstFactor <= tableSize; firstFactor++)
            {
                for (int secondFactor = 1; secondFactor <= tableSize; secondFactor++)
                {
                    Console.Write(firstFactor * secondFactor + "  ");
                }

                Console.WriteLine("");
            }
        }
    }
}
