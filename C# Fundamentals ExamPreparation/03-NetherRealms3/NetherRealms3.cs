using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03_NetherRealms3
{
    class NetherRealms3
    {
        static void Main(string[] args)
        {
            var daemons = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).OrderBy(x=>x).ToList();


            var patternHealth = new Regex(@"[^\d+\-\*\/\.]");
            var patternDamage = new Regex(@"-?\d+\.?\d*");

            
            foreach (var daemon in daemons)
            {
                var matchedLetters = patternHealth.Matches(daemon).Cast<Match>().Select(a => char.Parse(a.Value)).Select(a => Convert.ToInt32(a)).ToArray();
                int health = matchedLetters.Sum();

                var matchedDigits = patternDamage.Matches(daemon).Cast<Match>().Select(a => decimal.Parse(a.Value)).ToArray();
                decimal damage = matchedDigits.Sum();

                int multiplicator= daemon.Where(x => x == '*').Count();
                int dividor = daemon.Where(x => x == '/').Count();

                decimal damageTotal = damage * (decimal)Math.Pow(2, multiplicator) /(decimal) Math.Pow(2, dividor);
                Console.WriteLine($"{daemon} - {health} health, {damageTotal:f2} damage");
            }

            
        }
    }
}
