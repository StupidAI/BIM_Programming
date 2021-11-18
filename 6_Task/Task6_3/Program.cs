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
            string text = "";
            bool userInput = false;
            #region Region for tests
            Console.WriteLine("Enter unit test number: ");
            Console.WriteLine("1\ttext \t-> \t>>>text<<<");
            Console.WriteLine("2\t{data} \t-> \t>>><<<");
            Console.WriteLine("3\ttext {data} \t-> \t>>>text<<<");
            Console.WriteLine("4\t{data} text \t-> \t>>>text<<<");
            Console.WriteLine("5\t{data1} {data2} \t-> \t>>><<<");
            Console.WriteLine("6\ttext {data1 {data2}} \t-> \t>>>text<<<");
            Console.WriteLine("7\ttext {{data1} data2} \t-> \t>>>text<<<");
            Console.WriteLine("8\ttext {{data1} data2} \t-> \t>>>text<<<");
            Console.WriteLine("9\ttext {{data1} data2} \t-> \t>>>text<<<");
            Console.WriteLine("...or any for custom text...");
            string n = Console.ReadLine();
            switch (n)
            {
                case "1":
                    text = "text";
                    Console.WriteLine($"Test text is: {text}\nExpect result is: >>>text<<<");
                    break;
                case "2":
                    text = "{data}";
                    Console.WriteLine($"Test text is: {text}\nExpect result is: >>><<<");
                    break;
                case "3":
                    text = "text {data}";
                    Console.WriteLine($"Test text is: {text}\nExpect result is: >>>text<<<");
                    break;
                case "4":
                    text = "{data} text";
                    Console.WriteLine($"Test text is: {text}\nExpect result is: >>>text<<<");
                    break;
                case "5":
                    text = "{data1} {data2}";
                    Console.WriteLine($"Test text is: {text}\nExpect result is: >>><<<");
                    break;
                case "6":
                    text = "text {data1 {data2}}";
                    Console.WriteLine($"Test text is: {text}\nExpect result is: >>>text<<<");
                    break;
                case "7":
                    text = "text {{data1} data2}";
                    Console.WriteLine($"Test text is: {text}\nExpect result is: >>>text<<<");
                    break;
                case "8":
                    text = "text {{data1} data2}";
                    Console.WriteLine($"Test text is: {text}\nExpect result is: >>>text<<<");
                    break;
                case "9":
                    text = "text {{data1} data2}";
                    Console.WriteLine($"Test text is: {text}\nExpect result is: >>>text<<<");
                    break;
                default:
                    userInput = true;
                    break;
            }
            #endregion

            // user input
            if (userInput)
            {
                Console.WriteLine("Enter text:\n");
                text = Console.ReadLine();
            }

            bool skipFlag = false; // if true append char to result, else skip char
            int skipCount = 0; // count of open bracket
            string result = "";
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '{')
                {
                    skipFlag = true;
                    skipCount++;
                }
                if (text[i] == '}')
                {
                    skipCount--;
                    skipFlag = (skipCount == 0) ? false : true;
                    continue;
                }
                if (skipFlag == false && skipCount == 0)
                {
                    result += text[i];
                }
            }
            //remove start and end spaces
            result = result.Trim();
            // print result
            Console.WriteLine($"\nResult is: >>>{result}<<<");
            Console.WriteLine("\nPress any button...");
            Console.ReadKey();
        }
    }
}
