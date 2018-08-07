using System;

namespace _01_GenericBoxOfString
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var box = new GenericBox.Box<string>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                box.Element = input;

                Console.WriteLine(box.ToString());
            }
        }
    }
}
