using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03_Regexmon
{
    class Regexmon
    {
        static void Main(string[] args)
        {

            //var pattern = new Regex(@"(?<Didimon>[^a-zA-Z-]+)*(?<Bojomon>[a-zA-Z]+-[a-zA-Z]+)*");
            var input = Console.ReadLine();
            var patternDidimon = new Regex(@"[^a-zA-Z-]+");
            var patternBojomon = new Regex(@"[a-zA-Z]+-[a-zA-Z]+");

            while (true)
            {
                var matchDidimon = patternDidimon.Match(input);

                if (matchDidimon.Success)
                {
                    Console.WriteLine(matchDidimon.Value.ToString());
                }
                else
                {
                    return;
                }

                int firstSymbolDidimon = matchDidimon.Index;

                input = input.Substring(firstSymbolDidimon + matchDidimon.Length);

                var matchBojomon = patternBojomon.Match(input);

                if (matchBojomon.Success)
                {
                    Console.WriteLine(matchBojomon.Value.ToString());
                }
                else
                {
                    return;
                }
                int firstSymbolBojomon = matchBojomon.Index;
                input = input.Substring(firstSymbolBojomon + matchBojomon.Length);

            }


        }
    }
}