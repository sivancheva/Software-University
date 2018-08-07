using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _03.MaximumElement
{
    class MaximumElement
    {
        static void Main(string[] args)
        {
            Stack<long> stack = new Stack<long>();
            int n = int.Parse(Console.ReadLine());
            var list = new List<long>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var command = input[0];

                if (command == '1')
                {
                    var elementToPush = (input.Split().Select(long.Parse).ToArray())[1];
                    stack.Push(elementToPush);
                 
                }
                else if(command == '2')
                {
                    var elementToPop = stack.Peek();
                    stack.Pop();
                   
                }
                else if(command == '3')
                {
                    Console.WriteLine(stack.Max());
                }
            }
        }
    }
}
