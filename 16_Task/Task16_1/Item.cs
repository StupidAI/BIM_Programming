using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task16_1
{
    public class Item
    {
        public Item() // default constructor for Task16_2
        {
            Code = 0;
            Name = "";
            Price = 0;
        }
        public Item(int code, string name, double price)
        {
            Code = code;
            Name = name;
            Price = price;
        }

        public int Code { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
