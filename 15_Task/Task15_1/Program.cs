using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task15_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // method for testing progression
            void RunProgression(ISeries a, int num)
            {
                Console.WriteLine("Run progression...");
                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine($"Step {i + 1}: " + a.getNext());
                }
            }

            #region ArithProgression
            // User input - ArithProgression
            Console.WriteLine("=== ArithProgression ===");
            Console.Write($"Enter start value: ");
            int sv = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter delta: ");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter number of iterations: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // Create progression and run it N times
            ArithProgression ap1 = new ArithProgression(sv, d);
            RunProgression(ap1, n);

            // set new start value and run N times
            Console.Write($"\nEnter start value one more time: ");
            sv = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Delta: {d}");
            ap1.setStart(sv);
            ap1.reset();
            Console.WriteLine();
            RunProgression(ap1, n);
            #endregion

            #region GeomProgression
            // User input GeomProgression
            Console.WriteLine("\n=== GeomProgression ===");
            Console.Write($"Enter start value: ");
            sv = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter delta: ");
            d = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter number of iterations: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // Create progression and run it N times
            GeomProgression gp1 = new GeomProgression(sv, d);
            RunProgression(gp1, n);
            Console.WriteLine();

            // set new start value and run N times
            Console.Write($"Enter start value one more time: ");
            sv = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Delta: {d}");
            gp1.setStart(sv);
            gp1.reset();
            Console.WriteLine();
            RunProgression(gp1, n);
            #endregion

            // close app
            Console.WriteLine("\nPress any key...");
            Console.ReadKey();
        }
    }
}
