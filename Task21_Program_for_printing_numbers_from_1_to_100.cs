using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0 && i % 5 != 0)
                {
                    Console.WriteLine("Fizz");
                    i++;
                }
                if (i % 5 == 0 && i % 3 != 0)
                {
                    Console.WriteLine("Buzz");
                    i++;
                }
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    i++;
                }
                Console.WriteLine(i);
            }
        }
    }
}

//•	Задача 1: Напишите программу, которая
//выводит все числа от 1 до 100, но для чисел,
//делящихся на 3, выводит "Fizz", для чисел,
//делящихся на 5 — "Buzz", а для чисел, делящихся и на 3, и на 5 — "FizzBuzz".
