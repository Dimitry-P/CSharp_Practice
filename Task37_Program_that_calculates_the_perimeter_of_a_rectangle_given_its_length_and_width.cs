using System;

namespace CSharp_Practice
{
    //•	Задача 3: Напишите программу, которая вычисляет периметр
    //прямоугольника, зная его длину и ширину.
    internal class Program
    {
        public static string length;
        public static string width;
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину прямоугольника");
            length = Console.ReadLine();
            int lengthOfFigure = int.Parse(length);
            Console.WriteLine("Введите ширину прямоугольника");
            width = Console.ReadLine();
            int widthOfFigure = int.Parse(width);
            Console.WriteLine("Периметр прямоугольника равен " + (lengthOfFigure * 2 + widthOfFigure * 2));

            Console.ReadKey();
        }
    }
}
