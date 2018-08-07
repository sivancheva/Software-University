using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CharityMarathon
{
    class CharityMarathon
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int participantsNumber = int.Parse(Console.ReadLine());
            int numberOfLaps = int.Parse(Console.ReadLine());
            int lapLength = int.Parse(Console.ReadLine());
            int truckCapacity = int.Parse(Console.ReadLine());
            decimal moneyPerKm = decimal.Parse(Console.ReadLine());

            if (truckCapacity * days <= participantsNumber)
            {
                participantsNumber = truckCapacity * days;
            }

            long totalKm = ((long)participantsNumber * (long)numberOfLaps * (long)lapLength) / 1000l;

            decimal moneyCollected = (decimal)totalKm * moneyPerKm;
            Console.WriteLine($"Money raised: {moneyCollected:f2}");

        }
    }
}
