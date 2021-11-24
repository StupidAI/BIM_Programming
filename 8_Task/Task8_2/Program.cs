using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task8_2
{
    class Program
    {
        /* Обязательная задача*. Программно создайте текстовый файл и запишите в него 10 случайных чисел. 
         * Затем программно откройте созданный файл, рассчитайте сумму чисел в нем, ответ выведите на консоль.
         */
        static void Main(string[] args)
        {
            // name builder for files: 
            string time = DateTime.Now.ToString("yyMMdd_HHmmss");
            string path = @"C:\Task8_2"; // there can be check if foldier esist
            string filePrefix = @"\Task8_2_";
            string fileSuffix = ".txt";
            string fullPath = path + filePrefix + time + fileSuffix;

            // create new file and close process for next modifications
            File.Create(fullPath).Close();

            // whrite to file numbers
            Random randomNum = new Random();
            using (StreamWriter sw = new StreamWriter(fullPath))
            {
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(randomNum.Next(10));
                }
            }

            // read data line by line - better for memory usage and display summ
            using (StreamReader sr = new StreamReader(fullPath, Encoding.UTF8))
            {
                int sum = 0;
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    sum += Convert.ToInt32(line);
                }
                Console.WriteLine($"Sum of numbers in file is: {sum}");
            }

            // waiting for user responce
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
