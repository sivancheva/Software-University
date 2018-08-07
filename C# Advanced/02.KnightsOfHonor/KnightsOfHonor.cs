using System;
using System.Linq;

namespace _02.KnightsOfHonor
{
    class KnightsOfHonor
    {
        static void Main(string[] args)
        {
            Action<string[]> namesOfHonor = n => Console.WriteLine(String.Join(Environment.NewLine, n.Select(x => "Sir " + x)));

            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            namesOfHonor(input);
        }
    }
}
