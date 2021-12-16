using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task20_1
{
    /* В приложении объявить тип делегата, который ссылается на метод. Требования к сигнатуре метода следующие:
        - метод получает входным параметром переменную типа double;
        - метод возвращает значение типа double, которое является результатом вычисления.
       Реализовать вызов методов с помощью делегата, которые получают радиус R и вычисляют:
        - длину окружности по формуле D = 2 * π* R;
        - площадь круга по формуле S = π* R²;
        - объем шара. Формула V = 4/3 * π * R³.
       Методы должны быть объявлены как статические. */
    class Program
    {
        // create delegate definition
        delegate double CircleCalc(double r);
        static void Main(string[] args)
        {
            // user input
            Console.Write("Enter circle Radius: ");
            double r = Convert.ToDouble(Console.ReadLine());

            // create delegate instance
            CircleCalc cc;

            // create fields for result
            double length = 0;
            double area = 0;
            double volume = 0;

            // set to delegate method Lenght and calcilate it
            cc = Length;
            length = cc(r);

            // set to delegate method Area and calcilate it
            cc = Area;
            area = cc(r);

            // set to delegate method Volume and calcilate it
            cc = Volume;
            volume = cc(r);

            // print result
            Result(length, area, volume);

            // close app
            Console.WriteLine("\nPress any key...");
            Console.ReadKey();

            // lambda solution
            Console.Clear();
            Console.WriteLine("=== Task solution with lambda ===\n");

            // user input
            Console.Write("Enter circle Radius: ");
            r = Convert.ToDouble(Console.ReadLine());

            // calculations with lambda
            cc = i => Math.PI * i * 2;
            length = cc(r);

            cc = i => Math.PI * i * i;
            area = cc(r);

            cc = i => Math.PI * Math.Pow(r, 3) * 4 / 3;
            volume = cc(r);

            // print result
            Result(length, area, volume);

            // close app
            Console.WriteLine("\nPress any key...");
            Console.ReadKey();
        }
        static double Length (double r)
        {
            //Console.WriteLine("Length calculating...");
            return Math.PI * r * 2;
        }
        static double Area (double r)
        {
            //Console.WriteLine("Area calculating...");
            return Math.PI * r * r;
        }
        static double Volume (double r)
        {
            //Console.WriteLine("Volume calculating...");
            return Math.PI * Math.Pow(r, 3) * 4/3;
        }
        static void Result (double l, double a, double v)
        {
            Console.WriteLine($"\nLength is: {l}\nArea is: {a}\nVolume is: {v}");
        }
        
    }
}
 