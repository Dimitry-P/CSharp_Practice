using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice
{
    class Counter
    {
        public static int amountOfObjects;
        static Counter()
        {
            Console.WriteLine("Статический конструктор вызван");
            amountOfObjects = 0;
        }

        public Counter()
        {
            amountOfObjects++;
        }
        public static void ShowInfo()
        {
            Console.WriteLine("Создано объектов: " + amountOfObjects);
        }
    }
}
