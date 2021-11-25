using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10_1
{
    class Program
    {
        /* Угол задан с помощью целочисленных значений gradus - градусов, min - угловых минут, sec - угловых секунд. 
         * Реализовать класс, в котором указанные значения представлены в виде свойств. 
         * Для свойств предусмотреть проверку корректности данных. Класс должен содержать конструктор для установки 
         * начальных значений, а также метод ToRadians для перевода угла в радианы. Создать объект на основе разработанного 
         * класса. Осуществить использование объекта в программе.
         */
        static void Main(string[] args)
        {
            // create 2 insnses of class with constructor
            Angle a1 = new Angle(50, 1, 31);
            Angle a2 = new Angle(50, 59, 30);

            // find sum of 2 angles
            Angle a3 = a1 + a2;

            // print result
            Console.WriteLine($"Angle 1 is : {a1}");
            Console.WriteLine($"Angle 2 is : {a2}");
            Console.WriteLine();
            Console.WriteLine($"Angle 1 + Angle 2 is : {a3}");
            Console.WriteLine("\nPress any button...");
            Console.ReadKey();
        }
    }
}
