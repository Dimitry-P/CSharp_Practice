using System;

namespace CSharp_Practice
{
    public class Kata
    {
        static string[] letters = new string[10] { "a", "b", "d", "e", "i", "l", "m", "n", "o", "t" };
        static int[] numbers = new int[10] { 6, 1, 7, 4, 3, 2, 9, 8, 0, 5 };

        public static string hidden(int num)
        {
            string word = "";
            string numAsString = num.ToString();
            char[] numAsCharArray = numAsString.ToCharArray();

            for (int i = 0; i < numAsCharArray.Length; i++)
            {
                int mid = numAsCharArray[i] - '0';
                word += letters[Array.IndexOf(numbers, mid)];
            }
            return word;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number (100 - 999999): ");
            int input = Convert.ToInt32(Console.ReadLine());

            string result = Kata.hidden(input);

            Console.WriteLine("Hidden word: " + result);

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

//Майя пишет еженедельные статьи для известного журнала, но ей не хватает одного слова каждый раз, когда она собирается отправить статью редактору. Статья не обходится без этого слова. У Майи есть друг, Дэн, и он очень хорошо владеет словами, но не любит просто так их выдавать. Он пишет Майе номер и ей нужно узнать спрятанное слово. Слова могут содержать только букву:

//    Вы можете помочь Майе, написав функцию, которая будет принимать число от 100 до 999999 и возвращать строку со словом.

//Входные данные всегда являются числом, содержат только цифры в ключе. На выходе всегда должна быть строка с одним словом, все в нижнем регистре.