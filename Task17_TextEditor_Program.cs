using System;

namespace CSharp_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            TextEditor newEditor = new TextEditor();
            newEditor.TypeText("Hello");
            newEditor.TypeText("World");
            Console.WriteLine(newEditor.GetText());
            newEditor.Undo();
            Console.WriteLine(newEditor.GetText());
            newEditor.Undo();
            Console.WriteLine(newEditor.GetText());
        }
    }
}