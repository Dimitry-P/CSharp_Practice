using System;

namespace CSharp_Practice
{
    public class Class1
    {
        public static bool Password(string st)
        {
            bool isUpper = false;
            bool isLower = false;
            bool isDigit = false;

            if (st.Length >= 8)
            {
                for (int i = 0; i < st.Length; i++)
                {
                    if (char.IsUpper(st[i]))
                        isUpper = true;

                    if (char.IsLower(st[i]))
                        isLower = true;

                    if (char.IsDigit(st[i]))
                        isDigit = true;
                }
                return isLower && isUpper && isDigit;
            }
            return false;
        }



        static void Main(string[] args)
        {
            Console.Write("Enter password: ");
            string userInput = Console.ReadLine();

            bool result = Password(userInput);

            if (result)
            {
                Console.WriteLine("Password is valid");
            }
            else
            {
                Console.WriteLine("Password is NOT valid");
            }
        }
    }
}
