using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SequenceWithQueue
{
    class SequenceWithQueue
    {
        static void Main(string[] args)
        {
            Queue<long> queue = new Queue<long>();

            Queue<long> result = new Queue<long>();
          
            var s1 = long.Parse(Console.ReadLine());

            queue.Enqueue(s1);
            result.Enqueue(s1);

            while (result.Count < 50)
            {
                for (int i = 0; i < 3; i++)
                {
                    long currentS = queue.Dequeue();
                    long firstNum = currentS + 1;
                    long secondNum = 2*currentS + 1;
                    long thirdNum = currentS + 2;

                    queue.Enqueue(firstNum);
                    queue.Enqueue(secondNum);
                    queue.Enqueue(thirdNum);

                    result.Enqueue(firstNum);
                    result.Enqueue(secondNum);
                    result.Enqueue(thirdNum);

                  
                }
            }


            Console.WriteLine(String.Join(" ", result.ToArray().Take(50)));
            
        }
    }
}
