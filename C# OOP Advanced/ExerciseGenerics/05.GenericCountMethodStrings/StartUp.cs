using System;
using System.Collections.Generic;
using GenericBox;


namespace _03_GenericSwapMethodStrings
{
   public class StartUp
    {
        static void Main(string[] args)
        {

            var list = new List<Box<string>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var box = new Box<string>
                {
                    Element = input
                };
                list.Add(box);
            }

            var inputComparer = Console.ReadLine();
            Box<string> comparerBox = new Box<string>
            {
                Element = inputComparer
            };
            Console.WriteLine(Solutions.CountStrings(list, comparerBox));
        }

       
    }
}
