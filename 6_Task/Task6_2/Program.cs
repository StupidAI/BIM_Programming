using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6_2
{
    /* Ввести с клавиатуры предложение. Предложение представляет собой слова, разделенные пробелом. 
     * Знаки препинания не используются. Составить программу, определяющую является ли строка палиндромом без учёта пробелов и регистра 
     * (пример палиндрома – «А роза упала на лапу Азора»).
    */
    class Program
    {
        static void Main(string[] args)
        {
            // user input
            Console.WriteLine("Enter text:\n");
            string text = Console.ReadLine();
            // delete spaces from string and convert to lower case
            text = text.Replace(" ", "").ToLower();
            // convert test to array for reversing. Array class contains such method
            char[] normalString = text.ToCharArray();
            //we should clone array because of it is linked type of data
            char[] reversedString = (char[])normalString.Clone();
            Array.Reverse(reversedString);
            //convert array to string
            string reversedText = new String(reversedString);
            // print info
            Console.WriteLine("\nFirst text compare to reversed text:\n");
            Console.WriteLine(text);
            Console.WriteLine(reversedText);
            // compare two strings and print answer
            if (text == reversedText)
            {
                Console.WriteLine("\nThis is polindrome");
            }
            else
            {
                Console.WriteLine("\nThis is not polindrome");
            }
            Console.WriteLine("\nPress any button...");
            Console.ReadKey();
        }
    }
}
