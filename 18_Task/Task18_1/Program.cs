using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task18_1
{
    class Program
    {
        /* Дана строка, содержащая скобки трёх видов (круглые, квадратные и фигурные) и любые другие символы. 
         * Проверить, корректно ли в ней расставлены скобки. Например, в строке ([]{})[] скобки расставлены корректно, 
         * а в строке ([]] — нет. Указание: задача решается однократным проходом по символам заданной строки слева направо; 
         * для каждой открывающей скобки в строке в стек помещается соответствующая закрывающая, каждая закрывающая скобка 
         * в строке должна соответствовать скобке из вершины стека (при этом скобка с вершины стека снимается); 
         * в конце прохода стек должен быть пуст.
         */
        static void Main(string[] args)
        {
            //user input
            Console.WriteLine("Please enter string");
            string s = Console.ReadLine();

            // dictionary for bracket pairs
            Dictionary<char, char> bracket = new Dictionary<char, char>();
            bracket.Add('[', ']');
            bracket.Add('(', ')');
            bracket.Add('{', '}');

            Stack<char> stack = new Stack<char>(); // create stack instance
            char[] sChars = s.ToCharArray(); // convert string to array for iterating
            foreach (char c in sChars)
            {
                if (bracket.ContainsKey(c)) // if char is dict key -> push value to stack
                {
                    stack.Push(bracket[c]);
                }
                else if (stack.Count() == 0) // if stack is empty and "c" is any close bracket - uncorrect
                {
                    Console.WriteLine("Brackets placement is not correct");
                    Console.WriteLine("\nPress any key...");
                    Console.ReadKey();
                    return;
                }
                else if (stack.Peek() == c) // check last item in stack: if it equal C remove it from stack
                {
                    stack.Pop();
                }
            }
            if (stack.Count() != 0) // if stack empty - string is correct
            {
                Console.WriteLine("Brackets placement is not correct");
            }
            else
            {
                Console.WriteLine("Brackets placement is correct");
            }

            // close app
            Console.WriteLine("\nPress any key...");
            Console.ReadKey();
        }
    }
}
