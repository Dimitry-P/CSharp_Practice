using System;

namespace CSharp_Practice
{
    internal class Program
    {
        //•	Задача 11: Напишите программу, которая выводит все числа Фибоначчи до N.
        public static string number;
        public static int result;
        public static int first;
        public static int second;
        public static int third;

        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое число больше 0");
            number = Console.ReadLine();
            result = int.Parse(number);
            for (int i = 0; i < result; i++)
            {
                if (i == 0)
                {
                    first = 0;
                    second = 1;
                    Console.Write(first + ", ");
                    Console.Write(second + ", ");
                }
                if (i != 0)
                {
                    third = first + second;
                    Console.Write(third + ", ");
                    if (third == result) return;
                    first = second;
                    second = third;
                }
            }
        }
    }
}
