using System;

namespace CSharp_Practice
{
    delegate int[] ArrayTransformer(int[] x);
    class Program
    {
        static int[] DoubleElements(int[] x)
        {
            for (int i = 0; i < x.Length; i++)
            {
                x[i] *= 2;
            }
            return x;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Укажите количество элементов:");
            int num = int.Parse(Console.ReadLine());
            int[] result = new int[num];
            for (int i = 0; i < num; i++)
            {
                Console.Write($"Элемент {i + 1}: ");
                result[i] = int.Parse(Console.ReadLine());
            }
            ArrayTransformer arrayTransformer = DoubleElements;
            int[] outputArray = arrayTransformer(result);
            for (int i = 0; i < outputArray.Length; i++)
            {
                Console.Write(outputArray[i] + " ");
            }
        }
    }
}

/*delegate int MathOperation(int a, int b);

   class Program
   {
       static int Add(int x, int y) 
       { 
           return x + y;
       }
       static void Main(string[] args)
       {
           MathOperation mathOperation = Add;

           Console.WriteLine("Введите первое число:");
           int firstNum = int.Parse(Console.ReadLine());

           Console.WriteLine("Введите второе число:");
           int secondNum = int.Parse(Console.ReadLine());

           Console.WriteLine(mathOperation(firstNum, secondNum)); 
       }
   }*/

//delegate bool NumberCheck(int x);
//class Program
//{
//    static bool IsEven(int x)
//    {
//        return x % 2 == 0;
//    }

//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите число:");
//        int num = int.Parse(Console.ReadLine());

//        NumberCheck numCheck = IsEven;
//        bool result = numCheck(num);
//        Console.WriteLine(result ? "Четное" : "Нечетное");
//    }
//}