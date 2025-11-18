using System;

namespace CSharp_Practice
{
    internal class Program
    {
        public static int[] Array = new int[9] { 5, 1, 66, 8, 2, 13, 9, 22, 45 };
        public static int min = 0;
        public static int max = 0;

        //•	Задача 10: Напишите программу, которая
        //выводит наибольшие и наименьшие числа из массива.
        static void Main(string[] args)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                if (max < Array[i])
                {
                    max = Array[i];
                }
            }
            min = Array[0];
            for (int i = 0; i < Array.Length; i++)
            {
                if (min > Array[i])
                {
                    min = Array[i];
                }
            }
            Console.WriteLine("Наименьшее число: " + min + " Наибольшее число: " + max);
        }
    }
}
