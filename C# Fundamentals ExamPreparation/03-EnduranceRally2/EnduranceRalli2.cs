using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_EnduranceRally2
{
    class Program
    {
        static void Main(string[] args)
        {
            var drivers = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
            var track = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).Select(decimal.Parse).ToArray();
            var indices= Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).Select(int.Parse).Where(x=> x>=0 && x < track.Length).ToArray();

          
            foreach (var driver in drivers)
            {
                int zone = 0;
                bool isFinished = true;

                decimal initialFuel = driver[0];
                decimal currentFuel = initialFuel;

                for (int i = 0; i < track.Length; i++)
                {
                    if (indices.Contains(i))
                    {
                        currentFuel += track[i];
                    }
                    else
                    {
                        currentFuel -= track[i];
                    }
                    if (currentFuel <= 0 )
                    {
                        zone = i;
                        isFinished = false;
                        break;
                    }
                }
                if (isFinished)
                {
                    Console.WriteLine($"{driver} - fuel left {currentFuel:f2}");
                }
                else
                {
                    Console.WriteLine($"{driver} - reached {zone}");
                }
               
            }
        }
    }
}
