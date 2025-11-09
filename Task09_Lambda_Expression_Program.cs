using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = "";
            //Func<string, int> stringLength = receivedString =>
            //{
            //    if (receivedString != null)
            //        return receivedString.Length;
            //    else
            //        return 0;
            //};
            //Console.WriteLine(stringLength(input));
            //int x = 0;
            //int y = 0;
            //Func<int, int, int> result = (x, y) => (int)Math.Pow(x, y);
            //Console.WriteLine(result(x, y));
            List<Product> products = new List<Product>();
            Console.WriteLine("Введите кол-во продуктов:");
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Введите название продукта");
                string name = Console.ReadLine();
                Console.WriteLine("Введите стоимость продукта");
                double price = double.Parse(Console.ReadLine());
                products.Add(new Product(name, price));
            }

            products.Sort((a, b) =>
            {
                int priceCompare = b.Price.CompareTo(a.Price);
                if (priceCompare != 0) return priceCompare;

                return a.Name.CompareTo(b.Name);
            });

            foreach (Product product in products)
            {
                Console.Write(product.Name + ": ");
                Console.WriteLine(product.Price);
            }
        }
    }
}