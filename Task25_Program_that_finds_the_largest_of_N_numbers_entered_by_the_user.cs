using System;

namespace CSharp_Practice
{
    internal class Program
    {
        //•	Задача 6: Напишите программу, которая
        //находит наибольшее из N чисел, введенных пользователем.
        public static string array;
        public static int result = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Введите несколько чисел через запяту");
            array = Console.ReadLine();
            string[] pieces = array.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < pieces.Length; i++)
            {
                if (result < int.Parse(pieces[i]))
                {
                    result = int.Parse(pieces[i]);
                }
            }
            Console.WriteLine("Наибольшее число: " + result);
        }
    }
}
