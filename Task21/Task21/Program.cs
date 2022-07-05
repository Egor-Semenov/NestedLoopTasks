using System;
using System.Linq;

namespace Task21
{
    static class Program
    {
        static void Main(string[] args)
        {
            int[] array = new[] { 1, 111, 45, 85, 2, 14, 26 };
            array.ToList()
                .ForEach(element => Console.Write($"{element} "));

            Console.WriteLine("");

            array.SelectionSort();
            array.ToList()
                .ForEach(element => Console.Write($"{element} "));
        }

        //<summary>
        //Implement selection sort
        //</summary>
        static void SelectionSort(this int[] array)
        {
            int minElementIndex;

            for (int currentIndex = 0; currentIndex < array.Length - 1; currentIndex++)
            {
                minElementIndex = currentIndex;

                for (int nextIndex = currentIndex + 1; nextIndex < array.Length; nextIndex++)
                {
                    if (array[minElementIndex] > array[nextIndex])
                    {
                        minElementIndex = nextIndex;
                    }
                }

                if (minElementIndex != currentIndex)
                {
                    int tmp = array[minElementIndex];
                    array[minElementIndex] = array[currentIndex];
                    array[currentIndex] = tmp;
                }
            }
        }
    }
}
