using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task19_1
{
    class Computer
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string CPU { get; set; }
        public int ClockSpeed { get; set; }
        public int RAM { get; set; }
        public int HDD { get; set; }
        public int VGA { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public void GetInfo()
        {
            Console.WriteLine($"{Code} / {Name} / {CPU} / {ClockSpeed} / {RAM} / {HDD} / {VGA} / {Price} / {Count}");
        }
    }
}
