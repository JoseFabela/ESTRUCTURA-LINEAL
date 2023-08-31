using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTRUCTURA_LINEAL
{
    internal class Program
    {
        public static bool AreBracketsBalanced(string input)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char ch in input)
            {
                if (ch == '(' || ch == '[' || ch == '{')
                {
                    stack.Push(ch);
                }
                else if (ch == ')' || ch == ']' || ch == '}')
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }

                    char top = stack.Pop();
                    if ((ch == ')' && top != '(') || (ch == ']' && top != '[') || (ch == '}' && top != '{'))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }
        static void Main(string[] args)
        {
            string input1 = "{[()]}";
            string input2 = "{[(])}";

            Console.WriteLine("Input 1: " + AreBracketsBalanced(input1)); // Output: True
            Console.WriteLine("Input 2: " + AreBracketsBalanced(input2)); // Output: False
            Console.ReadLine();
        }
    }
}
