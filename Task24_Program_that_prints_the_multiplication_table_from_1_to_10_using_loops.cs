using System;

namespace CSharp_Practice
{
    internal class Program
    {
        //•	Задача 5: Напишите программу, которая
        //выводит таблицу умножения от 1 до 10 с использованием циклов.
        static void Main(string[] args)
        {
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j < 11; j++)
                {
                    Console.WriteLine(i + " * " + j + " = " + i * j);
                }
            }
        }
    }
}
