using System;
using System.Collections.Generic;
using GenericBox;

namespace _03_GenericSwapMethodStrings
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            var list = new List<Box<int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = int.Parse(Console.ReadLine());
                var box = new Box<int>
                {
                    Element = input
                };
                list.Add(box);
            }

            Solutions.SwapMethodIntegers(list);

            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }
                        
        }
    }
}
