using System;

namespace Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 3, 6, 10, 6, 4 };
            int? balanceIndex = FindBalanceElement(array);
            Console.WriteLine(array[(int)balanceIndex]);
        }

        //<summary>
        //Finds an index of element in the  array of integers for
        //which the sum of the elements to the left of it is equal
        //to the sum of the elements on the right.
        //If such an index does not return null.  
        //</summary>
        static int? FindBalanceElement(int[] array)
        {
            if (array.Length == 0)
            {
                return null;
            }

            if (array.Length < 3)
            {
                return null;
            }

            int balanceIndex = 0;
            int leftSum = 0;

            for (int i = 1; i < array.Length; i++)
            {
                int rightSum = 0;

                for (int j = i - 1; j < array.Length; j++)
                {
                    if (j < i)
                    {
                        leftSum += array[j];
                    }
                    else if (j > i)
                    {
                        rightSum += array[j];
                    }
                }

                if (leftSum == rightSum)
                {
                    balanceIndex = i;
                    break;
                }
            }

            if (balanceIndex == 0)
            {
                return null;
            }

            return balanceIndex;
        }
    }
}
