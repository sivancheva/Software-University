using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _00_Exam03
{
    class Snowflake
    {
        static void Main(string[] args)
        {
            
            var surface = new Regex(@"^(?<surface>[^a-zA-Z0-9]+)$");
            var mantel = new Regex(@"^(?<mantel>[0-9_]+)$");
            var allTogether = new Regex(@"^(?<surface>[^a-zA-Z0-9]+)(?<mantel>[0-9_]+)(?<core>[a-zA-Z]+)(?<mantel2>[0-9_]+)(?<surface2>[^a-zA-Z0-9]+)$");

            var listInput = new List<string>();

            for (int i = 0; i < 5; i++)
            {
                listInput.Add(Console.ReadLine());
            }

            var matchSurfaceFirst = surface.Match(listInput[0]);
            var matchMantelFirst = mantel.Match(listInput[1]);
            var matchAllTogether = allTogether.Match(listInput[2]);
            var matchMantelSecond = mantel.Match(listInput[3]);
            var matchSurfaceSecond = surface.Match(listInput[4]);

            if (matchSurfaceFirst.Success &&
                matchMantelFirst.Success &&
                matchAllTogether.Success &&
                matchMantelSecond.Success &&
                matchSurfaceSecond.Success)
            {

                var coreLength = matchAllTogether.Groups["core"].Value.ToString().Length;
                Console.WriteLine("Valid");
                Console.WriteLine(coreLength);
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
