using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // circle lenght and area
            double r = 5;
            Console.WriteLine($"Lenght of circle with r = {r}: {Circle.LenghtByRadius(r)}");
            Console.WriteLine($"Area of circle with r = {r}: {Circle.AreaByRadius(r)}");
            Console.WriteLine();

            // check point on circle -> true
            double x = 10;
            double y = 0;
            double x0 = 5;
            double y0 = 0;
            Console.WriteLine($"Point: x = {x}, y = {y}\nCircle: r = {r}, x0 = {x0}, y0 = {y0}");
            if (Circle.IsPointOnCircle(x, y, r, x0, y0))
            {
                Console.WriteLine("Point - belongs to circle");
            }
            else
            {
                Console.WriteLine("Point - don't belongs to circle");
            }
            Console.WriteLine();

            // check point on circle -> false
            x = 1;
            y = 5;
            x0 = 5;
            y0 = 0;
            Console.WriteLine($"Point: x = {x}, y = {y}\nCircle: r = {r}, x0 = {x0}, y0 = {y0}");
            if (Circle.IsPointOnCircle(x, y, r, x0, y0))
            {
                Console.WriteLine("Point - belongs to circle");
            }
            else
            {
                Console.WriteLine("Point - don't belongs to circle");
            }
            Console.WriteLine();

            // close app
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
