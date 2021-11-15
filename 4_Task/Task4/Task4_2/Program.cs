using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_2
{
    /* Осуществить ввод последовательности целых чисел и сравнить, что больше, количество положительных или количество отрицательных. 
     * Последовательность потенциально не ограничена, окончанием последовательности служит число 0.
     */
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = 0;
            int count = 0;
            do
            {
                Console.Write("Enter integer number: ");
                userInput = Convert.ToInt32(Console.ReadLine());
                count = (userInput > 0) ? count+1 : count-1;
            } while (userInput != 0);
            count++; // Input: 0 - decrease count of positive inputs by 1

            //Result
            string result = "";
            if (count == 0)
            {
                result = "\nNumber of positive and negative values are equal";
            }
            else
            {
                result = (count > 0) ? "\nNumber of positive values is more than negative" : "\nNumber of negative values is more than positive";
            }
            Console.WriteLine(result);
            Console.WriteLine("\nPress any button...");
            Console.ReadKey();
        }
    }
}
