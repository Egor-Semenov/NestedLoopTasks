using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            FindSimple(new int[] { 1, 5, 9, 11, 17, 103 });
        }

        //<summary>
        //Find simple numbers in array
        //Simple number is divided only by itself and 1
        //example: 2,3,5,7...
        //</summary>
        static void FindSimple(int[] array)
        {
            bool simple;
            for (int index = 0; index < array.Length; index++)
            {
                if (array[index] == 1)
                {
                    continue;
                }

                simple = true;

                for (int checkSimple = 2; checkSimple < array[index]; checkSimple++)
                {
                    if (array[index] % checkSimple == 0)
                    {
                        simple = false;
                        break;
                    }
                }

                if (simple)
                {
                    Console.WriteLine(array[index]);
                }
            }
        }
    }
}
