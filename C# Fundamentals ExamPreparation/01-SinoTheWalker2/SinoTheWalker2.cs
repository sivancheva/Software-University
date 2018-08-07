using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_SinoTheWalker2
{
    class SinoTheWalker2
    {
        static void Main(string[] args)
        {
            var timeStart = Console.ReadLine().Split(':').Select(x => x.Trim()).Select(long.Parse).ToArray();
            long timeStartInSec = timeStart[0] * 3600 + timeStart[1] * 60 + timeStart[2];

            long numberOfSteps = long.Parse(Console.ReadLine());
            long timeForEachStep = long.Parse(Console.ReadLine());

            long timeTotal = timeStartInSec + numberOfSteps * timeForEachStep;

            TimeSpan t = TimeSpan.FromSeconds(timeTotal);

            // bez 2 case, za6toto timeSpan ne priema long(prepulva se)
            Console.WriteLine($"Time Arrival: {t.Hours:D2}:{t.Minutes:D2}:{t.Seconds:D2}");
        }
    }
}
