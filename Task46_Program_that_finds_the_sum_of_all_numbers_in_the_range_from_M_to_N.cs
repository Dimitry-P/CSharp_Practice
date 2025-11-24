using System;

namespace CSharp_Practice
{
    internal class Program
    {
        //•	Задача 14: Напишите программу, которая
        //находит сумму всех чисел в диапазоне от M до N.
        public static int result = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Введите начальное и конечное число через запятую");
            string num = Console.ReadLine();
            string[] pieces = num.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            int m = int.Parse(pieces[0]);
            int n = int.Parse(pieces[1]);
            for (int i = m; i < n + 1; i++)
            {
                result += i;
            }
            Console.WriteLine("Сумма чисел равна: " + result);
        }
    }
}
