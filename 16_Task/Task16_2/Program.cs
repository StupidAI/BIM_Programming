using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Task16_1;
using System.Text.Json;


namespace Task16_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Item mostExpencive = new Item(); // create new item by default constructor with lowest price
            string path = @"C:\Items\Items.json"; // file location
            if (File.Exists(path))
            {
                // open file and read it line by line
                using(StreamReader sr = new StreamReader(path))
                {
                    string line = sr.ReadLine();
                    while (line != null) // stop iterating if file is end
                    {
                        Item i = JsonSerializer.Deserialize<Item>(line);
                        mostExpencive = (i.Price > mostExpencive.Price) ? i : mostExpencive; // find most expensive item
                        line = sr.ReadLine(); // step to next line
                    }
                }
            }
            else
            {
                throw new FileNotFoundException($"File {path} not found!");
            }

            // close app
            Console.WriteLine($"Most expensive item in list is: {mostExpencive.Name}");
            Console.WriteLine("\nPress any key...");
            Console.ReadKey();
        }
    }
}
