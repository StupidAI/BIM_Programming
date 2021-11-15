using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_5
{
    /* Условаия задачи:
     *  Обязательная задача*. Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN следующего вида:
     *  
        1 0 1 0 1

        0 1 0 1 0

        1 0 1 0 1

        0 1 0 1 0

        1 0 1 0 1
     */
    class Program
    {
        static void Main(string[] args)
        {
            // user input
            Console.Write("Enter size of square array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            
            // set values
            int[,] array = new int[size,size];
            bool tikTak = true; // true -> [0,0] = 1, false -> [0,0] = 0
            for (int i = 0; i < size; i++)
            {
                for (int j = (tikTak) ? 0 : 1; j < size;)
                {
                    array[i, j] = 1;
                    j += 2;
                }
                tikTak = !tikTak;
            }

            //output
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write($"{array[i,j]}\t");
                }
                Console.WriteLine("\n\n");
            }
            Console.WriteLine("Press any button...");
            Console.ReadKey();
        }
    }
}
