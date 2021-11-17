using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_3
{
    /* Дана строка S. Из строки требуется удалить текст, заключенный в фигурные скобки. 
     * В строке может быть несколько фрагментов, заключённых в фигурные скобки. 
     * Возможно использование вложенных фигурных скобок, необходимо, чтобы программа это учитывала.
     */
    class Program
    {
        static void Main(string[] args)
        {
            // user input
            //Console.WriteLine("Enter text:\n");
            //string text = Console.ReadLine();
            string text = "Текст1 {Дата}{{Дата}{Дата}} или {Дата}";
            string result = "";
            // delete spaces from string and convert to lower case
            string[] splited = text.Split('{');
            foreach (string s in splited)
            {
                Console.Write(s + " ");
            }
            Console.WriteLine(splited);
            Console.WriteLine("\nPress any button...");
            Console.ReadKey();
        }
    }
}
