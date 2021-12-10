using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task13_1
{
    /* Задан класс Building, который описывает здание. Класс содержит следующие элементы:
            адрес здания;
            длина здания;
            ширина здания;
            высота здания.
        В классе Building нужно реализовать следующие методы:
            конструктор с 4 параметрами;
            свойства get/set для доступа к полям класса;
            метод Print(), который выводит информацию о здании.
        Разработать класс MultiBuilding, который наследует возможности класса Building и добавляет поле этажность. 
        В классе MultiBuilding реализовать следующие элементы:
            конструктор с 5 параметрами – реализует вызов конструктора базового класса;
            свойство get/set доступа к внутреннему полю класса;
            метод Print(), который обращается к методу Print() базового класса Building для вывода информации о всех полях класса.
        Класс MultiBuilding сделать таким, что не может быть унаследован.
     */
    class Program
    {
        static void Main(string[] args)
        {
            // user input
            Console.WriteLine("=== Pleace enter data ===");
            Console.Write("Adress: ");
            string adress = Console.ReadLine();
            Console.Write("Lenght: ");
            double lenght = Convert.ToDouble(Console.ReadLine());
            Console.Write("Width: ");
            double width = Convert.ToDouble(Console.ReadLine());
            Console.Write("Height: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.Write("Elevations: ");
            int elevations = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            // create instance of Building Class
            Console.WriteLine($"=== Class Building: ===");
            Building b = new Building(adress, lenght, width, height);
            b.Print();
            Console.WriteLine();

            // create instance of MultiBuilding Class
            Console.WriteLine($"=== Class MultiBuilding : ===");
            MultiBuilding mb = new MultiBuilding(adress, lenght, width, height, elevations);
            mb.Print();
            Console.WriteLine();

            // close app
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
