using System;

namespace CSharp_Practice
{
    internal class Program
    {
        public static string number;
        public static int result;
        public static int sum = 0;

        //•	Задача 8: Напишите программу, которая вычисляет
        //сумму чисел от 1 до N, используя цикл for.
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое число больше 1");
            number = Console.ReadLine();
            result = int.Parse(number);
            for (int i = 1; i < result + 1; i++)
            {
                sum += i;
            }
            Console.WriteLine("Сумма чисел равна: " + sum);
        }
    }
}
