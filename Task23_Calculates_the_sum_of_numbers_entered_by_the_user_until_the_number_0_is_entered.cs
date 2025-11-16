using System;


namespace CSharp_Practice
{
    internal class Program
    {
        //•	Задача 4: Напишите программу, которая считает
        //сумму чисел, введенных пользователем до тех пор,
        //пока не будет введено число 0.
        public static string num;
        public static bool game = true;
        public static int result = 0;
        static void Main()
        {
            while (game == true)
            {
                Console.Write("Введите число: ");
                num = Console.ReadLine();
                if (int.Parse(num) == 0) game = false;
                result += int.Parse(num);
                Console.SetCursorPosition(0, 1);
                Console.Write("                                     ");
                Console.SetCursorPosition(0, 1);
                Console.Write("Введите число: ");

                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Общий результат: " + result);

            }
            if (game == false)
            {
                Console.WriteLine("Общий результат: " + result + " Ваша игра завершена");
                Console.ReadKey();
            }
        }
    }
}

