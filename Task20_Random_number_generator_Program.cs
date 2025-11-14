using System;
using System.Collections;
using System.Collections.Generic;


namespace CSharp_Practice
{
    public class Program
    {
        static void Main(string[] args)
        {
            var numberGenerator = new NumberGenerator();
            int max = 0;
            if (max != null)
            {
                max = int.Parse(Console.ReadLine());

                numberGenerator.EventNumberGenerated += NumberGenerator_EventNumberGenerated;
                numberGenerator.Generate(max);
            }
        }

        private static void NumberGenerator_EventNumberGenerated(object? sender, EventNumberEventArgs e)
        {
            Console.WriteLine($"Even: {e.Number}");
        }
    }
}

