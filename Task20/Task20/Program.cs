using System;

namespace Task20
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new[] { 1, 5, 33, 2, 65, 4, 15 };

            foreach (var element in array)
            {
                Console.Write($"{element} ");
            }

            Console.WriteLine("");

            BubbleSort(array);

            foreach (var element in array)
            {
                Console.Write($"{element} ");
            }
        }

        //<summary>
        //Implement bubble sort
        //</summary>
        static void BubbleSort(int[] array)
        {
            int tmp;

            for (int i = 1; i < array.Length; i++)
            {
                for (int j = array.Length - 1; j >= i; j--)
                {
                    if (array[j - 1] > array[j])
                    {
                        tmp = array[j - 1];
                        array[j - 1] = array[j];
                        array[j] = tmp;
                    }
                }
            }
        }
    }
}
