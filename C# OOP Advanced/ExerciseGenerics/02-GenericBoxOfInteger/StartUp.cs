using System;

namespace _02_GenericBoxOfInteger
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var box = new GenericBox.Box<int>();

            for (int i = 0; i < n; i++)
            {
                var input = int.Parse(Console.ReadLine());
                box.Element = input;

                Console.WriteLine(box.ToString());
            }
        }
    }
}
