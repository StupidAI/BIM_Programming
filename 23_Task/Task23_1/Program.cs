using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task23_1
{
    class Program
    {
        /* Разработать асинхронный метод для вычисления факториала числа. В методе Main выполнить проверку работы метода.
         */
        static void Main(string[] args)
        {
            //user input
            Console.Write("Enter number: ");
            int factor = Convert.ToInt32(Console.ReadLine());

            //create and run task1
            FactorAsync(factor, "Task 1");

            //create and run task2
            FactorAsync(factor, "Task 2");

            // main task
            Console.WriteLine("==> Sum calculation started in Main");
            int sum = Summ(factor, "Task 3");

            //close app
            Console.WriteLine("\nPress any key...");
            Console.ReadKey();
        }
        // method for n! calculations
        static int Factor(int n, string name)
        {
            int result = 1;
            for (int i = 1; i < n + 1; i++)
            {
                result *= i;
                Console.WriteLine($"{name} - Iteration {i}: {result / i} * {i} = {result}");
                Thread.Sleep(500);
            }
            return result;
        }
        // method for sum calculations
        static int Summ(int n, string name)
        {
            int result = 1;
            for (int i = 1; i < n + 1; i++)
            {
                result += i;
                Console.WriteLine($"{name} - Iteration {i}: {result / i} + {i} = {result}");
                Thread.Sleep(500);
            }
            Console.WriteLine($"{name} - Method Summ: Calculation complete...\nSum = {result} <==");
            return result;
        }
        // async method that starts factorial calculations
        static async Task<int> FactorAsync(int n, string name)
        {
            Console.WriteLine($"==> {name} - Method FactorAsync: Async factor calculation start...");
            int result = await Task.Run(() => Factor(n, name));
            Console.WriteLine($"{name} - Method FactorAsync: Calculation complete... \n{n}! = {result} <==");
            return result;
        }
    }
}
