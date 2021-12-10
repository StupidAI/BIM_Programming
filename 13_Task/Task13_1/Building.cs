using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13_1
{
    class Building
    {
        // Constructor
        public Building(string adress, double lenght, double width, double height)
        {
            Adress = adress;
            Lenght = lenght;
            Width = width;
            Height = height;
        }

        // AutoFields
        public string Adress { get; set; }
        public double Lenght { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        // Method
        public void Print()
        {
            Console.WriteLine($"Adress: {Adress}\nLenght: {Lenght}\nWidth: {Width}\nHeight: {Height}");
        }
    }
    sealed class MultiBuilding: Building
    {
        // Constructor
        public MultiBuilding(string adress, double lenght, double width, double height, int elevation): base(adress, lenght, width, height)
        {
            Elevations = elevation;
        }

        // AutoField
        public int Elevations { get; set; }

        // Method
        public void Print()
        {
            base.Print();
            Console.WriteLine($"Elevations: {Elevations}");
        }
    }
}
