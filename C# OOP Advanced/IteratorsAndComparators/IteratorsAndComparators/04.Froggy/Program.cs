using System;
using System.Linq;

namespace _04.Froggy
{
    class Program
    {
        static void Main(string[] args)
        {
             var elements = Console.ReadLine().Split(new char[] { ' ', ','}, StringSplitOptions.RemoveEmptyEntries).ToList();
            var lake = new Lake<string>(elements);
        }
    }
}
