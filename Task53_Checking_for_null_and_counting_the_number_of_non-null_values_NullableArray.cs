using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice
{
    public class NullableArray
    {
        public static int totalAmount = 0;
        public static int countOfElements = 0;
        private int ValueHasExistingWord = 0;
        public string InputValue
        {
            set
            {
                if (value != "")
                {
                    ValueHasExistingWord++;
                }
            }
        }
        public NullableArray(string inputValue)
        {
            InputValue = inputValue;
        }
        public void Calculate(int amountOfWords)
        {
            countOfElements++;
            if (ValueHasExistingWord == 1) totalAmount++;
            if (countOfElements == amountOfWords) Console.WriteLine(totalAmount);
        }
    }
}
