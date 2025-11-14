using System;

namespace CSharp_Practice
{
    class TextEditor
    {
        private Stack<string> stack = new Stack<string>();
        private string newText = "";
        public void TypeText(string text)
        {
            stack.Push(text);
            newText += text;
        }
        public void Undo()
        {
            if (stack.Count > 0)
            {
                newText = stack.Pop();
            }
        }
        public string GetText()
        {
            return newText;
        }
    }
}
