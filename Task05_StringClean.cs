using System;

namespace CSharp_Practice
{
    public class CSharp_Practice
    {
        public static string StringClean(string s)
        {
            string[] stringArray = s.Split(' ');
            string[] newArray = new string[stringArray.Length];
            string newWord = "";
            int count = 0;

            foreach (var word in stringArray)
            {
                foreach (char ch in word)
                {
                    if (!Char.IsDigit(ch))
                        newWord += ch;
                }

                newArray[count] = newWord;
                newWord = "";
                count++;
            }

            return string.Join(" ", newArray);
        }
    }

    public class Program
    {
        public static void Main()
        {
            Console.Write("Enter a string with digits: ");
            string input = Console.ReadLine();

            string cleaned = Kata.StringClean(input);

            Console.WriteLine($"Cleaned string: {cleaned}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
