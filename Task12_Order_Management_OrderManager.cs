using System;

namespace CSharp_Practice
{
    public class OrderManager()
    {
        public static int newStatus = 0;
        public static int x = 0;
        public static void FindOrderById(int id, List<Order> orders)
        {
            foreach (var order in orders)
            {
                if (id == order.ID)
                {
                    Console.WriteLine($"Найден заказ: ID {id}, описание: {order.Description}");
                    x = 1;
                }
            }
            try
            {
                int y = 1 / x;
            }
            catch
            {
                Console.WriteLine($"заказ с заданным ID: {id} не найден");
                return;
            }
            CountNewOrders(orders);
        }

        private static void CountNewOrders(List<Order> orders)
        {
            foreach (var order in orders)
            {
                if (order.Status == (StatusCheck)0) newStatus++;
            }
            Console.WriteLine($"Количество заказов со статусом NEW: {newStatus}");
        }
    }
}
