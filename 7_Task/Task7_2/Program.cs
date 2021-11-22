using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_2
{
    /* Обязательная задача*. Создать метод для вычисления объема и площади поверхности куба по длине его ребра.
     */
    class Program
    {
        static void Main(string[] args)
        {
            double squre, volume;
            cubeParams(Input(), out squre, out volume);
            Output($"Squre is: {squre}\nVolume is: {volume}");
        }
        // Calculations
        static void cubeParams(double a, out double S, out double V)
        {
            S = Math.Pow(a, 2) * 6;
            V = Math.Pow(a, 3);
        }
        // assumption: user inputs is correct: numbers > 0
        static double Input()
        {
            Console.Write($"Enter length of cube side: ");
            double result = Convert.ToDouble(Console.ReadLine());
            return result;
        }
        static void Output(string s)
        {
            Console.WriteLine("\n" + s);
            Console.WriteLine("\nPress any button...");
            Console.ReadKey();
        }
    }
}
