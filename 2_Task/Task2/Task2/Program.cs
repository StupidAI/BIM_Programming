using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            #region task 2.1 - Calculate Radius and Area by given Lenght
            Console.WriteLine("=== Task 2.1 ===\n");
            Task2_1 t21 = new Task2_1();
            t21.Calculate();
            #endregion

            #region task 2.2 - Calculate Perimeter and Area of rectangle by given min and max point coordinates
            Console.WriteLine("\n=== Task 2.2 ===\n");
            Task2_2 t22 = new Task2_2();
            t22.Calculate();
            #endregion
            
            #region task 2.3 - Calculate Perimeter and Area of triangle by given vertex point coordinates
            Console.WriteLine("\n=== Task 2.3 ===\n");
            Task2_3 t23 = new Task2_3();
            t23.Calculate();
            #endregion
        }
    }
}
