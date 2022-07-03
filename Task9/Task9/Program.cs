using System;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintRectangle(20, 10, '#', '*');
        }

        //<summary>
        //Вывести на экран «прямоугольник», образованный из двух видов символов.
        //Контур прямоугольника должен состоять из одного символа, а в «заливка» — из другого.
        //</summary>

        static void PrintRectangle(int length, int width, char outSideCharacter, char inSideCharacter)
        {
            for (int row = 1; row <= length; row++)
            {
                if (row == 1 || row == length)
                {
                    for (int column = 1; column <= width; column++)
                    {
                        Console.Write($"{outSideCharacter}");
                    }
                }
                else
                {
                    Console.Write($"{outSideCharacter}");

                    for (int column = 2; column < width; column++)
                    {
                        Console.Write($"{inSideCharacter}");
                    }

                    Console.Write($"{outSideCharacter}");
                }

                Console.WriteLine("");
            }
        }
    }
}
