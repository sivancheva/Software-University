using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _00_Exam01
{
    class Snowballs
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int snow = 0;
            int time = 0;
            int quality = 0;
            BigInteger value = 0;

            for (int i = 0; i < n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = 1;
                for (int j = 0; j < snowballQuality; j++)
                {
                    snowballValue *= (snowballSnow / snowballTime);
                }

                if (snowballValue >= value )
                {
                    snow = snowballSnow;
                    time = snowballTime;
                    quality = snowballQuality;
                    value = snowballValue;
                }

            }

            Console.WriteLine($"{snow} : {time} = {value} ({quality})");
        }
    }
}
