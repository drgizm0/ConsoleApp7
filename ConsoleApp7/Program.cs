// See https://aka.ms/new-console-template for more information
using System;

namespace OddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Odd numbers between 1 and 300 divisible by 5:\n");

            for (int i = 1; i <= 300; i++)
            {
                if (i % 2 != 0 && i % 5 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
