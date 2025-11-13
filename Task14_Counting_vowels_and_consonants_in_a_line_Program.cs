using System;
using System.Collections;

namespace CSharp_Practice
{
    class Program
    {
        public static string input;
        public static void Main()
        {
            Console.WriteLine("Введите какое-то выражение:");
            input = Console.ReadLine();
            StringAnalyzer.CountLettersAmount(input);
        }
    }
}

//Подсчёт гласных и согласных в строке
//Описание:
//Создайте класс StringAnalyzer, который анализирует строку. Реализуйте:

//Подсчёт количества гласных букв.
//Подсчёт количества согласных букв.
//Исключение, если строка пуста или null.
//Классы:

//StringAnalyzer – содержит методы:
//CountVowels(string input) – возвращает количество гласных.
//CountConsonants(string input) – возвращает количество согласных.
//Пример ввода:
//string input = "Hello, World!";

//Вывод:
//Количество гласных: 3
//Количество согласных: 7