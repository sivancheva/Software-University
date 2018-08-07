using System;
using System.Linq;

namespace _03.CustomMinFunction
{
    class CustomMinFunction
    {
        static void Main(string[] args)
        {
            Func<int[], int> smallestInt = x => x.Min();

            var input = Console.ReadLine().Split(new char[] { ' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Console.WriteLine(smallestInt(input)); 
        }
    }
}
