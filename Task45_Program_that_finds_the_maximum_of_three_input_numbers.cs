using System;

namespace CSharp_Practice
{
    //•	Задача 12: Напишите программу, которая находит
    //максимальное из трех введенных чисел.
    internal class Program
    {
        public static string num;
        public static int result = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Введите через запятую три числа:");
            num = Console.ReadLine();
            string[] pieces = num.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            for (int l = 0; l < pieces.Length; l++)
            {
                if (result < int.Parse(pieces[l]))
                {
                    result = int.Parse(pieces[l]);
                }
            }
            Console.WriteLine("Наибольшее число: " + result);
            Console.ReadKey();
        }
    }
}
