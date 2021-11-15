using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_3
{
    /* Обязательная задача*. Дано целое число в диапазоне 20–69, определяющее возраст (в годах). 
     * Вывести строку-описание указанного возраста, обеспечив правильное согласование числа со словом «год», 
     * например: 20 — «двадцать лет», 32 — «тридцать два года», 41 — «сорок один год». 
     * Если пользователь введёт данные не соответствующие условию задачи - выдать сообщение об ошибке.
     */
    class Program
    {
        static void Main(string[] args)
        {
            bool answer = true;
            int age = 0;

            // loop for right answer from user
            while (answer)
            {
                Console.Clear();
                Console.Write("Enter number between 20 and 69: ");
                age = Convert.ToByte(Console.ReadLine());
                Console.WriteLine();

                if (age < 20 || age > 69)
                {
                    Console.WriteLine("Error: Pleace enter number between 20 and 69");
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                }
                else
                {
                    answer = false;
                }

            }

            int firstRank = age / 10;
            int secondRank = age % 10;

            string firstWord;
            string secondWord;
            string ageWord;

            // Select firsh word
            switch (firstRank)
            {
                case 2:
                    firstWord = "Двадцать ";
                    break;
                case 3:
                    firstWord = "Тридцать ";
                    break;
                case 4:
                    firstWord = "Сорок ";
                    break;
                case 5:
                    firstWord = "Пятьдесят ";
                    break;
                case 6:
                    firstWord = "Шестьдесят ";
                    break;
                default:
                    firstWord = "";
                    break;
            }

            // Select second word
            switch (secondRank)
            {
                case 1:
                    secondWord = "один ";
                    break;
                case 2:
                    secondWord = "два ";
                    break;
                case 3:
                    secondWord = "три ";
                    break;
                case 4:
                    secondWord = "четыре ";
                    break;
                case 5:
                    secondWord = "пять ";
                    break;
                case 6:
                    secondWord = "шесть ";
                    break;
                case 7:
                    secondWord = "семь ";
                    break;
                case 8:
                    secondWord = "восемь ";
                    break;
                case 9:
                    secondWord = "девять ";
                    break;
                default:
                    secondWord = "";
                    break;
            }

            // Select third word
            if (secondRank == 1)
            {
                ageWord = "год";
            }
            else if (secondRank > 1 && secondRank < 5)
            {
                ageWord = "года";
            }
            else
            {
                ageWord = "лет";
            }

            // output
            Console.WriteLine($"Text representation of age {age} is: {firstWord}{secondWord}{ageWord}");
            Console.WriteLine("\nPress any key...");
            Console.ReadKey();
        }
    }
}
