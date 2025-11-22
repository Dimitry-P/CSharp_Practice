using System;

namespace CSharp_Practice
{
    //•	Задача 5: Напишите программу, которая определяет, является ли число простым.
    internal class Program
    {
        public static string number;
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            number = Console.ReadLine();
            int num = int.Parse(number);
            while (num <= 1)
            {
                Console.WriteLine("Вы ввели неверное число");
                Console.WriteLine("Введите число:");
                number = Console.ReadLine();
                num = int.Parse(number);
            }

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("Число не является простым");
                    return;
                }
            }
            Console.WriteLine("Вы ввели простое число");
            Console.ReadKey();
        }
    }
}
