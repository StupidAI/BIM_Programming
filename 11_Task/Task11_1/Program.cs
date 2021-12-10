using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11_1
{
    /*
     * Разработать структуру для решения линейного уравнения 0=kx+b. 
     * Коэффициенты уравнения k, b реализовать с помощью полей вещественного типа. 
     * Для решения уравнения предусмотреть метод Root. Создать экземпляр разработанной структуры. 
     * Осуществить использование экземпляра в программе.
     */

    class Program
    {
        static void Main(string[] args)
        {
            // option 1 -> any X
            Equation eq1 = new Equation(0, 0);
            eq1.Root();

            // option 2 -> No solution
            Equation eq2 = new Equation(0, 1);
            eq2.Root();

            // option 3 -> x = -B/K
            Equation eq3 = new Equation(1, 2);
            eq3.Root();

            // Close app
            Console.WriteLine("\nPress any button");
            Console.ReadKey();
        }
    }
}
