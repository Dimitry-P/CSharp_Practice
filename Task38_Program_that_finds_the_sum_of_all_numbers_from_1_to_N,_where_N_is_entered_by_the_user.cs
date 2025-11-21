using System;

namespace CSharp_Practice
{
    //•	Задача 4: Напишите программу, которая находит
    //сумму всех чисел от 1 до N, где N вводится пользователем.
    internal class Program
    {
        public static string number;
        public static int result = 0;
        public static int LastNumber;

        public static int sum(int number)
        {
            while (LastNumber != 0)
            {
                result += LastNumber;
                LastNumber--;
            }
            return result;
        }

        static void Main()
        {
            Console.WriteLine("Введите число больше единицы");
            number = Console.ReadLine();
            LastNumber = int.Parse(number);
            while (LastNumber < 0)
            {
                Console.WriteLine("Вы ввели неверное число");
                Console.WriteLine("Введите число больше единицы");
                number = Console.ReadLine();
                LastNumber = int.Parse(number);
            }
            sum(LastNumber);
            Console.WriteLine("Сумма всех чисел от одного до вашего числа равна " + result);

            Console.ReadKey();
        }
    }
}
