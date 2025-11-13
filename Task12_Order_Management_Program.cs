using System;

namespace CSharp_Practice
{
    public class Program
    {
        static void Main()
        {
            var orders = new List<Order>();
            Console.WriteLine("Введите количество заказов:");
            int amountOfOrders = int.Parse(Console.ReadLine());

            for (int i = 0; i < amountOfOrders; i++)
            {
                Console.WriteLine($"Введите ID заказа #{i + 1}:");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine($"Введите статус NEW, IN_PROGRESS, COMPLETED заказа #{i + 1}:");
                string status = Console.ReadLine();

                if (!Enum.TryParse(status.ToUpper(), out StatusCheck Status))
                {
                    Console.WriteLine("Ошибка: некорректный статус. Попробуйте снова");
                    i--;
                    continue;
                }

                Console.WriteLine($"Введите описание заказа #{i + 1}:");
                string? descr = Console.ReadLine();

                orders.Add(new Order(id, Status, descr));
            }
            Console.WriteLine("Введите id заказа, который хотите найти:");
            int orderID = int.Parse(Console.ReadLine());
            OrderManager.FindOrderById(orderID, orders);
        }
    }
}

//Пример задачи 2: Управление заказами
//Описание:
//Создайте класс OrderManager, который хранит заказы с ID, статусом (enum) и описанием. Реализуйте:

//Поиск заказа по ID.
//Подсчёт заказов со статусом NEW.
//Выброс исключения, если заказ с заданным ID не найден.
//Классы:

//Order – класс заказа с полями: id(int), status(enum), description(String).
//OrderManager – класс для управления заказами.
//OrderStatus – enum для статусов заказа(NEW, IN_PROGRESS, COMPLETED).
//Методы:

//OrderManager.findOrderById(int id) – поиск заказа по ID.
//OrderManager.countNewOrders() – подсчёт заказов со статусом NEW.

//Пример ввода:
//Заказы:
//[Order(1, NEW, "Первый заказ"), Order(2, IN_PROGRESS, "Второй заказ"), Order(3, NEW, "Третий заказ")]

//Вывод:
//Найден заказ: ID 1, описание: Первый заказ  
//Количество заказов со статусом NEW: 2