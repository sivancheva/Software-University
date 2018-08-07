using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_TruckTour
{
    class TruckTour
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            var queue = new Queue<int[]>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                queue.Enqueue(input);
            }


            for (int currStart = 0; currStart < n-1; currStart++)
            {

                long fuelTotal = 0;
                bool isSolution = true;

                for (int passesStations = 0; passesStations < n; passesStations++)
                {
                    var currentStation = queue.Dequeue();
                    var currFuel = currentStation[0];
                    var distance = currentStation[1];

                    queue.Enqueue(currentStation);

                    fuelTotal += currFuel - distance;

                    if (fuelTotal < 0)
                    {
                        currStart += passesStations;
                        isSolution = false;
                        break;

                    }

                }
                if (isSolution)
                {
                    Console.WriteLine(currStart);
                   // Environment.Exit(0);
                    return;
                }
            }

            
        }
    }
}
