using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Ladybugs2
{
    class Ladybugs2 //NeRABOTI
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            var indices = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).Select(int.Parse).Where(x => x>= 0 && x < size-1).ToArray();


            if (size == 0)
            {
                size = int.Parse(Console.ReadLine());                
            }

            var initialArr = new int[size];
            foreach (var num in indices)
            {
                initialArr[num] = 1;
            }
            var command = Console.ReadLine();


            while (true)
            {
                if (command == "end")
                {
                    break;
                }          
                
                var commandArr = command.Split().ToArray();
                int startPosition = int.Parse(commandArr[0]);
                int steps = int.Parse(commandArr[2]);
                string direction = commandArr[1];

                if (initialArr[startPosition] != 1 || steps >= initialArr.Length || steps < 0)
                {
                    command = Console.ReadLine();
                    continue;
                }
                if (direction == "right")
                {
                    int positionToBeChecked = startPosition + steps;

                    if (positionToBeChecked > initialArr.Length-1)
                    {
                        initialArr[startPosition] = 0;
                        break;
                    }
                    for (int i = positionToBeChecked; i < initialArr.Length; i+=steps)
                    {
                        if (initialArr[i] == 0)
                        {
                            initialArr[i] = 1;
                            initialArr[startPosition] = 0;
                        }
                    }
                }
                else if (direction == "left")
                {
                    int positionToBeChecked = startPosition - steps;
                    if (positionToBeChecked < 0)
                    {
                        initialArr[startPosition] = 0;
                        break;
                    }
                    for (int i = positionToBeChecked; i > 0; i -= steps)
                    {
                        if (initialArr[i] == 0)
                        {
                            initialArr[i] = 1;
                            initialArr[startPosition] = 0;
                        }
                    }

                }

                command = Console.ReadLine();
              
            }
            
            Console.WriteLine(String.Join(" ",initialArr));
        }
    }
}
