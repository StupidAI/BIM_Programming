using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_1
{
    /* Ввести целочисленные координаты трех вершин прямоугольника, стороны которого параллельны координатным осям. 
    * Найти координаты его четвертой вершины. Если пользователь введёт координаты точек так, что нельзя получить прямоугольник со сторонами, 
    * параллельными координатным осям, вывести соответствующее сообщение. 
    * 
    * Negative inputs:
    *   - 2 points are in the same position
    *   - 3 points are in one line by X axis
    *   - 3 points are in one line by Y axis
    *   - points are not in vertex of rectangle
    *   
    * Positive input:
    *   There is 2 pairs of equal X and Y exist. It means that 2 points from input have same X and 2 points from input have same Y
    *   
    */
    class Program
    {
        static void Main(string[] args)
        {
            // method checks if 2 point are in same position
            bool CheckPoints(int x1, int y1, int x2, int y2)
            {
                if (x1 == x2 && y1 == y2)
                {
                    Console.WriteLine("Input is not correct: two points are in the same position");
                    Console.WriteLine("\nPress any key...");
                    Console.ReadKey();
                    return true;
                }
                else
                {
                    return false;
                }
            }

            //input 1st and 2nd point
            Console.Write("Enter Point 1 X: ");
            int point1x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Point 1 Y: ");
            int point1y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Point 2 X: ");
            int point2x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Point 2 Y: ");
            int point2y = Convert.ToInt32(Console.ReadLine());
            
            // check for overlaping
            if (CheckPoints(point1x, point1y, point2x, point2y))
            {
                Environment.Exit(0);
            }
            
            // input 3rd point
            Console.Write("Enter Point 3 X: ");
            int point3x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Point 3 Y: ");
            
            // check for overlaping
            int point3y = Convert.ToInt32(Console.ReadLine());
            if (
                CheckPoints(point1x, point1y, point3x, point3y) || 
                CheckPoints(point2x, point2y, point3x, point3y)
                )
            {
                Environment.Exit(0);
            }

            // create fields for 4th point
            int point4x;
            int point4y;

            // Input summary
            Console.WriteLine($"\nPoint 1: ({point1x},{point1y})");
            Console.WriteLine($"Point 2: ({point2x},{point2y})");
            Console.WriteLine($"Point 3: ({point3x},{point3y})");

            // check if all points locate in one line - not correct
            if (
                (point1x == point2x && point2x == point3x && point3x == point1x) || 
                (point1x == point2y && point2y == point3y && point3y == point1y)
                )
            {
                Console.WriteLine("\nInput is not correct: all points are in one line");
            }

            // check for pairs of coordinates are exist
            else if (
                    (point1x == point2x || point2x == point3x || point3x == point1x) &&
                    (point1y == point2y || point2y == point3y || point3y == point1x)
                    )
            {
                // find position of 4th point
                if (point1x == point2x)
                {
                    point4x = point3x;
                    point4y = (point3y == point1y) ? point2y : point1y;
                }
                else if (point1x == point3x)
                {
                    point4x = point2x;
                    point4y = (point2y == point1y) ? point3y : point1y;
                }
                else
                {
                    point4x = point1x;
                    point4y = (point1y == point2y) ? point3y : point2y;
                }
                Console.WriteLine($"\nPoint 4: ({point4x},{point4y})");
            }

            // points are not in vertices of rectangle because they have no 2 pairs of X and Y coordinates
            else Console.WriteLine("\nInput is not correct: points are not in vertices of rectangle");
            Console.WriteLine("\nPress any key...");
            Console.ReadKey();
        }
    }
}
