using System;
using System.Collections.Generic;
using GenericBox;


namespace _03_GenericSwapMethodStrings
{
   public class StartUp
    {
        static void Main(string[] args)
        {

            var list = new List<Box<double>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = double.Parse(Console.ReadLine());
                var box = new Box<double>
                {
                    Element = input
                };
                list.Add(box);
            }

            var inputComparer = double.Parse(Console.ReadLine());
            Box<double> comparerBox = new Box<double>
            {
                Element = inputComparer
            };
            Console.WriteLine(Solutions.CountStrings(list, comparerBox));
        }

       
    }
}
