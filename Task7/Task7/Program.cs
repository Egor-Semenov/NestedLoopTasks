using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNumberSimpleFactors(68);
        }

        //<summary>
        //Вывести на экран, из каких простых множителей состоит введенное натуральное число.
        //</summary>
        static void PrintNumberSimpleFactors(int number)
        {
            if (IsSimple(number))
            {
                Console.WriteLine(number);
                return;
            }

            while (number != 1)
            {
                for (int numberFact = 2; numberFact <= number / 2; numberFact++)
                {
                    if (number % numberFact == 0 && IsSimple(numberFact))
                    {
                        Console.WriteLine(numberFact);
                        number = number / numberFact;
                        break;
                    }
                }

                if (IsSimple(number))
                {
                    Console.WriteLine(number);
                    return;
                }
            }
        }

        static bool IsSimple(int numberToCheck)
        {
            for (int checkSimple = 2; checkSimple <= numberToCheck / 2; checkSimple++)
            {
                if (numberToCheck % checkSimple == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
