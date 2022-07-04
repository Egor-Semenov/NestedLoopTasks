using System;
using System.Linq;

namespace Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 0, 0, 1, 8, 9, 1, 4 };

            array.ToList()
                .ForEach(element => Console.Write($"{element} "));

            Console.WriteLine("");

            MoveToTail(array, 1);

            array.ToList()
                .ForEach(element => Console.Write($"{element} "));
        }

        //<summary>
        //moves all the elements of an integer array by the specified value to the end,
        //while maintaining the order of other elements.
        //{1, 2, 0, 1, 0, 1, 0, 3, 0, 1} for value = 0 =>  {1, 2, 1, 1, 3, 1, 0, 0, 0, 0} 
        //</summary>
        static void MoveToTail(int[] source, int value)
        {
            int length = source.Length;

            for (int index = 0; index < length; index++)
            {
                if (source[index] == value)
                {
                    for (int replaceIndex = index; replaceIndex < source.Length - 1; replaceIndex++)
                    {
                        source[replaceIndex] = source[replaceIndex + 1];
                    }

                    source[^1] = value;

                    index--;
                    length--;
                }
            }
        }
    }
}
