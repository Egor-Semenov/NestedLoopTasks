using System;
using System.Linq;

namespace Task23
{
    static class Program
    {
        static void Main(string[] args)
        {
            int[] array = new[] { 1, 111, 45, 85, 2, 14, 26 };
            array.ToList()
                .ForEach(element => Console.Write($"{element} "));

            Console.WriteLine("");

            array.QuickSort();
            array.ToList()
                .ForEach(element => Console.Write($"{element} "));
        }

        //<summary>
        //Implement quick sort
        //</summary>
        static void QuickSort(this int[] array)
        {
            if (array.Length < 2)
            {
                return;
            }

            int right = array.Length - 1;
            int left = 0;
            int[] stack = new int[right - left + 1];

            int top = -1;

            stack[++top] = left;
            stack[++top] = right;

            while (top >= 0)
            {
                right = stack[top--];
                left = stack[top--];

                int position = Partitioning(array, left, right);

                if (position - 1 > left)
                {
                    stack[++top] = left;
                    stack[++top] = position - 1;
                }

                if (position + 1 < right)
                {
                    stack[++top] = position + 1;
                    stack[++top] = right;
                }
            }
        }

        static int Partitioning(int[] array, int left, int right)
        {
            int tmp;
            int baseFoundation = array[right];

            int smallerElementIndex = left - 1;
            for (int index = left; index <= right - 1; index++)
            {
                if (array[index] <= baseFoundation)
                {
                    smallerElementIndex++;

                    tmp = array[smallerElementIndex];
                    array[smallerElementIndex] = array[index];
                    array[index] = tmp;
                }
            }

            tmp = array[smallerElementIndex + 1];
            array[smallerElementIndex + 1] = array[right];
            array[right] = tmp;

            return smallerElementIndex + 1;
        }
    }
}
