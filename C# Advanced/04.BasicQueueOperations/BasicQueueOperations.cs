using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BasicQueueOperations
{
    class BasicQueueOperations
    {
        static void Main(string[] args)
        {
            var inputArgs = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();

            var countElementsToPush = int.Parse(inputArgs[0]);
            var countElementsToPop = int.Parse(inputArgs[1]);
            var searchedElement = int.Parse(inputArgs[2]);

            var arrayOfNumbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).Select(int.Parse).ToArray();

            Queue<int> queue = new Queue<int>();
            bool isPresent = true;

            for (int i = 0; i < countElementsToPush && i< arrayOfNumbers.Length; i++)
            {
                queue.Enqueue(arrayOfNumbers[i]);
            }

            for (int i = 0; i < countElementsToPop; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(searchedElement))
            {
                Console.WriteLine(isPresent.ToString().ToLower());
            }
            else if (queue.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine($"{queue.Min()}");
            }
        }
    }
}
