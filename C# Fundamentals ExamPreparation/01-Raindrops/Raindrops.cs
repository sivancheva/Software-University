using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Raindrops
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine()); //amount of regions
            var density = decimal.Parse(Console.ReadLine()); //density

            var sumCoeff = 0m;

           
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).Select(decimal.Parse).ToList();
                var raindropsCount = input[0];
                var squareMeters = input[1];
                var coefficient = raindropsCount / squareMeters;
                sumCoeff += coefficient;
            }
            if (density == 0)
            {
                Console.WriteLine($"{sumCoeff:f3}");
            }
            else
            {
                var result =(sumCoeff / density);
                Console.WriteLine($"{result:f3}");
            }
        }
    }
}
