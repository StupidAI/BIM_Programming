using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_1
{
    /* Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом. 
     * Знаки препинания не используются. Найти самое длинное слово в строке.
     */
    class Program
    {
        static void Main(string[] args)
        {
            // user input
            Console.WriteLine("Enter text:\n");
            string text = Console.ReadLine();
            // split phrase to words
            string[] words = text.Split();
            // find longest
            string longest = "";
            foreach (string s in words)
            {
                longest = (longest.Length < s.Length) ? s : longest;
            }
            // output
            Console.WriteLine($"\nLongest word is: {longest}");
            Console.WriteLine("\nPress any button...");
            Console.ReadKey();
        }
    }
}
