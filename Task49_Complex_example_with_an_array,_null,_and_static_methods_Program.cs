using System;

namespace CSharp_Practice
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите количество пользователей:");
            int userCount = int.Parse(Console.ReadLine());

            var users = new List<Users>();

            for (int i = 0; i < userCount; i++)
            {
                Console.WriteLine("Введите имя пользователя либо нажмите Enter:");
                string userName = Console.ReadLine();
                users.Add(new Users(userName));
            }

            while (true)
            {
                Console.WriteLine("\nВведите имя пользователя для поиска:");
                string userName = Console.ReadLine();

                Console.WriteLine(UserManager.FindUserName(users, userName));
                Console.WriteLine(UserManager.NullNameCount(users));
                break;
            }
        }
    }
}

//Задача 5: Сложный пример с массивом, null и статическими методами
//Создайте класс UserManager, который хранит массив пользователей.
//Реализуйте метод для поиска пользователя по имени и метод для
//подсчета пользователей с именем, равным null.
//Ввод: Alice, , Bob, , Charlie
//Вывод:
//Найден пользователь с именем: Alice
//Количество пользователей с именем null: 2
