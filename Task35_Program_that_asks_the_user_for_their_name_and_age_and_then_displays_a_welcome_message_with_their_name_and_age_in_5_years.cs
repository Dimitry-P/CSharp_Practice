using System;

namespace CSharp_Practice
{
    //•	Задача 1: Напишите программу, которая запрашивает
    //у пользователя его имя и возраст, а затем выводит
    //приветственное сообщение с его именем и возрастом через 5 лет.
    internal class Program
    {
        public static string age;
        public static string name;
        static void Main(string[] args)
        {
            Console.WriteLine("Сообщите, пожалуйста, ваше имя и возраст:");
            Console.Write("имя:");
            name = Console.ReadLine();
            Console.Write("возраст:");
            age = Console.ReadLine();
            int number = int.Parse(age);
            number += 5;
            Console.WriteLine("Приветствую, " + name + ", ваш возраст через пять лет: " + number);

            Console.ReadKey();
        }
    }
}
