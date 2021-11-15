using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Sum of two numbers
            Console.Write("Enter first number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int Sum = firstNumber + secondNumber;
            #endregion
            Console.WriteLine("Summ of numbers is: {0}", Sum);
            Console.WriteLine("{0} + {1} = {2}", firstNumber, secondNumber, Sum);
            Console.WriteLine("\nPress any button...");
            Console.ReadKey();

            /*
             * явное преобразование:
             * int i = 18;
             * byte b = (byte) i;
             */
        }
    }
}
