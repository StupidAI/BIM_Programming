using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task17_1
{
    /* 1.    Создать класс для моделирования счета в банке. Предусмотреть закрытые поля для номера счета, баланса, ФИО владельца.  
     * Класс должен быть объявлен как обобщенный. Универсальный параметр T должен определять тип номера счета. 
     * Разработать  методы  для  доступа  к  данным  –  заполнения  и  чтения. 
     * Создать  несколько экземпляров класса, параметризированного различными типам. 
     * Заполнить его поля и вывести информацию об экземпляре класса на печать.
     */
    class BankAccount<T>
    {
        //closed from outside fields and properties
        T BankNum { get; set; }
        double Bill { get; set; }
        string UserName { get; set; }

        // constructor
        public BankAccount(string userName, T bankAccount, double bill)
        {
            UserName = userName;
            BankNum = bankAccount;
            Bill = bill;
        }

        // methods
        public void SetName(string userName) // ability to change user name
        {
            UserName = userName;
        }
        public void SetBill(double bill) // ability to change bill
        {
            Bill = bill;
        }
        public void AddMoney(double money) // ability to give some money to account bill
        {
            Bill += money;
        }

        // get info about account
        public void GetInfo()
        {
            Console.WriteLine("Bank account info:");
            Console.WriteLine($"User name: {UserName}");
            Console.WriteLine($"Bank account: {BankNum}");
            Console.WriteLine($"Bill: {Bill}$\n");
        }

    }
}
