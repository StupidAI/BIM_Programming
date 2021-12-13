using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // create first account
            BankAccount<int> ba1 = new BankAccount<int>("User 1", 150150, 50);
            ba1.GetInfo();
            ba1.SetName("Ivan"); // change user name
            ba1.SetBill(150000); // change money info
            ba1.GetInfo();

            // create second account
            Console.WriteLine("Next Bank account:");
            BankAccount<string> ba2 = new BankAccount<string>("Alex", "150-5151", 0);
            ba2.GetInfo();
            ba2.AddMoney(155.5); // add some money
            ba2.GetInfo();

            // close app
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
