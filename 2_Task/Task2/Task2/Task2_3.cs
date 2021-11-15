using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Task2_3

    // Calculate Perimeter and Area of triangle by given vertex point coordinates

    {
        private int point1x;
        private int point1y;
        private int point2x;
        private int point2y;
        private int point3x;
        private int point3y;
        private double perimeter;
        private double area;

        public Task2_3()
        {
            Console.Write("Enter Point 1 X: ");
            this.point1x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Point 1 Y: ");
            this.point1y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Point 2 X: ");
            this.point2x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Point 2 Y: ");
            this.point2y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Point 3 X: ");
            this.point3x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Point 3 Y: ");
            this.point3y = Convert.ToInt32(Console.ReadLine());

            // Show info about input
            Console.WriteLine("\nPoint 1: ({0},{1})", this.point1x, this.point1y);
            Console.WriteLine("Point 2: ({0},{1})", this.point2x, this.point2y);
            Console.WriteLine("Point 3: ({0},{1})", this.point3x, this.point3y);
        }

        private double DistanceFrom2Points(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
        }

        public void Calculate()
        {
            double length1 = DistanceFrom2Points(this.point1x, this.point1y, this.point2x, this.point2y);
            double length2 = DistanceFrom2Points(this.point2x, this.point2y, this.point3x, this.point3y);
            double length3 = DistanceFrom2Points(this.point3x, this.point3y, this.point1x, this.point1y);
            this.perimeter = length1 + length2 + length3;
            double halfPerimeter = this.perimeter / 2;
            this.area = Math.Sqrt(halfPerimeter * (halfPerimeter - length1) * (halfPerimeter - length2) * (halfPerimeter - length3));
            
            Console.WriteLine("\nPerimeter is: {0}\nArea is: {1}", this.perimeter, this.area);
            Console.WriteLine("\nPress any button...");
            Console.ReadKey();
        }
    }
}
