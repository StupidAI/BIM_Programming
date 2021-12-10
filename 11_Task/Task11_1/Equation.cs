using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11_1
{
    struct Equation
    {
        // Autofields
        public double K { get; set; }
        public double B { get; set; }

        // Constructor
        public Equation(double k, double b)
        {
            this.K = k;
            this.B = b;
        }

        //Method for solving equation
        public void Root()
        {
            if (K == 0 && B == 0)
            {
                Console.WriteLine("X : can be any number");
            }
            if (K == 0 && B != 0)
            {
                Console.WriteLine("There is no solution");
            }
            if (K!=0)
            {
                Console.WriteLine($"0 = {K} * x + {B} -> x = {-B/K}");
            }
        }
    }
}
