using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03_PhoenixGrid
{
    class PhoenixGrid
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine();
            var pattern = new Regex(@"^([^_\s]{3})(\.[^_\s]{3})*$");
            var result = new List<string>();

            while (input != "ReadMe")
            {
                var match = pattern.Match(input);

                if (!match.Success)
                {
                    Console.WriteLine("NO");
                    input = Console.ReadLine();
                    continue;
                }
                else
                {
                    var matchesString = match.ToString();
                    string s1 = matchesString.Substring(0, matchesString.Length / 2);
                    string s2 = matchesString.Substring((matchesString.Length / 2 + 1), matchesString.Length - (matchesString.Length / 2 + 1));

                    char[] charArray = s2.ToCharArray();
                    Array.Reverse(charArray);
                    string reversedS2 = new string(charArray);

                    if (s1 == reversedS2)
                    {
                        Console.WriteLine("YES");

                    }
                    else
                    {
                        Console.WriteLine("NO");
                    }

                }
                input = Console.ReadLine();
            }
        }
    }
}