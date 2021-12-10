using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12_1
{
    /* Разработать статический класс для работы с окружностью. Класс должен содержать 3 метода:
            метод, определяющий длину окружности по заданному радиусу;
            метод, определяющий площадь круга по заданному радиусу;
            метод, проверяющий принадлежность точки с координатами (x,y) кругу с радиусом r и координатами центра x0, y0.
     */
    static class Circle
    {
        public static double LenghtByRadius(double r)
        {
            return (2 * Math.PI * r);
        }
        public static double AreaByRadius(double r)
        {
            return (Math.PI * Math.Pow(r, 2));
        }
        public static bool IsPointOnCircle(double x, double y, double r, double x0, double y0)
        {
            // calculate radius^2 of circle by given x, y, x0, y,0
            double r2Fact = Math.Pow(x - x0, 2) + Math.Pow(y - y0, 2);
            // compare calculated value with given
            if (r*r != r2Fact)
            {
                return false;
            }
            return true;
        }
    }
}
