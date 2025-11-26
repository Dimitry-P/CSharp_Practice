using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice
{
    internal class Program
    {
        // Methods
        private static void Main(string[] args)
        {
            Console.Write("Введите количество студентов: ");
            int num = int.Parse(Console.ReadLine());// вводим кол-во студентов
            Student[] studentArray = new Student[num];// создаём массив с типом Student и с той длиной
                                                      // которую пользователь ввёл
            for (int i = 0; i < num; i++)// запуск цикла для ввода пользователем имен и оценок студентов
            {
                Student.threeGradesAreCorrect = 0;// обнуление поля, которое подсчитывает, что
                //кол-во введённых пользователем элементов равно 3 и все они соответствуют требованиям
                Console.WriteLine($"Введите имя {i + 1}-ого студента:");// вывод сообщения с просьбой ввести имя студентов
                string name = Console.ReadLine();// в этот стринг кладётся введённое пользователем имя студента
                do// будет выводится сообщение с просьбой ввести три оценки для конкретного студента до тех пор,
                  // пока не будут введены соответствующие требованиям значения. 
                {
                    Console.WriteLine("Введите через пробел три оценки: ");
                    string grade = Console.ReadLine();//если все три значения введены верно, то помещаем
                    // строчку с тремя оценками в поле grade
                    studentArray[i] = new Student(name, grade);//создаём объект для созданного нами массива,
                    // в шаблон Student (в конструктор) передаём в аргументе введённое имя и строку с оценками
                }
                while (Student.threeGradesAreCorrect != 3);// условие при котором будет повторятся вышеописанное действие
            }
            Console.WriteLine("Информация о студентах:");
            foreach (Student student in studentArray) // проходимся циклом по массиву studentArray
                                                      // и каждый объект кладём в поле student
            {
                student.ShowInfo();// для каждого объекта вызываем метод ShowInfo
            }
        }
    }
}
