using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Practice
{
    public class Student
    {
        // Fields
        public double averageGrade = 0.0;// поле со средним значением трёх оценок каждого студента
        public static int threeGradesAreCorrect;//задаём поле, обозначающее, что все три значения для одного
        // студента введены корректно
        private int[] grades = new int[3];// массив из трёх ячеек, куда помещаются три введённых пользователем оценки

        // Methods
        public Student(string name, string grade)// конструктор класса, который принимает два параметра
        {
            this.Name = name;// в Name помещается переданное имя
            this.Grade = grade;// в Grade помещается переданная строчка с оценками
        }

        public void Calculate()// метод для сложения всех трех оценок и деления их на 3,
                               // а также для обрезки десятичных чисел после запятой. 
                               // после запятой остаётся только две цифры. 
        {
            for (int i = 0; i < this.grades.Length; i++)
            {
                this.averageGrade += this.grades[i];// сложение
            }
            this.averageGrade /= (double)this.grades.Length;// деление
            this.averageGrade = Math.Truncate((double)(this.averageGrade * 100.0)) / 100.0;// приведение
            //десятичного числа
        }

        public void ShowInfo()// метод для отображения имени и среднего балла каждого студента
        {
            Console.WriteLine($"{this.Name}: Средний балл = {this.averageGrade}");
        }

        // Properties
        public string Name { get; set; }// свойства для передаваемых параметров.
        // сначала параметры поступают в конструктор, далее сюда в свойства.
        // здесь проверяется переданное имя студента

        public string Grade // свойство для обработки переданной строчки с оценками студента
        {
            get =>
                string.Join<int>(" ", this.grades);//в геттере соединяем в строку каждые три оценки,
            // переданные в массив grades
            set// в сеттере делаем проверку переданного значения
            {
                char[] separator = new char[] { ' ' };// сначала создаём массив, состоящий из пустой строки
                string[] strArray = value.Split(separator);// затем дробим введённую пользователем строку
                // на элементы и помещаем их в стринговый массив
                if (strArray.Length == 3)// проверям чтобы введённых элементов было ровно три
                {
                    for (int i = 0; i < 3; i++)// запуск цикла 
                    {
                        if (int.TryParse(strArray[i], out _))// проверка чтобы каждое введенное значение 
                                                             //являлось числом
                        {
                            int num3 = int.Parse(strArray[i]);// в локальную переменную num3 помещаем каждый элемент,
                            // трансформированный из строки в число
                            if ((num3 < 1) || (num3 > 5))// условие, чтобы введённое число было в пределах от 1 до 5
                            {
                                Console.WriteLine("Оценки должны быть от 1 до 5");// в противном случае будет появляться
                                // данное сообщение
                                return;// выход из цикла
                            }
                            threeGradesAreCorrect++;// если введённая оуенка соответствует требованиям, то поле
                            // threeGradesAreCorrect увеличиваем на единицу
                            this.grades[i] = num3;// и помещаем нашу оценку в массив grades
                        }
                        else
                        {
                            Console.WriteLine("Вы ввели НЕ число!");
                            return;// если было введено нечисловое значение, то выходим из цикла
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Вам нужно ввести ТРИ оценки!");// если введённых значений НЕ три,
                    // то будет появляться данное сообщение
                }
                this.Calculate(); // запуск метода для сложения всех трех оценок и деления их на 3
            }
        }
    }
}
