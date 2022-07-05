using System;
using System.Linq;

namespace Task22
{
    static class Program
    {
        static void Main(string[] args)
        {
            int[] array = new[] { 1, 111, 45, 85, 2, 14, 26 };
            array.ToList()
                .ForEach(element => Console.Write($"{element} "));

            Console.WriteLine("");

            array.InsertionSort();
            array.ToList()
                .ForEach(element => Console.Write($"{element} "));
        }

        //<summary>
        //Implement insertion sort
        //</summary>
        static void InsertionSort(this int[] array)
        {
            int tmp;

            for (int i = 0; i < array.Length; i++)
            {
                tmp = array[i];

                for (int j = i - 1; j >= 0; j--)
                {
                    if (array[j] < tmp)
                    {
                        break;
                    }

                    array[j + 1] = array[j];
                    array[j] = tmp;
                }
            }
        }
    }
}
