using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_3
{
    /* Ввести положительные числа A, B, C. На прямоугольнике размера A x B размещено максимально возможное количество квадратов со стороной C 
     * (без наложений). Найти количество квадратов, размещенных на прямоугольнике. Операции умножения и деления не использовать.
     * 
     * Possible situations:
     * A or B or A,B < C -> result: 0
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 positive numbers");
            Console.Write("A : ");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.Write("B : ");
            double B = Convert.ToDouble(Console.ReadLine());
            Console.Write("C : ");
            double C = Convert.ToDouble(Console.ReadLine());
            int count = 0;
            string result = "";

            if (A < C || B < C)
            {
                result = "\nThere is not possible to place a sqare inside rectangle. Result is 0";
            }
            else
            {
                while (A>0)
                {
                    double temp = B;
                    while (temp > 0)
                    {
                        temp -= C;
                        count++;
                    }
                    A -= C;
                }
                result = "\nResult is : " + count;
            }

            //Output
            Console.WriteLine(result);
            Console.WriteLine("\nPress any button...");
            Console.ReadKey();
        }
    }
}
