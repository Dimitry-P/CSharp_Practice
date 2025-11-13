using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice
{
    class Program
    {
        public static string s = "MCMXCIV";
        public static string[] Symbol = new string[7] { "I", "V", "X", "L", "C", "D", "M" };
        public static int[] Value = new int[7] { 1, 5, 10, 50, 100, 500, 1000 };

        public static void RomanToInt(string s)
        {
            int result = 0;
            int specialNum = 0;
            int final = 0;
            char[] charArray = s.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                if ((charArray[i].ToString() == "I" || charArray[i].ToString() == "X" || charArray[i].ToString() == "C") &&
                   (charArray[i + 1].ToString() == "V" || charArray[i + 1].ToString() == "L" || charArray[i + 1].ToString() == "D" ||
                   charArray[i + 1].ToString() == "X" || charArray[i + 1].ToString() == "C" || charArray[i + 1].ToString() == "M"))
                {
                    specialNum = Value[Array.IndexOf(Symbol, charArray[i + 1].ToString())] - Value[Array.IndexOf(Symbol, charArray[i].ToString())];
                    result += specialNum;
                    i++;
                }
                else
                {
                    int normalNum = Array.IndexOf(Symbol, charArray[i].ToString());
                    result += Value[normalNum];
                }
                Console.WriteLine(result);

                //I может быть расположена перед V(5) или X(10), чтобы получить 4 или 9.
                //X может быть расположена перед L(50) или C(100) чтобы получить 40 или 90.
                //C может быть расположена перед D(500) или M(1000) чтобы получить 400 или 900.
            }
            Console.WriteLine(result);
        }


        static void Main(string[] args)
        {
            RomanToInt(s);
        }
    }
}
