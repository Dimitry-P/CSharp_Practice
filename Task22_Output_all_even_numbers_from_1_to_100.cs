using System;

namespace CSharp_Practice
{
    internal class Program
    {
        // •	Задача 3: Напишите программу, которая выводит все четные числа от 1 до 100.
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}