using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SplinterTrip
{
    class SplinterTrip
    {
        static void Main(string[] args)
        {

            decimal distanceMiles = decimal.Parse(Console.ReadLine());
            decimal fuelCapacity = decimal.Parse(Console.ReadLine());
            decimal distanceWithWind = decimal.Parse(Console.ReadLine());

            decimal distanceWithoutWind = distanceMiles - distanceWithWind;

            decimal neededFuel = distanceWithoutWind * 25m + distanceWithWind * 25m * 1.5m;
            decimal toleranceFuel = neededFuel * 0.05m;
            decimal fuelTotal = neededFuel + toleranceFuel;

            Console.WriteLine($"Fuel needed: {fuelTotal:f2}L");


            decimal remainingFuel = Math.Abs(fuelTotal - fuelCapacity);
            if (fuelTotal <= fuelCapacity)
            {               
                Console.WriteLine($"Enough with {remainingFuel:f2}L to spare!");

            }
            else
            {
                Console.WriteLine($"We need {remainingFuel:f2}L more fuel.");
            }

        }
    }
}
