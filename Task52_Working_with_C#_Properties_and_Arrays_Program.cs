using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice
{
    internal class Program
    {
        public static Student student;
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Введите имя студента: ");
                string name = Console.ReadLine();
                Console.WriteLine("Введите через пробел три оценки: ");
                string marks = Console.ReadLine();
                student = new Student(name, marks);
            }
            Student.ShowNameAndAge();
        }
    }
}
//Задача 1: Работа со свойствами и массивами
//Создайте класс Student, который хранит имя и оценки ученика.
//Создайте массив из пяти учеников и выведите информацию
//о каждом из них, используя цикл.
//Ввод:
//Имя студента: Alice
//Оценки: 5 4 3
//Имя студента: Bob
// Оценки: 4 4 5
// Вывод:
//Alice: Средний балл = 4.00
//Bob: Средний балл = 4.33
