using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace NetherRealms2
{
    class NetherRealms2
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine().Split(new[] { ',' ,' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
            Array.Sort(input);

            var patternLetter = new Regex(@"[^\d+\-\*\/\.]");
            var patterndigits = new Regex(@"-?\d+\.?\d*");
                                          
            foreach (var daemon in input)
            {
                var healthMatch = patternLetter.Matches(daemon).Cast<Match>().Select(a => char.Parse(a.Value)).Select(a => Convert.ToInt32(a)).ToArray();
                var health = healthMatch.Sum();

                var damageMatch = patterndigits.Matches(daemon).Cast<Match>().Select(a => double.Parse(a.Value)).ToArray();

                var damage = damageMatch.Sum();

                int multiplicator = daemon.Where(x => x == '*').Count();
                int dividor = daemon.Where(x => x == '/').Count();

                var damageTotal = damage * Math.Pow(2, multiplicator) / Math.Pow(2, dividor);

                Console.WriteLine($"{daemon} - {health} health, {damageTotal:f2} damage");

            }
           

        }
    }
}
