using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.IO;

namespace Task16_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5; // max item count
            int n = 0; // item count
            Item[] itemContaiter = new Item[i];

            // user data input
            while (n != i)
            {
                Console.WriteLine($"=== Item {++n} ===");
                Console.Write($"Enter item CODE: ");
                int code = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Enter item NAME: ");
                string name = Console.ReadLine();
                Console.Write($"Enter item PRICE: ");
                double price = Convert.ToDouble(Console.ReadLine());
                itemContaiter[n - 1] = new Item(code, name, price);
                Console.WriteLine("Item created");
                Console.ReadKey();
                Console.Clear();
            }
            JsonSerializerOptions jso = new JsonSerializerOptions();
            jso.Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic);
            jso.WriteIndented = true;

            // create file in system drive to write json data
            string path = @"C:\Items\Items.json"; // file location. I have no access to drive C directly so put in foldier that creates manualy
            if (!File.Exists(path)) // if file is not exist - create it
            {
                try
                {
                    File.Create(path).Close();
                    Console.WriteLine("File created...");
                }
                catch (AccessViolationException)
                {
                    Console.WriteLine($"No access to {path}!");
                }
            }
            using (StreamWriter sw = new StreamWriter(path)) // write json data to file (with override option)
            {
                foreach (Item item in itemContaiter)
                {
                    sw.WriteLine(JsonSerializer.Serialize(item));
                    Console.WriteLine("File overrided...");
                }
            }

            // Open file
            System.Diagnostics.Process.Start("notepad.exe", path);
        }
    }
}
