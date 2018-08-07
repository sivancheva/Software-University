using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_02_BasicStackOperations
{
    class BasicStackOperations
    {
        static void Main(string[] args)
        {
            var inputArgs = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();

            var countElementsToPush = int.Parse(inputArgs[0]);
            var countElementsToPop = int.Parse(inputArgs[1]);
            var searchedElement = int.Parse(inputArgs[2]);

            var arrayOfNumbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).Select(int.Parse).ToArray();

            Stack<int> stack = new Stack<int>();
            bool isPresent = true;

            for (int i = 0; i < countElementsToPush; i++)
            {
                if (arrayOfNumbers.Length >= countElementsToPush)
                {
                    stack.Push(arrayOfNumbers[i]);
                }

            }

            for (int i = 0; i < countElementsToPop; i++)
            {
                stack.Pop();
            }

            if (stack.Contains(searchedElement))
            {
                Console.WriteLine(isPresent.ToString().ToLower());
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}