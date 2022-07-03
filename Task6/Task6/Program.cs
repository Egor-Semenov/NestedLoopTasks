using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            FindDividers(12, 24, 2);
        }

        //<summary>
        //В введенном промежутке натуральных чисел найти те,
        //количество делителей у которых не меньше введенного значения.
        //Для найденных чисел вывести на экран число делителей и  все делители.
        //</summary>
        static void FindDividers(int startValue, int endValue, int neededCount)
        {
            int currentDividersCount;
            while (startValue <= endValue)
            {
                currentDividersCount = 0;

                for (int dividerValue = 1; dividerValue <= startValue / 2; dividerValue++)
                {
                    if (startValue % dividerValue == 0)
                    {
                        currentDividersCount++;
                    }
                }

                if (currentDividersCount >= neededCount)
                {
                    Console.Write($"{startValue} - {currentDividersCount} - ");

                    for (int dividerValue = 1; dividerValue <= startValue / 2; dividerValue++)
                    {
                        if (startValue % dividerValue == 0)
                        {
                            Console.Write($"{dividerValue} ");
                        }
                    }

                    Console.Write($"{startValue}\n");
                }

                startValue++;
            }

        }
    }
}
