using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Resurrection
{
    class Resurrection
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                long lengthBody = long.Parse(Console.ReadLine());
                decimal widthBody = decimal.Parse(Console.ReadLine());
                long lengthWing = long.Parse(Console.ReadLine()) * 2;

                decimal years = ((decimal)Math.Pow(lengthBody, 2)) * (widthBody + lengthWing);
                Console.WriteLine(years);
            }


        }
    }
}