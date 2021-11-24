using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task8_1
{
    class Program
    {
        /*Обязательная задача*. Выберите любую папку на своем компьютере, имеющую вложенные директории. 
         * Выведите на консоль ее содержимое и содержимое всех подкаталогов.
         */
        static void Main(string[] args)
        {
            // path to scan
            string path = @"C:\Новая папка";
            //check if path exist
            if (Directory.Exists(path))
            {
                // get all subdir-s method
                string[] subDirs = Directory.GetDirectories(path, "**", SearchOption.AllDirectories);
                foreach (string i in subDirs)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine($"Directory {path} doesn't exist");
            }

            // waiting for user responce
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
