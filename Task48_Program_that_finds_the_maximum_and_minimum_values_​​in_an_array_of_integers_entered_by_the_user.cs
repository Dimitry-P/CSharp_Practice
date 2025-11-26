using System;

namespace CSharp_Practice
{
    internal class Program
    {
        //•	Задача 1: Напишите программу, которая находит
        //максимальное и минимальное значения в массиве целых чисел,
        //введенном пользователем.
        public static List<int> Array = new List<int>();
        public static string num;
        public static int number;
        public static int max = 0;
        public static int min;

        static void Main(string[] args)
        {
            Console.WriteLine("Введите через запятую 10 чисел");
            num = Console.ReadLine();
            string[] pieces = num.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < pieces.Length; i++)
            {
                number = int.Parse(pieces[i]);
                Array.Add(number);
            }
            min = Array[0];
            for (int i = 0; i < Array.Count; i++)
            {
                if (Array[i] < min) min = Array[i];
                if (Array[i] > max) max = Array[i];
            }
            Console.WriteLine("Максимальное введенное вами число: " + max);
            Console.WriteLine("Минимальное введенное вами число: " + min);
            Console.ReadKey();
        }
    }
}
