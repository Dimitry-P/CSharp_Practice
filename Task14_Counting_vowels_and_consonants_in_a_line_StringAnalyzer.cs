using System;
using System.Linq;
using System.Collections;

namespace CSharp_Practice
{
    public class StringAnalyzer
    {
        public static int vowels = 0;
        public static int consonants = 0;
        public static int x = 0;

        public static void CountLettersAmount(string input)
        {
            if (input.Length != 0)
            {
                CountVowels(input);
                CountConsonants(input);
                Console.WriteLine("Количество гласных: " + vowels);
                Console.WriteLine("Количество согласных: " + consonants);
                x = 1;
            }
            try
            {
                int y = 1 / x;
            }
            catch
            {
                Console.WriteLine("строка пуста");
                return;
            }
        }
        public static void CountVowels(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                string oneLetterOfInput = input[i].ToString();
                string allWovels = "aeiouAEIOU";
                for (int k = 0; k < allWovels.Length; k++)
                {
                    if (oneLetterOfInput == allWovels[k].ToString())
                    {
                        vowels++;
                    }
                }
            }
        }

        public static void CountConsonants(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                string oneLetterOfInput = input[i].ToString();
                string allConsonants = "BCDFGHJKLMNPQRSTVWXZ";
                for (int k = 0; k < allConsonants.Length; k++)
                {
                    if (oneLetterOfInput == allConsonants[k].ToString().ToLower() || oneLetterOfInput == allConsonants[k].ToString())
                    {
                        consonants++;
                    }
                }
            }
        }
        //CountVowels(string input) – возвращает количество гласных.
        //CountConsonants(string input) – возвращает количество согласных.
    }
}

//Пример ввода:
//string input = "Hello, World!";

//Вывод:
//Количество гласных: 3
//Количество согласных: 7