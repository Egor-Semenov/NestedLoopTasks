using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintPattern(10);
        }
       
        //<summary>
        //Print pattern
        //*
        //**
        //***
        //****
        //***
        //**
        //*
        //</summary>

        static void PrintPattern(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");
            }

            for (int i = size - 1; i > 0; i--)
            {
                for (int j = size - 1; j >= size - i; j--) 
                {
                    Console.Write("*");
                }

                Console.WriteLine("");
            }
        }
    }
}

