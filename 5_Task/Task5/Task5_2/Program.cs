using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_2
{
    /*Сформировать одномерный массив из 15 элементов, которые выбираются случайным образом из диапазона [0; 50]. 
     * Определить сумму максимального и минимального элементов массива.
     */
    class Program
    {
        static void Main(string[] args)
        {
            const int size = 15;
            int[] array = new int[size];
            int max, min;
            Random random = new Random();
            //inputs
            Console.WriteLine("Numbers are:");
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(0, 51);
                Console.WriteLine(array[i]);
            }

            //find max min
            max = min = array[0];
            for (int i = 1; i < size; i++)
            {
                max = (array[i] > max) ? array[i] : max;
                min = (array[i] < min) ? array[i] : min;
            }
            
            //output
            Console.WriteLine($"\nMax value is {max}, min is {min}. Summ is: {max+min}");
            Console.WriteLine("\nPress any button...");
            Console.ReadKey();
        }
    }
}
