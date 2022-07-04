using System;

namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            FindArmstrongNumbers(10000);
        }

        //<summary>
        //Найти числа Армстронга в указанном диапазоне
        //Число Армстронга - это число, равное сумме своих цифр, возведённых в степень, равную количеству его цифр
        //</summary>
        static void FindArmstrongNumbers(int range)
        {
            for (int number = 1; number <= range; number++)
            {
                int countOfDigits = 0;
                int numberCopy = number;

                while(numberCopy != 0)
                {
                    countOfDigits++;
                    numberCopy = numberCopy / 10;
                }

                int checkArmstrong = number;
                double digitSum = 0;

                while(checkArmstrong != 0)
                {
                    digitSum += Math.Pow(checkArmstrong % 10, countOfDigits);
                    checkArmstrong = checkArmstrong / 10;
                }

                if (digitSum == number)
                {
                    Console.Write($"{number} ");
                }
            }
        }
    }
}
