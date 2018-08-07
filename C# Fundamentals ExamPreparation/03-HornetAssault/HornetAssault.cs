using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_HornetAssault
{
    class HornetAssault
    {
        static void Main(string[] args)
        {

            var beehives = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            var hornets = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            long powerHornets = hornets.Sum();


            for (int i = 0; i < beehives.Count; i++)
            {
                if (hornets.Count == 0)
                {
                    break;
                }

                if (beehives[i] >= powerHornets)
                {
                    hornets.RemoveAt(0);
                    beehives[i] = beehives[i] - powerHornets;
                    powerHornets = hornets.Sum();
                }
                else
                {
                    beehives[i] = 0;
                }

            }

            var resultBeehives = beehives.Where(x => x > 0).ToList();

            if (resultBeehives.Count != 0)
            {
                Console.WriteLine(string.Join(" ", resultBeehives));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }



        }
    }
}