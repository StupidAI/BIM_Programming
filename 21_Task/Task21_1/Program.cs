using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task21_1
{
    /* Имеется пустой участок земли (двумерный массив) и план сада, который необходимо реализовать. 
     * Эту задачу выполняют два садовника, которые не хотят встречаться друг с другом. 
     * Первый садовник начинает работу с верхнего левого угла сада и перемещается слева направо, 
     * сделав ряд, он спускается вниз. Второй садовник начинает работу с нижнего правого угла сада и 
     * перемещается снизу вверх, сделав ряд, он перемещается влево. Если садовник видит, что участок сада 
     * уже выполнен другим садовником, он идет дальше. Садовники должны работать параллельно. 
     * Создать многопоточное приложение, моделирующее работу садовников.
     */
    class Program
    {
        // method for multithreading
        static void Planting(Site s, Worker w, int option)
        {
            switch (option) // 0 - worker move from left to right, 1 - worker move downt to top
            {
                case 0:
                    for (int i = 0; i < s.Width; i++)
                    {
                        for (int j = 0; j < s.Length; j++)
                        {
                            if (s[i, j].Role.Name == "NoName") // check if tree already plant by someone. NoName - is designer, just planned 
                            {
                                s[i, j].SetWorker(w);
                                Thread.Sleep(1);
                            }
                        }
                    }
                    break;
                default:
                    for (int i = s.Length - 1; i >= 0; i--)
                    {
                        for (int j = s.Width - 1; j >= 0; j--)
                        {
                            if (s[j, i].Role.Name == "NoName") // check if tree already plant by someone. NoName - is designer, just planned 
                            {
                                s[j, i].SetWorker(w);
                                Thread.Sleep(1);
                            }
                        }
                    }
                    break;
            }
        }

        static void Main(string[] args)
        {
            // create workers
            Worker designer = new Worker(); // default worker need for site initialization. Create map with planned trees
            Worker worker1 = new Worker(ConsoleColor.Green, "Ivan"); // first worker
            Worker worker2 = new Worker(ConsoleColor.Red, "Petr"); // second worker
            
            // initilize site - designer role
            Site s = new Site(10, 10, designer); // 0 planned trees at the begining
            s.AddPlannedPlant(100); // set randomly planted trees on map. Mehtod argument increase chance of tree

            // create threads
            Thread myThread = new Thread(() => Planting(s, worker1, 0));
            myThread.Start();
            Planting(s, worker2, 1);

            // results
            s.ShowMap();

            // close app
            Console.WriteLine("\nPress any key...");
            Console.ReadKey();
        }
    }
}
