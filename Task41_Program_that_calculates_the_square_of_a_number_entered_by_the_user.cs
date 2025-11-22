using System;

namespace CSharp_Practice
{
    //•	Задача 7: Напишите программу, которая вычисляет квадрат числа, введенного пользователем.
    internal class Program
    {
        public static int y = 2;
        public static string number;
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            number = Console.ReadLine();
            int result = int.Parse(number);

            Console.WriteLine("Квадрат числа равен " + Math.Pow(result, y));
            Console.ReadKey();
        }
    }
}

