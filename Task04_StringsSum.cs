using System;

namespace CSharp_Practice
{
    public static class Program
    {
        public static string StringsSum(string s1, string s2)
        {
            int one;
            int two;

            bool isFirstNumber = int.TryParse(s1, out one);
            bool isSecondNumber = int.TryParse(s2, out two);

            return (one + two).ToString();
        }

        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            string first = Console.ReadLine();

            Console.Write("Enter second number: ");
            string second = Console.ReadLine();

            string result = StringsSum(first, second);

            Console.WriteLine($"Sum: {result}");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
