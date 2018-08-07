using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    class ReverseNumbersWithStack
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();


            var n = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>();


            for (int i = 0; i < n.Length; i++)
            {
                stack.Push(n[i]);
            }

            foreach (var item in stack.ToList())
            {
                Console.Write($"{stack.Pop()} ");
            }

        }
    }
}
