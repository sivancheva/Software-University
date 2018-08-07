using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regexmon2
{
    class Regexmon2
    {
        static void Main(string[] args)
        {
            
            var input = Console.ReadLine();
            var patternDididmon = new Regex(@"[^a-zA-Z-]+");
            var patternBojomon = new Regex(@"[a-zA-Z]+-[a-zA-Z]+");


            while (true)
            {
                var matchesDidimon = patternDididmon.Match(input);

                if (matchesDidimon.Success)
                {
                    Console.WriteLine(matchesDidimon.Value.ToString());
                }
                else
                {
                    return;
                }

                int countToRemoveDidi = input.IndexOf(matchesDidimon.ToString()) + matchesDidimon.Value.Length;
                input = input.Remove(0, countToRemoveDidi);


                var matchesBojomon = patternBojomon.Match(input);
                if (matchesBojomon.Success)
                {
                    Console.WriteLine(matchesBojomon.Value.ToString());
                }
                else
                {
                    return;
                }

                int countToRemoveBojo = input.IndexOf(matchesBojomon.Value.ToString()) + matchesBojomon.Value.Length;
                input = input.Remove(0, countToRemoveBojo);
            }
            
                                  
        }
    }
}
