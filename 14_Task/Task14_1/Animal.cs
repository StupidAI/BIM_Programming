using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14_1
{
    abstract class Animal
    {
        // constructor
        protected Animal(string name)
        {
            Name = name;
        }

        // property
        public abstract string Name { get; set; }

        // methods
        public abstract void Say();
        public void ShowInfo()
        {
            Console.WriteLine($"My name is {Name}");
            this.Say();
        }
    }
    class Dog :  Animal
    {
        // constructor
        public Dog(string name) : base(name) { }

        // fields with get / set options
        private string name;
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        // overrided method Say from base class
        public override void Say()
        {
            Console.WriteLine("WUF!");
        }
    }

    class Cat : Animal
    {
        // constructor
        public Cat(string name) : base(name) { }

        // fields with get / set options
        private string name;
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        // overrided method Say from base class
        public override void Say()
        {
            Console.WriteLine("Mew...");
        }
    }
}
