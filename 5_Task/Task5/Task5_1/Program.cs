using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_1
{
    /*
     * Сформировать одномерный массив из 7 элементов. Заполнить массив числами, вводимыми с клавиатуры, 
     * определить среднее арифметическое элементов.
     */
    class Program
    {
        static void Main(string[] args)
        {
            const int size = 7;
            int[] array = new int[size];
            float average = 0;
            //user inputs
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter number: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            //find average
            int sum = 0;
            foreach (int i in array)
            {
                sum += i;
            }
            average = (float)sum / size;
            //output
            Console.WriteLine($"\nAverage of numbers is: {average:f3}");
            Console.WriteLine("\nPress any button...");
            Console.ReadKey();
        }
    }
}
