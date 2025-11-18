using System;

namespace CSharp_Practice
{
    internal class Program
    {
        public static string number;
        public static int result;
        public static int sum = 0;
        public static int amount = 0;

        //•	Задача 9: Напишите программу, которая находит количество делителей числа.
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое число больше 0");
            number = Console.ReadLine();
            result = int.Parse(number);
            for (int i = 1; i < result + 1; i++)
            {
                if (result % i == 0)
                {
                    amount++;
                }
            }
            Console.WriteLine("Кол-во делителей у числа: " + result + " " + amount);
        }
    }
}
