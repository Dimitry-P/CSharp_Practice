using System;
using System.Collections;

namespace CSharp_Practice
{
    class Program
    {
        public static bool correctStatus = false;
        public static bool enumWrong = true;
        public static int j = 1;
        public static void Main()
        {
            ArrayList tasks = new ArrayList();
            Console.WriteLine("Введите кол-во задач:");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine($"Введите название {i + 1}-ой задачи:");
                string title = Console.ReadLine();

                Console.WriteLine("Какой статус у задачи: New, InProgress, Completed");
                string status = Console.ReadLine();
                if (!Enum.TryParse(status, out TaskStatus statusOfTask))
                {
                    Console.WriteLine("Введите верный статус:");
                    i--;
                    continue;
                }

                tasks.Add(new Task(title, statusOfTask));
            }

            while (j == 1)
            {
                Console.WriteLine("Введите статус задач, которые хотите найти:");
                string searchStatus = Console.ReadLine();
                if (!Enum.TryParse(searchStatus, out TaskStatus StatusToFind))
                {
                    Console.WriteLine("Вы ввели неверный статус!");
                    j = 1;

                }
                else
                {
                    j = 0;
                    TaskManager.FindTasksByStatus(StatusToFind, tasks);
                }
            }
        }
    }
}

//Задача 5:
//Управление статусом задач
//Описание:
//Создайте класс TaskManager, который работает с задачами. Каждая задача имеет название и статус (enum). Реализуйте:

//Поиск задач с определённым статусом.
//Подсчёт задач со статусом New.
//Исключение, если задач нет.
//Классы:

//Task – класс задачи с полями: Title(string) и Status(enum).
//TaskManager – менеджер с методами:
//FindTasksByStatus(TaskStatus status) – возвращает список задач с указанным статусом.
//CountTasksWithStatusNew() – возвращает количество задач со статусом New.
//TaskStatus – enum со статусами: New, InProgress, Completed.
//Пример ввода:
//var tasks = new[]
//{
//    new Task("Задача 1", TaskStatus.New),
//    new Task("Задача 2", TaskStatus.Completed),
//    new Task("Задача 3", TaskStatus.New)
//};


//Вывод:
//Задачи со статусом New: Задача 1, Задача 3  
//Количество задач со статусом New: 2
