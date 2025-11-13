using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice
{
    class Program
    {
        public static string[] strs = new string[10] { "floywer", "floyw", "floyght", "floy123", "floyhtsrhrstjhght", "floyshstthstght", "floypppppght", "floywwwwwght", "floyzzzzght", "floybbbbght" };
        public static string result = "";

        public static string longestCommonPrefix()
        {
            for (int w = 0; w < 1; w++)
            {
                char[] charArray = strs[0].ToCharArray();
                string checkTheLetter = charArray[0].ToString();
                int l = 0;
                int i = 0;
                for (int j = 0; j < strs.Length; j++)
                {
                    if (j == strs.Length - 1)
                    {
                        result += checkTheLetter;
                        checkTheLetter = charArray[(i++) + 1].ToString();
                        j = 0;
                        l++;
                    }
                    char[] charArray2 = strs[j + 1].ToCharArray();
                    if (checkTheLetter != charArray2[l].ToString())
                    {
                        return result;
                    }
                }
            }
            return result;
        }

        static void Main(string[] args)
        {
            longestCommonPrefix();
            Console.WriteLine(result);
        }
    }
}
