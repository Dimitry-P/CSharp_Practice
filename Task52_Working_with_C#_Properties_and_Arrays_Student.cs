using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice
{
    public class Student
    {
        static List<string> namesList = new List<string>();
        static List<string> ageList = new List<string>();

        public string Name
        {
            get; set;
        }

        private string age = "Undefined";
        public string Age
        {
            set
            {
                int middle;
                string[] pieces = value.Split(new char[] { ' ' });
                for (int k = 0; k < 3; k++)
                {
                    middle = int.Parse(pieces[k]);
                    if (middle < 1 || middle > 5)
                    {
                        Console.WriteLine("Оценки должны быть от 1 до 5");
                        break;
                    }
                    else age = value;
                }
            }
            get { return age; }
        }
        public Student(string name, string age)
        {
            Name = name;
            Age = age;
            namesList.Add(Name);
            ageList.Add(Age);
        }
        public static void ShowNameAndAge()
        {
            int average = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int k = 0; k < 3; k++)
                {
                    string[] pieces = ageList[i].Split(new char[] { ' ' });
                    average += int.Parse(pieces[k]);
                }
                Console.WriteLine($"{namesList[i]}: Средний бал = {average / 3}");
                average = 0;
            }
        }
    }
}
