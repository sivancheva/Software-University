using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Rainer
{
    class Rainer
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).Select(int.Parse).ToList();
            var index = input.Last();
            var gamefield = new List<int>(input);
            gamefield.RemoveAt(input.Count-1);


            int stepsCount = 0;

            while (true)
            {
                gamefield = gamefield.Select(x => x - 1).ToList();
                if (gamefield[index] == 0)
                {
                    break;
                }

                if (gamefield.Contains(0))
                {
                    for (int i = 0; i < gamefield.Count; i++)
                    {
                        if (gamefield[i] == 0)
                        {
                            gamefield[i] = input[i];
                        }
                    }
                }

                index = int.Parse(Console.ReadLine());
                stepsCount++;
            }

            Console.WriteLine(String.Join(" ", gamefield));
            Console.WriteLine(stepsCount);
        }
    }
}
