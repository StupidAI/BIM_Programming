using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Task2_2

    // Calculate Perimeter and Area of rectangle by given min and max point coordinates

    {
        private int point1x;
        private int point1y;
        private int point2x;
        private int point2y;
        private int perimeter;
        private int area;

        public Task2_2()
        {
            Console.Write("Enter Point 1 X: ");
            this.point1x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Point 1 Y: ");
            this.point1y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Point 2 X: ");
            this.point2x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Point 2 Y: ");
            this.point2y = Convert.ToInt32(Console.ReadLine());

            // Show info about input
            Console.WriteLine("\nPoint 1: ({0},{1})", this.point1x, this.point1y);
            Console.WriteLine("Point 2: ({0},{1})", this.point2x, this.point2y);
        }

        public void Calculate()
        {
            this.perimeter = (Math.Abs(this.point1x - this.point2x) + Math.Abs(this.point1y - this.point2y)) * 2;
            this.area = Math.Abs(this.point1x - this.point2x) * Math.Abs(this.point1y - this.point2y);
            
            Console.WriteLine("\nPerimeter is: {0}\nArea is: {1}", this.perimeter, this.area);
            Console.WriteLine("\nPress any button...");
            Console.ReadKey();
        }
    }
}
