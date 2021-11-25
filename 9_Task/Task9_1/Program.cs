using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9_1
{
    class Program
    {
        /* Смоделируйте работу простого калькулятора. Программа должна запрашивать 2 числа, а затем – код операции 
         * (например, 1 – сложение, 2 – вычитание, 3 – произведение, 4 – частное). После этого на консоль выводится ответ. 
         * Используйте обработку исключений для защиты от ввода некорректных данных.
         */
        static void Main(string[] args)
        {
            // intro
            Console.WriteLine("Hello human! Let's do rocket science!\n");

            // user input
            int num1 = UserInput("Enter first int number : ");
            int num2 = UserInput("Enter second int number : ");

            // select function
            Console.WriteLine("Select function :");
            Console.WriteLine("\t1: +\n\t2: -\n\t3: *\n\t4: /\n");
            Console.Write("Your choise is : ");
            string function = Console.ReadLine();
            Console.WriteLine();
            switch (function)
            {
                case "1":
                    Sum(num1, num2);
                    break;
                case "2":
                    Subtraction(num1, num2);
                    break;
                case "3":
                    Multiply(num1, num2);
                    break;
                case "4":
                    Devide(num1, num2);
                    break;
                default:
                    Console.WriteLine("There is no such function...");
                    break;
            }
            Console.WriteLine("\nPress any key...");
            Console.ReadKey();
        }

        // user input method. Can catch Format and OverFlow Exception
        static int UserInput(string message)
        {
            int result = 1;
            Console.Write(message);
            try
            {
                result = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Input is not correct!");
                CloseApp();
            }
            catch (OverflowException)
            {
                Console.WriteLine("Number is to BIG/small...");
                CloseApp();
            }
            return result;
        }

        // find sum of a and b. Can catch OverFlow Exception if numbers are positive both
        static void Sum(int a, int b)
        {
            try
            {
                Console.WriteLine($"{a} + {b} = {a + b}");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Result is to BIG/small...");
                CloseApp();
            }
        }

        // find substraction of a and b. Can catch OverFlow Exception if numbers are negative both
        static void Subtraction(int a, int b)
        {
            try
            {
                Console.WriteLine($"{a} - {b} = {a - b}");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Result is to BIG/small...");
                CloseApp();
            }
        }

        // find multiply of a and b. Can catch OverFlow Exception if result is to big for Int32
        static void Multiply(int a, int b)
        {
            try
            {
                Console.WriteLine($"{a} * {b} = {a * b}");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Result is to BIG/small...");
                CloseApp();
            }
        }

        // find multiply of a and b. Can throw Divide by zero Exception if b == 0
        static void Devide(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Divide by zero unacceptable");
                CloseApp();
            }
            Console.WriteLine($"{a} / {b} = {(double)a / b}");
        }

        // emergency close
        static void CloseApp()
        {
            Console.WriteLine("\nPress any key...");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}