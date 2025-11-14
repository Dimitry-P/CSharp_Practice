using System;
using System.Collections;

namespace CSharp_Practice
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Console.WriteLine("Введите порог температуры:");
            if (!int.TryParse(Console.ReadLine(), out int termoMax))
            {
                Console.WriteLine("Неверный ввод. Программа завершена.");
                return;
            }
            var thermometer = new Thermometer(termoMax);
            thermometer.ThresholdExeeded += OnThresholdExceededTemp;


            Console.WriteLine("Введите температуры по одной в строке, (пустая строка - выход):");

            while (true)
            {
                string line = Console.ReadLine();
                if (string.IsNullOrEmpty(line))
                {
                    Console.WriteLine("Выход из программы.");
                    break;
                }
                if (int.TryParse(line, out int temp))
                {
                    thermometer.AddTemperature(temp);
                }
                else
                {
                    Console.WriteLine("Вы ввели неверный формат числа");
                }
            }
        }
        private static void OnThresholdExceededTemp(object sender, ThresholdExeededEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"*** ВНИМАНИЕ! Температура {e.Temperature}°C превысила порог! ***");
            Console.ResetColor();
        }
    }
}