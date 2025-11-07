using System;

public class CSharp_Practice
{
    public static string[] AddLength(string str)
    {
        int length = 0;
        int count = 0;
        string word = "";
        string[] firstArray = str.Split(' ');
        string[] secondArray = new string[firstArray.Length];

        foreach (var midWord in firstArray)
        {
            length = midWord.Length;
            word = midWord + " " + length.ToString();
            secondArray[count] = word;
            word = "";
            count++;
        }

        return secondArray;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string[] result = Kata.AddLength(input);

        Console.WriteLine("\nResult:");
        foreach (string item in result)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
