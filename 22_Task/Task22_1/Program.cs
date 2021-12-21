using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task22_1
{
    class Program
    {
        static int MassSumm(int[] mass)
        {
            return mass.Sum();
        }
        static int MassMax(Task<int> t, object o)
        {
            int[] mass = (int[])o;
            return mass.Max();
        }
        static void Main(string[] args)
        {
            // user input
            Console.Write("Enter mass size: ");
            int size = Convert.ToInt32(Console.ReadLine());

            // create mass storage
            int[] mass = new int[size];

            // initialize mass elements
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                mass[i] = rand.Next(0, 100);
            }

            // print mass
            string printMass = "[ ";
            foreach (int i in mass)
            {
                printMass += i + ", ";
            }
            printMass = printMass.Remove(printMass.Length - 2, 2);
            printMass += " ]";
            Console.WriteLine();
            Console.WriteLine(printMass);

            // task 1 section
            Func<int> action = new Func<int>(() => MassSumm(mass));
            Task<int> task1 = new Task<int>(action);
            task1.Start();
            Console.WriteLine($"\nTask 1: Mass summ - result is: {task1.Result}");

            // task 2 section, starts after task 1
            Func<Task<int>, object, int> action2 = new Func<Task<int>, object, int>(MassMax);
            Task<int> task2 = task1.ContinueWith<int>(action2, mass);
            Console.WriteLine($"\nTask 2: Mass max value - is: {task2.Result}");

            // close app
            Console.WriteLine("\nPress any key...");
            Console.ReadKey();
        }
    }
}
