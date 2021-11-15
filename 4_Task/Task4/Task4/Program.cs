using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_1
{
    /* Обязательная задача*. Ввести целое число N > 0. Найти квадрат данного числа, используя для его вычисления следующую формулу: 
     * N2=1 + 3 + 5 + ... + (2*N – 1). После добавления к сумме каждого слагаемого выводить текущее значение суммы 
     * (в результате будут выведены квадраты всех целых чисел от 1 до N).
     */
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Console.Write("Enter integer number N > 0: ");
            int N = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                sum += 2 * i - 1;
                Console.WriteLine($"Sum {i}: {sum}");
            }

            Console.WriteLine("\nPress any key...");
            Console.ReadKey();
        }
    }
}
