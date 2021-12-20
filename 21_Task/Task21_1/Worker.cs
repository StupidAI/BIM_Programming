using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task21_1
{
    // represent worker
    public class Worker
    {
        public ConsoleColor Color { get; } // every worker have their own color and name
        public string Name { get; set; }
        // constructors
        public Worker() //default constructor
        {
            Color = ConsoleColor.Gray;
            Name = "NoName";
        }
        public Worker(ConsoleColor c, string n) // constructor with color and name
        {
            Color = c;
            Name = n;
        }
    }
}
