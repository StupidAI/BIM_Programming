using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_3
{
    /* Сформировать одномерный массив из 10 случайных чисел в диапазоне [-50;50]. 
     * Первые 5 элементов упорядочить по возрастанию, вторые 5 – по убыванию.
     */
    class Program
    {
        static void Main(string[] args)
        {
            const int size = 10;
            int[] array = new int[size];
            Random random = new Random();
            // inputs
            Console.WriteLine("Numbers are:\n");
            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(-50, 51);
                Console.Write(array[i] + " ");
            }
            // buble sort
            // sorting 0-4
            for (int i = 0; i < size / 2; i++)
            {
                for (int j = i + 1; j < size / 2; j++)
                {
                    if (array[i] > array[j])
                    {
                        (array[i], array[j]) = (array[j], array[i]);
                    }
                }
            }
            // sorting 5-9
            for (int i = size / 2; i < size; i++)
            {
                for (int j = i + 1; j < size; j++)
                {
                    if (array[i] < array[j])
                    {
                        (array[i], array[j]) = (array[j], array[i]);
                    }
                }
            }
            // output
            Console.WriteLine("\n\nSorted array:\n");
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("\n\nPress any button...");
            Console.ReadKey();
        }
    }
}
