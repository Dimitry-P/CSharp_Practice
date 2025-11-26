using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество: ");
            int number = int.Parse(Console.ReadLine());
            Counter[] counters = new Counter[number];
            for (int i = 0; i < number; i++)
            {
                counters[i] = new Counter();
            }
            Counter.ShowInfo();
        }
    }
}

//Задача 3: Статический конструктор и подсчет объектов
// Создайте класс Counter с массивом объектов, который подсчитывает,
// сколько объектов было создано. Используйте статический
// конструктор для инициализации.
//Ввод:
//3
//Вывод:
//Статический конструктор вызван.
//Создано объектов: 3
