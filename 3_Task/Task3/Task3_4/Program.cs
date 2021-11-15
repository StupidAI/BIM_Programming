using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_4
{
    /* Дано целое число в диапазоне 100–999. Вывести строку-описание данного числа, например: 256 — «двести пятьдесят шесть», 
     * 814 — «восемьсот четырнадцать». Если пользователь введёт данные не соответствующие условию задачи - выдать сообщение об ошибке. 
     */
    class Program
    {
        static void Main(string[] args)
        {
            bool answer = true;
            int number = 0;

            // loop for right answer from user
            while (answer)
            {
                Console.Clear();
                Console.Write("Enter number between 100 and 999: ");
                number = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                if (number < 100 || number > 999)
                {
                    Console.WriteLine("Error: Pleace enter number between 100 and 999");
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                }
                else
                {
                    answer = false;
                }
            }

            int firstRank = number / 100;
            int secondRank = number % 100;
            int thirdRank = secondRank / 10;
            int fourthRank = secondRank % 10;


            string firstWord = "";
            string secondWord = "";
            string thirdWord = "";

            #region Select firsh word
            switch (firstRank)
            {
                case 1:
                    firstWord = "Сто ";
                    break;
                case 2:
                    firstWord = "Двести ";
                    break;
                case 3:
                    firstWord = "Триста ";
                    break;
                case 4:
                    firstWord = "Четыреста ";
                    break;
                case 5:
                    firstWord = "Пятьсот ";
                    break;
                case 6:
                    firstWord = "Шестьсот ";
                    break;
                case 7:
                    firstWord = "Семьсот ";
                    break;
                case 8:
                    firstWord = "Восемьсот ";
                    break;
                case 9:
                    firstWord = "Девятьсот ";
                    break;
                default:
                    firstWord = "";
                    break;
            }
            #endregion


            if (secondRank > 0 && secondRank < 20)
            {
                #region Select second word 1...19
                switch (secondRank)
                {
                    case 1:
                        secondWord = "один";
                        break;
                    case 2:
                        secondWord = "два";
                        break;
                    case 3:
                        secondWord = "три";
                        break;
                    case 4:
                        secondWord = "четыре";
                        break;
                    case 5:
                        secondWord = "пять";
                        break;
                    case 6:
                        secondWord = "шесть";
                        break;
                    case 7:
                        secondWord = "семь";
                        break;
                    case 8:
                        secondWord = "восемь";
                        break;
                    case 9:
                        secondWord = "девять";
                        break;
                    case 10:
                        secondWord = "десять";
                        break;
                    case 11:
                        secondWord = "одиннадцать";
                        break;
                    case 12:
                        secondWord = "двенадцать";
                        break;
                    case 13:
                        secondWord = "тринадцать";
                        break;
                    case 14:
                        secondWord = "четырнадцать";
                        break;
                    case 15:
                        secondWord = "пятнадцать";
                        break;
                    case 16:
                        secondWord = "шестнадцать";
                        break;
                    case 17:
                        secondWord = "семнадцать";
                        break;
                    case 18:
                        secondWord = "восемнадцать";
                        break;
                    case 19:
                        secondWord = "девятнадцать";
                        break;
                    default:
                        secondWord = "";
                        break;
                }
                #endregion
            }
            else
            {
                #region Select second word 20...90
                switch (thirdRank)
                {
                    case 2:
                        secondWord = "двадцать ";
                        break;
                    case 3:
                        secondWord = "тридцать ";
                        break;
                    case 4:
                        secondWord = "сорок ";
                        break;
                    case 5:
                        secondWord = "пятьдесят ";
                        break;
                    case 6:
                        secondWord = "шестьдесят ";
                        break;
                    case 7:
                        secondWord = "семьдесят ";
                        break;
                    case 8:
                        secondWord = "восемьдесят ";
                        break;
                    case 9:
                        secondWord = "девяносто ";
                        break;
                    default:
                        secondWord = "";
                        break;
                }
                #endregion

                #region Select third word 1...9
                switch (fourthRank)
                {
                    case 1:
                        thirdWord = "один";
                        break;
                    case 2:
                        thirdWord = "два";
                        break;
                    case 3:
                        thirdWord = "три";
                        break;
                    case 4:
                        thirdWord = "четыре";
                        break;
                    case 5:
                        thirdWord = "пять";
                        break;
                    case 6:
                        thirdWord = "шесть";
                        break;
                    case 7:
                        thirdWord = "семь";
                        break;
                    case 8:
                        thirdWord = "восемь";
                        break;
                    case 9:
                        thirdWord = "девять";
                        break;
                    default:
                        thirdWord = "";
                        break;
                }
                #endregion
            }

            // output
            Console.WriteLine($"Text representation of number {number} is: {firstWord}{secondWord}{thirdWord}");
            Console.WriteLine("\nPress any key...");
            Console.ReadKey();
        }
    }
}
