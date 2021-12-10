using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14_1
{
    /* Разработать абстрактный класс Animal, который описывает животное. Класс содержит следующие элементы:
        В классе Animal нужно определить следующие методы:
        абстрактное свойство - название животного.
        
        конструктор, устанавливающий значение по умолчанию для названия;
        абстрактный метод Say(), который выводит звук, который издает животное;
        неабстрактный метод ShowInfo(), который выводит на консоль последовательно название, а затем звук (вызывая метод Say()).
       Разработать классы Cat и Dog, которые реализуют абстрактный класс Animal. В классах реализовать следующие элементы:
        
        свойство – название животного;
        метод Say (), выводящий на экран «Мяу» либо «Гав» соответственно.
       Создайте экземпляры классов Cat и Dog и проверьте их работоспособность.
     */
    class Program
    {
        static void Main(string[] args)
        {
            // Dog instance
            Dog dog1 = new Dog("Charlie");
            dog1.ShowInfo();

            // Cat instance
            Cat cat1 = new Cat("Ally");
            cat1.ShowInfo();

            // close app
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}
