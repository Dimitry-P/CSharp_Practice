using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharp_Practice
{
    internal class Program
    {
        // 1. Классы и свойства
        // Задача:
        //Создайте класс Person, представляющий человека.У него должны быть свойства:
        //Name (имя, string),
        //Age (возраст, int, должен быть больше 0).
        //Добавьте метод для вывода информации о человеке.

        //Пример:
        //Ввод: Name = "Alice", Age = 25
        //Вывод: Name: Alice, Age: 25



        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя и возраст:");
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            Person person1 = new Person(name, age);
            person1.ShowNameAge();
        }
    }
}
