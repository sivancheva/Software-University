using System;
using System.Linq;

class EnduranceRally
{
    static void Main()
    {
        var drivers = Console.ReadLine().Split(' ');
        var zone = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
        var checkpointsIndex = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        var lastZone = 0;

        for (int i = 0; i < drivers.Length; i++)
        {
            var isFinished = true;
            var fuelLeft = (double)drivers[i][0]; //Начално гориво -> първата буква от името на пилота...

            for (int j = 0; j < zone.Length; j++)
            {
                if (checkpointsIndex.Contains(j)) fuelLeft += zone[j];
                else fuelLeft -= zone[j];

                if (fuelLeft <= 0)
                {
                    lastZone = j;
                    isFinished = false;
                    break;
                }
            }

            if (isFinished) Console.WriteLine($"{drivers[i]} - fuel left {fuelLeft:f2}");
            else Console.WriteLine($"{drivers[i]} - reached {lastZone}");
        }
    }
}
