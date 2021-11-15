using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_6
{
    /* Условия задачи:
     * Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN. Заполнить массив числами, 
     * вводимыми с клавиатуры. Проверить, является ли введенная с клавиатуры матрица магическим квадратом. 
     * Магическим квадратом называется матрица, сумма элементов которой в каждой строке, в каждом столбце и по каждой диагонали одинакова.
     */
    class Program
    {
        static void Main(string[] args)
        {
            // define size of array
            Console.Write("Enter size of square array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // set values
            int[,] array = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // print array
            Console.WriteLine("Your input:\n");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine("\n\n");
            }

            // find summ-s
            int[] sumRow = new int[size];
            int[] sumCol = new int[size];
            int[] sumDiagonal = new int[2];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    sumRow[i] += array[i, j];
                    sumCol[j] += array[i, j];
                    sumDiagonal[0] += (i == j) ? array[i, j] : 0;
                    sumDiagonal[1] += ((size - 1 - i) == j) ? array[i, j] : 0;
                }
            }

            // print info about summs
            Console.Write("\nRows: ");
            foreach (int i in sumRow)
            {
                Console.Write($"{i}  ");
            }
            Console.Write("\nCol-s: ");
            foreach (int i in sumCol)
            {
                Console.Write($"{i}  ");
            }
            Console.Write("\nDiag-s: ");
            foreach (int i in sumDiagonal)
            {
                Console.Write($"{i}  ");
            }

            //combine all into one (minimize code for next looping)
            Array[] summary = new Array[3] { sumRow, sumCol, sumDiagonal };

            // scan for different values
            int templateValue = sumRow[0];
            foreach (Array i in summary)
            {
                foreach (int j in i)
                {
                    if (templateValue != j)
                    {
                        Console.WriteLine("\n\nThis is not magic square :(");
                        Console.WriteLine("\nPress any button...");
                        Console.ReadKey();
                        Environment.Exit(0);
                    }
                }
            }

            // if scan not failed
            Console.WriteLine("\n\nWow! You found magic square, you are so lucky!!!");
            Console.Write("\nPress any button...");
            Console.ReadKey();
        }
    }
}
