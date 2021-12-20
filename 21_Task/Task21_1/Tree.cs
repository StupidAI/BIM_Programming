using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task21_1
{
    // represent tree
    public class Tree : Object
    {
        public string Symbol { get; set; } // 0 - not a tree, 1 - planned tree
        public Worker Role { get; set; } // store info about worker
        public Tree(Worker w) // constructor
        {
            Role = w;
            Symbol = "0";
        }
        // every tree know about worker that plant it
        public void SetWorker(Worker w)
        {
            if (Symbol != "0")
            {
                Role = w;
            }
        }
        // for Console.Write view
        public override string ToString()
        {
            return Symbol;
        }
    }
}
