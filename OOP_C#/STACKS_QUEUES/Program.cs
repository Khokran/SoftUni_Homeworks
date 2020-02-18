using System;
using System.Linq;
using System.Collections.Generic;

namespace STACKS_QUEUES
{
    class STACK
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] expression = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Stack<string> stack = new Stack<string>(expression.Reverse());

            while (stack.Count > 1)
            {
                if (stack.Contains("*") || stack.Contains("/"))
                {
                    int operand1 = int.Parse(stack.Pop());
                    string opr = stack.Pop();
                    int operand2 = int.Parse(stack.Pop());

                    switch (opr)
                    {
                        case "*":
                            stack.Push($"{operand1 * operand2}"); break;
                        case "/":
                            stack.Push($"{operand1 / operand2}"); break;
                        default:
                            break;
                    }
                }
                else
                {
                    int operand1 = int.Parse(stack.Pop());
                    string opr = stack.Pop();
                    int operand2 = int.Parse(stack.Pop());

                    switch (opr)
                    {
                        case "+":
                            stack.Push($"{operand1 + operand2}"); break;
                        case "-":
                            stack.Push($"{operand1 - operand2}"); break;
                        default:
                            break;
                    }
                }
            }
            Console.WriteLine(stack.Pop());
        }
    }
}
