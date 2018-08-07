using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.RecursiveFibonacci
{
    class RecursiveFibonacci
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var queue = new Queue<long>();
            queue.Enqueue(1);
            queue.Enqueue(1);

            for (int i = 0; i < n-2; i++)
            {
                var firstNum = queue.Dequeue();
                var secondNum = queue.Peek();
                var sum = firstNum + secondNum;

                queue.Enqueue(sum);
            }
            queue.Dequeue();
            var result = queue.Peek();
            Console.WriteLine($"{result}");
        }
    }
}
