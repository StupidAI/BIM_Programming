using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task19_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Computer> pcList = new List<Computer>
            {
                new Computer() {Code = "3", Name = "LowCost 3", CPU = "Itel Core i3", ClockSpeed = 3400, RAM = 16, HDD = 256, VGA = 4, Price = 700, Count = 100 },
                new Computer() {Code = "5", Name = "MidCost 2", CPU = "Itel Core i5", ClockSpeed = 3800, RAM = 16, HDD = 512, VGA = 6, Price = 900, Count = 60 },
                new Computer() {Code = "2", Name = "LowCost 2", CPU = "Itel Core i3", ClockSpeed = 3200, RAM = 8, HDD = 256, VGA = 2, Price = 600, Count = 200 },
                new Computer() {Code = "7", Name = "HighCost 1", CPU = "Itel Core i7", ClockSpeed = 4200, RAM = 32, HDD = 1024, VGA = 8, Price = 1200, Count = 5 },
                new Computer() {Code = "8", Name = "HighCost 2", CPU = "Itel Core i9", ClockSpeed = 4400, RAM = 64, HDD = 1024, VGA = 12, Price = 1500, Count = 5 },
                new Computer() {Code = "4", Name = "MidCost 1", CPU = "Itel Core i5", ClockSpeed = 3600, RAM = 16, HDD = 512, VGA = 6, Price = 800, Count = 100 },
                new Computer() {Code = "1", Name = "LowCost 1", CPU = "Itel Core i3", ClockSpeed = 3000, RAM = 8, HDD = 256, VGA = 1, Price = 500, Count = 200 },
                new Computer() {Code = "6", Name = "MidCost 3", CPU = "Itel Core i5", ClockSpeed = 4000, RAM = 32, HDD = 512, VGA = 8, Price = 1000, Count = 50 },
            };
            #region case1
            //Case 1: Find by CPU
            Console.WriteLine("=== Find by CPU ===\n");
            Console.Write("Please enter CPU name: ");
            string question = Console.ReadLine();
            var result = pcList.Where(q => q.CPU.Contains(question));
            Console.WriteLine("\nList:");
            foreach (var i in result)
            {
                i.GetInfo();
            }

            //close app
            Console.WriteLine("\nPress any key...");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region case2
            //Case 2: Find by RAM range
            Console.WriteLine("=== Find by RAM ===\n");
            Console.Write("Please enter min value of RAM: ");
            int question2 = Convert.ToInt32(Console.ReadLine());
            result = pcList.Where(q => q.RAM >= question2);
            Console.WriteLine("\nList:");
            foreach (var i in result)
            {
                i.GetInfo();
            }

            //close app
            Console.WriteLine("\nPress any key...");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region case3
            //Case 3: Sort by Price
            Console.WriteLine("=== Sort by Price (From high to low) ===\n");
            result = pcList.OrderByDescending(q => q.Price);
            Console.WriteLine("List:");
            foreach (var i in result)
            {
                i.GetInfo();
            }

            //close app
            Console.WriteLine("\nPress any key...");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region case4
            //Case 4: Group by CPU
            Console.WriteLine("=== Group by CPU ===\n");
            var groupByCPU = pcList.GroupBy(q => q.CPU);
            Console.WriteLine("List:");
            foreach (var i in groupByCPU)
            {
                Console.WriteLine(i.Key);
                foreach (var j in i)
                {
                    Console.Write("\t");
                    j.GetInfo();
                }
                Console.WriteLine();
            }

            //close app
            Console.WriteLine("\nPress any key...");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region case5
            //Case 5: most expensive / cheap PCs
            Console.WriteLine("=== Most expensive / cheap PC ===\n");

            // first variant
            Console.WriteLine("Max price:");
            var max = pcList.OrderBy(q => q.Price).First();
            max.GetInfo();
            Console.WriteLine("\nMin price:");
            var min = pcList.OrderBy(q => q.Price).Last();
            min.GetInfo();

            // second variant
            //var max = pcList.Where(r => r.Price == pcList.Max(q => q.Price));
            //var min = pcList.Where(r => r.Price == pcList.Min(q => q.Price));
            //Console.WriteLine("List max:");
            //foreach (var i in max)
            //{
            //    i.GetInfo();
            //}
            //Console.WriteLine("\nList min:");
            //foreach (var i in min)
            //{
            //    i.GetInfo();
            //}

            //close app
            Console.WriteLine("\nPress any key...");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region case6
            //Case 6: Count > 30
            Console.WriteLine("=== Find by count above 30 ===\n");
            bool test = pcList.Any(q => q.Count > 30);
            if (test)
            {
                int count = pcList.Where(q => q.Count > 30).Count();
                Console.WriteLine($"\nList contsains {count} elements with amount more than 30");
            }
            else
            {
                Console.WriteLine($"\nList doesn't contsains elements with amount more than 30");
            }

            //close app
            Console.WriteLine("\nPress any key...");
            Console.ReadKey();
            Console.Clear();
            #endregion
        }
    }
}
