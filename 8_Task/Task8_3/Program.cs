using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task8_3
{
    class Program
    {
        /* Вручную подготовьте текстовый файл с фрагментом текста. Напишите программу, 
         * которая выводит статистику по файлу - количество символов, строк и слов в тексте.
         */
        static void Main(string[] args)
        {
            // set file path
            string path = @"C:\Task8_3\sample.txt";

            // read data line by line - better for memory usage
            using (StreamReader sr = new StreamReader(path))
            {
                // fields for stats
                int numRows = 0;
                int numSymb = 0;
                int numWords = 0;

                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    numSymb += line.Length;
                    numWords += line.Split().Length;
                    numRows++;
                }

                // result
                Console.WriteLine($"Number of rows is: {numRows}\n" +
                                  $"Number of words is: {numWords}\n" +
                                  $"Number of symbols (include spaces) is: {numSymb}");
            }

            // waiting for user responce
            Console.WriteLine("\nPress any key...");
            Console.ReadKey();
        }
    }
}
