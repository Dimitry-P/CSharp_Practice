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
            Console.WriteLine($"Какое кол-во элементов вы хотите ввести: ");
            int amountOfWords = int.Parse(Console.ReadLine());
            NullableArray[] existingWord = new NullableArray[amountOfWords];
            for (int i = 0; i < amountOfWords; i++)
            {
                Console.Write($"Введите элемент {i + 1} или нажмите Enter: ");
                string inputValue = Console.ReadLine();
                existingWord[i] = new NullableArray(inputValue);
            }
            Console.Write($"Элементов в массиве не равных null: ");
            foreach (NullableArray result in existingWord)
            {
                result.Calculate(amountOfWords);
            }
        }
    }
}

//Задача 2: Проверка null и подсчет количества ненулевых значений
//Создайте класс NullableArray, который хранит массив строк.
//Реализуйте метод, который подсчитывает,
//сколько элементов в массиве не равны null.
//Ввод:
//Элемент 1: Hello
//Элемент 2: World
//Элемент 3: 
//Вывод:
//Количество ненулевых значений: 2
