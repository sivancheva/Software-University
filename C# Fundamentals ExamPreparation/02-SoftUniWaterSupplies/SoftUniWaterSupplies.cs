using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _02_SoftUniWaterSupplies
{
    class SoftUniWaterSupplies
    {
        static void Main(string[] args)
        {
            decimal waterTotal = decimal.Parse(Console.ReadLine());
            var array = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            decimal capacity = decimal.Parse(Console.ReadLine());


            var currIndexes = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                currIndexes.Add(i);
            }
            var currList = new List<decimal>(array);
            
            int bottlesCount = 0;
            decimal waterCurrent = waterTotal;
          
            var waterToFill = 0m;

            if (waterTotal % 2 == 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    
                    if (waterCurrent < 0)
                    {
                        break;
                    }
                    waterToFill = capacity - array[i];
                    
                    waterCurrent -= waterToFill;
                    
                    if (waterCurrent >=0)
                    {
                        currIndexes.RemoveAt(0);
                        currList[i] = currList[i] + waterToFill;
                        bottlesCount++;
                    }
                    else
                    {
                        currList[i] = currList[i] + (waterToFill + waterCurrent);
                    }
                        
                }
            }
            else
            {
                int counter = 1;
                for (int i = array.Length - 1;  i >= 0; i--)
                {
                    
                    if (waterCurrent < 0)
                    {
                        break;
                    }
                    waterToFill = capacity - array[i];
                    
                    waterCurrent -= waterToFill;
                    
                    if (waterCurrent >= 0)
                    {
                        currIndexes.RemoveAt(currIndexes.Count - 1);
                        currList[array.Length - counter] = currList[array.Length - counter] + waterToFill;
                        bottlesCount++;
                        counter++;
                    }
                    else
                    {
                        currList[array.Length - counter] = currList[array.Length - counter] + (waterToFill + waterCurrent);
                    }
                }
            }
            if (waterCurrent >= 0 )
            {
                Console.WriteLine("Enough water!");
                Console.WriteLine($"Water left: {waterCurrent}l.");
            }
            else
            {
                currIndexes.Reverse();

                currList = currList.Where(x => x != capacity).ToList();
                var nededWater = capacity * currList.Count - currList.Sum();

                Console.WriteLine("We need more water!");
                Console.WriteLine($"Bottles left: {array.Length - bottlesCount}");
                Console.Write("With indexes: ");
                Console.WriteLine(String.Join(", ", currIndexes));
                Console.WriteLine($"We need {nededWater} more liters!");
            }

        }
    }
}
