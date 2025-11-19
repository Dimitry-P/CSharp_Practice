using System;

namespace CSharp_Practice
{
    internal class Program
    {
        //•	Задача 13: Напишите программу, которая выводит все простые числа до N.
        public static string number;
        public static int result;
        public static int timer = 0;
        public static int simple = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое число больше 1");
            number = Console.ReadLine();
            result = int.Parse(number);
            Console.WriteLine("Простые числа: ");
            Console.Write(2);
            for (int i = 3; i < result + 1; i++)
            {
                for (int j = 2; j < result + 1; j++)
                {
                    if (j == i)
                    {
                        Console.Write(", " + i);
                    }
                    if (i % j == 0) break;
                }
            }
        }
    }
}
