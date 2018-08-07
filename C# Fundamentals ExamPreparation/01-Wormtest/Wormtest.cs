using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Wormtest
{
    class Wormtest
    {
        static void Main(string[] args)
        {

            int length = int.Parse(Console.ReadLine())*100; // in cm
            decimal width = decimal.Parse(Console.ReadLine());
            
            if (width == 0 || length % (int)width == 0)
            {
                decimal product = (decimal)length * width;
                Console.WriteLine($"{product:f2}");
                return;
            }                        
            else
            {
                decimal precentace = ((decimal)length/width)*100m;
                Console.WriteLine($"{precentace:f2}%");
            }
         }
    }
}
