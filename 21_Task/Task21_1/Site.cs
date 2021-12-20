using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task21_1
{
    // Class represent map where trees is located. 0 - empty tree, 1 - real tree.
    public class Site
    {
        // tree storage
        public Tree[,] Map { get; private set; }
        // ability to get items at index
        public Tree this[int lIndex, int wIndex]
        {
            get => Map[lIndex, wIndex];
            set => Map[lIndex, wIndex] = value;
        }
        // properties that set Map size
        public int Length { get; }
        public int Width { get; }
        // constructor
        public Site(int l, int w, Worker wr)
        {
            Length = l;
            Width = w;
            Map = new Tree[w, l];
            // trees initialization
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    Map[i, j] = new Tree(wr);
                }
            }
        }
        /// <summary>
        /// Create trees to the site. Plant rate incerase chance to plant a tree.
        /// Value 1..100
        /// </summary>
        /// <param name="plantRate"></param>
        public void AddPlannedPlant(int plantRate)
        {
            Random random = new Random();
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    Map[i, j].Symbol = ((int)Math.Round(random.NextDouble() + plantRate / 200)).ToString();
                }
            }
        }
        // method for map view in console. Also calculate statistics (stats).
        public void ShowMap()
        {
            Console.Clear();
            Dictionary<Worker, int> planted = new Dictionary<Worker, int>(); // store stats
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Length; j++)
                {
                    if (!planted.ContainsKey(Map[i, j].Role)) // add new worker to stats
                    {
                        planted.Add(Map[i, j].Role, 1);
                    }
                    else
                    {
                        planted[Map[i, j].Role]++;
                    }
                    Console.ForegroundColor = Map[i, j].Role.Color; // set tree view color for console
                    Console.Write(Map[i, j].Symbol + "  ");
                    Console.ResetColor();
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            foreach (KeyValuePair<Worker, int> item in planted) // view stats
            {
                Console.WriteLine($"{item.Key.Name}[{item.Key.Color}] plant {item.Value} trees");
            }
        }
    }
}
