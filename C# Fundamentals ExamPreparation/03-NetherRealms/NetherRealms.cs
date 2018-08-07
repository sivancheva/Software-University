using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03_NetherRealms
{
    class NetherRealms
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            Array.Sort(input);


            var patternLetters = new Regex(@"[^\d+\-\*\/\.]");
            var patternDigits = new Regex(@"-?\d+\.?\d*");

            foreach (var daemon in input)
            {
                var matchedLetters = patternLetters.Matches(daemon).Cast<Match>().Select(a => char.Parse(a.Value)).Select(a => Convert.ToInt32(a)).ToArray();
                int health = matchedLetters.Sum();

                var matchedDigits = patternDigits.Matches(daemon).Cast<Match>().Select(a => double.Parse(a.Value)).ToArray();
                double damage = matchedDigits.Sum();

                int multiplicator = daemon.Where(a => a == '*').Count();
                int dividor = daemon.Where(a => a == '/').Count();

                var damageTotal = damage * Math.Pow(2, multiplicator) / Math.Pow(2, dividor);

                Console.WriteLine($"{daemon} - {health} health, {damageTotal:f2} damage");
            }

        }

    }

}