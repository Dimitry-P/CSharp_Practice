using System;

namespace CSharp_Practice
{
    internal class Program
    {
        // •	Задача 15: Напишите программу, которая
        // определяет, является ли число четным или нечетным.
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            string num = Console.ReadLine();
            int number = int.Parse(num);
            if (number % 2 == 0)
            {
                Console.WriteLine("число чётное");
                return;
            }
            Console.WriteLine("число НЕчётное");
        }
    }
}
