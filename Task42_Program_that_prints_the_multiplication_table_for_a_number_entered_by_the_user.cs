using System;

namespace CSharp_Practice
{
    internal class Program
    {
        //•	Задача 8: Напишите программу, которая выводит таблицу
        //умножения для числа, введенного пользователем.
        public static string num;
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            num = Console.ReadLine();
            int number = int.Parse(num);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{number} * {i + 1} = {number * (i + 1)}");
            }
            Console.ReadKey();
        }
    }
}
