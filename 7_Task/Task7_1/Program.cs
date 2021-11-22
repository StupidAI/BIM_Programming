using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_1
{
    class Program
    {
        /* Два треугольника заданы длинами своих сторон. Определить, площадь какого из них больше 
        * (создать метод для вычисления  площади  треугольника по длинам его сторон).  
        * Для решения задачи можно использовать формулу Герона.
        */
        static void Main(string[] args)
        {
            // input: 1 triangle
            Console.WriteLine($"First triangle\n");
            double[] triangleFirst = Input();
            Console.WriteLine($"\nFirst area is: {Area(triangleFirst)}");
            Console.WriteLine();

            // input: 2 triangle
            Console.WriteLine($"Second triangle\n");
            double[] triangleSecond = Input();
            Console.WriteLine($"\nSecond area is: {Area(triangleSecond)}");
            Console.WriteLine();

            // compare areas and set output message
            string result = "";
            if (Area(triangleFirst) == Area(triangleSecond))
            {
                result = "Area of triangles are aquals";
            }
            else if (Area(triangleFirst) > Area(triangleSecond))
            {
                result = "Area of first triangle is larger than second";
            }
            else
            {
                result = "Area of second triangle is larger than first";
            }

            //output
            Output(result);
        }
        static double Area(double[] a)
        {
            double halfPerimeter = a.Sum() / 2;
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - a[0]) * (halfPerimeter - a[1]) * (halfPerimeter - a[2]));
            return area;
        }
        // assumption: user inputs are correct and triangle is exist
        static double[] Input()
        {
            double[] result = new double[3];
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write($"Enter length of {i+1} side: ");
                result[i] = Convert.ToDouble(Console.ReadLine());
            }
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
