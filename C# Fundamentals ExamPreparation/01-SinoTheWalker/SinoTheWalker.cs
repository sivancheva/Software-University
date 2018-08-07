using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SinoTheWalker
{
    class SinoTheWalker
    {
        static void Main(string[] args)
        {
            var startTime = Console.ReadLine().Split(':').Select(x => x.Trim()).Select(long.Parse).ToArray();
            long numberOfSteps = long.Parse(Console.ReadLine());
            long secondsForStep = long.Parse(Console.ReadLine());

            long startTimeInSeconds = startTime[0] * 3600 + startTime[1] * 60 + startTime[2];
            long arrivedTimeInSeconds = startTimeInSeconds + (numberOfSteps * secondsForStep);

            long days = arrivedTimeInSeconds / 86400; //smjatame dnite
            long timeArrivedHours = (arrivedTimeInSeconds-(days*86400)) / 3600; //mahame dnite, koito sme prevurnali v sec
            long timeArriveMinutes = (arrivedTimeInSeconds % 3600) / 60;
            long timeArriveSeconds = arrivedTimeInSeconds % 60;


            Console.WriteLine($"Time Arrival: {timeArrivedHours:D2}:{timeArriveMinutes:D2}:{timeArriveSeconds:D2}");

        }
    }
}

