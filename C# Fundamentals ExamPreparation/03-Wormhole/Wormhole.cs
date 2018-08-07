using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Wormhole
{
    class Wormhole
    {
        static void Main(string[] args)
        {
            var inputArr = Console.ReadLine().Split().Select(int.Parse).ToArray();
                       
            int counterSteps = 0;
            int currentIndex = 0;

            for (int i = 0; i < inputArr.Length; i = currentIndex)
            {
                
                if (inputArr[i] != 0)
                {
                    currentIndex = inputArr[i]+1;
                    inputArr[i] = 0;

                }
                else
                {
                    currentIndex++;
                }
                
                counterSteps++;
            }
                
            Console.WriteLine(counterSteps);


        }          
        
    }
}
