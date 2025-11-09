using Microsoft.AspNetCore.Identity;
using System.Xml.Linq;
using System;



//Пример задачи 1: Управление пользователями
//Описание:
//Создайте класс UserManager, который работает с массивом пользователей.
//Каждый пользователь имеет имя и статус из enum (ACTIVE, INACTIVE).Реализуйте:

//Поиск пользователя по имени.
//Подсчёт пользователей со статусом INACTIVE.
//Выброс исключения, если пользователь не найден.
//Классы:

//User – класс пользователя с полями: name(String) и status(enum).
//UserManager – класс-менеджер для работы с массивом пользователей.
//UserStatus – enum для статусов пользователя(ACTIVE, INACTIVE).
//Методы:

//UserManager.findUserByName(String name) – поиск пользователя по имени.
//UserManager.countInactiveUsers() – подсчёт пользователей со статусом INACTIVE.
//Пример ввода:
//Пользователи:
//[User("Alice", ACTIVE), User("Bob", INACTIVE), User("Charlie", INACTIVE)]

//Вывод:
//Найден пользователь: Alice
//Количество пользователей со статусом INACTIVE: 2

namespace CSharp_Practice
{
    public class Program
    {
        static void Main()
        {
            var users = new List<User>();
            Console.WriteLine("Введите количество пользователей: ");
            int? usersAmount = int.Parse(Console.ReadLine());

            for (int i = 0; i < usersAmount; i++)
            {
                Console.WriteLine($"Введите имя пользователя: {i + 1} ");
                string? userName = Console.ReadLine();

                Console.WriteLine($"Введите статус пользователя: {i + 1} ACTIVE или INACTIVE");
                string? userStatus = Console.ReadLine();

                if (!Enum.TryParse(userStatus.ToUpper(), out UserStatus Status))
                {
                    Console.WriteLine("Ошибка: некорректный статус. Попробуйте снова");
                    i--;
                    continue;
                }
                users.Add(new User(userName, Status));
            }
            Console.WriteLine("Введите имя пользователя, которого хотите найти: ");
            string? userSearchFoundResult = Console.ReadLine();
            bool found;
            User foundUser = UserManager.FindUserByName(users, userSearchFoundResult, out found);
            if (found)
            {
                Console.WriteLine($"Найден пользователь: {foundUser.Name}");
            }
            else
            {
                Console.WriteLine("Пользователь с таким именем не найден.");
            }
            int inactiveCount = UserManager.countInactiveUsers(users);
            Console.WriteLine($"Количество пользователей со статусом INACTIVE: {inactiveCount}");
        }
    }
}