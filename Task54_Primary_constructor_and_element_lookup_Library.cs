using System;

namespace CSharp_Practice
{
    public class Library(List<Book> books)
    {
        private readonly List<Book> books = books ?? throw new ArgumentNullException(nameof(books), "Список книг не может быть пустым");

        public string FindBook(string title)
        {
            foreach (Book book in books)
            {
                if (string.Equals(book.Title, title, StringComparison.OrdinalIgnoreCase))
                {
                    return $"Найдена книга: {book.Title} от {book.Author}";
                }
            }
            return "Книга не найдена";
        }
    }
}

// ArrayList  и List  почитать   nameof   var   исключения   как свой тип исключения создать 