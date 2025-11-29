using System;
using static System.Reflection.Metadata.BlobBuilder;

namespace CSharp_Practice
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите количество книг, которые хотите добавить:");
            int bookCount = int.Parse(Console.ReadLine());

            var books = new List<Book>();

            for (int i = 0; i < bookCount; i++)
            {
                Console.WriteLine($"Введите название книги #{i + 1}:");
                string title = Console.ReadLine();
                Console.WriteLine($"Введите Автора #{i + 1}:");
                string author = Console.ReadLine();
                books.Add(new Book(title, author));
            }

            var library = new Library(books);

            while (true)
            {
                Console.WriteLine("\nВведите название книги для поиска (Или exit для выхода): ");
                string title = Console.ReadLine();

                if (title.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                Console.WriteLine(library.FindBook(title));
            }
        }
    }
}

//Задача 4: Первичный конструктор и поиск элемента
//Создайте класс Library, который хранит массив книг.
//Реализуйте поиск книги по названию.

//Ввод: 1984
//Вывод: Найдена книга: 1984 от George Orwell

//Ввод: Unknown Book
//Вывод: Книга не найдена.
