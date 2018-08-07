using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.BalancedParentheses
{
    class BalancedParentheses
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine().ToCharArray();

            var opening = new char[] {'(','{','['};
            var closing = new char[] { ')', '}', ']' };


            var stack = new Stack<char>();

            if (input.Length % 2 != 0)
            {
                Console.WriteLine("NO");
                Environment.Exit(0);
            }
            foreach (var element in input)
            {
                if (opening.Contains(element))
                {
                    stack.Push(element);
                }
                else if(closing.Contains(element))
                {
                   
                    var lastElement = stack.Pop();
                    var indexLastElement = Array.IndexOf(opening, lastElement);
                    var indexElement = Array.IndexOf(closing, element);

                    if (indexElement != indexLastElement)
                    {
                        Console.WriteLine("NO");
                        Environment.Exit(0);
                    }
                }
            }

            if (stack.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }
    }
}
