using System;

namespace CSharp_Practice
{
    internal class Program
    {
        // •	Задача 2: Напишите программу, которая запрашивает
        // у пользователя два числа и выводит их сумму, разницу,
        // произведение и частное.
        public static string number1;
        public static string number2;
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            number1 = Console.ReadLine();
            int firstNumber = int.Parse(number1);
            Console.WriteLine("Введите второе число:");
            number2 = Console.ReadLine();
            int secondNumber = int.Parse(number2);
            Console.WriteLine("Сумма двух чисел равна " + (firstNumber + secondNumber));
            Console.WriteLine("Разница двух чисел равна " + (firstNumber - secondNumber));
            Console.WriteLine("Произведение двух чисел равно " + (firstNumber * secondNumber));
            Console.WriteLine("Частное двух чисел равно " + (firstNumber / secondNumber));

            Console.ReadKey();
        }
    }
}
