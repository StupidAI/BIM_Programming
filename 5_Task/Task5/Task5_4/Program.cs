using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_4
{
    /* Сформировать одномерный массив из 20 случайных чисел в диапазоне [-50;50]. Определить количество 
     * нечетных положительных элементов, стоящих на четных местах.
     */
    class Program
    {
        static void Main(string[] args)
        {
            const int size = 20;
            int[] array = new int[size];
            Random random = new Random();
            // inputs
            Console.WriteLine("Numbers are:\n");
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(-50, 51);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            // count odd numbers
            int count = 0;
            for (int i = 1; i < size;)
            {
                if (array[i] % 2 != 0)
                {
                    count++;
                }
                i += 2;
            }

            // output
            Console.WriteLine($"\nAmount of odd numbers in in even positions is: {count}");
            Console.WriteLine("\nPress any button...");
            Console.ReadKey();
        }
    }
}
