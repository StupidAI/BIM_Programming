using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_2
{
    /* На числовой оси расположены три точки: A, B, C. Определить, какая из двух последних точек (B или C) расположена ближе к A, 
     * и вывести эту точку и ее расстояние от точки A. Если пользователь введёт координаты B и C так, что они будут равноотстоящими от А, 
     * совпадать с А или между собой - выдать соответствующее сообщение.
     */
    class Program
    {
        static void Main(string[] args)
        {
            // input
            Console.Write("Enter Point A: ");
            int pointA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Point B: ");
            int pointB = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Point C: ");
            int pointC = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            
            // field for calculations
            int distance;

            // logic
            if (pointA == pointB && pointA == pointC && pointB == pointC)
            {
                Console.WriteLine("All points are in the same position");
            }
            else if (pointB == pointC)
            {
                distance = Math.Abs(pointA - pointB);
                Console.WriteLine($"Points B and C are in the same position" +
                                  $"\nDistance from point A is: {distance}");
            }
            else if (Math.Abs(pointA - pointB) == Math.Abs(pointA - pointC))
            {
                distance = Math.Abs(pointA - pointB);
                Console.WriteLine($"Points B and C have the same distance from point A" +
                                  $"\nDistance from point A is: {distance}");
            }
            else
            {
                if (Math.Abs(pointA - pointB) < Math.Abs(pointA - pointC))
                {
                    distance = Math.Abs(pointA - pointB);
                    Console.WriteLine($"Points B is close to point A" +
                                      $"\nDistance from point A is: {distance}");
                }
                else
                {
                    distance = Math.Abs(pointA - pointC);
                    Console.WriteLine($"Points C is close to point A" +
                                      $"\nDistance from point A is: {distance}");
                }
            }
            Console.WriteLine("\nPress any button...");
            Console.ReadKey();
        }
    }
}
