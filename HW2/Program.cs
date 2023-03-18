using System;
using System.Linq.Expressions;
using System.Runtime.ExceptionServices;

namespace ConsoleApp
{
    class Programm
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов массива");
            int n;
            if (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Эй! Пожалуйста, используйте целое число!");
                return;
            }
            
            int[] numbers2 = new int[n];
            Console.WriteLine("Введите челочисленные элементы массива");
            try
            {
                for (int i = 0; i < n; i++)
                {
                    numbers2[i] = int.Parse(Console.ReadLine());
                }
            }
            catch
            {
                Console.WriteLine("Кажется, вы ввели не целое число. Впредь, пожалуйста, повнимательнее");
            }
            int max = int.MinValue;
            int submax = int.MinValue;
            foreach (int i in numbers2)
            {
                if (i > max)
                {
                    submax = max;
                    max = i;
                }
                else if (i > submax)
                    submax = i;
            }
            Console.WriteLine("Второе из наибольших чисел: " + submax);
        }
    }
}