using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Task2_1

    // Calculate Radius and Area by given Lenght

    {
        private double length;
        private double radius;
        private double area;

        public Task2_1()
        {
            Console.Write("Enter length of circle: ");
            this.length = Convert.ToDouble(Console.ReadLine());
        }

        public void Calculate()
        {
            this.radius = this.length / (2 * Math.PI);
            this.area = Math.PI * Math.Pow(this.radius, 2);
            
            Console.WriteLine("\nRadius is: {0}\nArea is: {1}", this.radius, this.area);
            Console.WriteLine("\nPress any button...");
            Console.ReadKey();
        }
    }
}
